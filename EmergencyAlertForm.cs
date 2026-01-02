using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class EmergencyAlertForm : Form
{
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public EmergencyAlertForm()
    {
        InitializeComponent();
        this.Load += EmergencyAlertForm_Load;
        this.btnSearchDrivers.Click += BtnSearchDrivers_Click;
        this.btnReassign.Click += BtnReassign_Click;
    }

    private void EmergencyAlertForm_Load(object? sender, EventArgs e)
    {
        EnsureDatabaseSchema();
        LoadActiveTrips();
    }

    private void EnsureDatabaseSchema()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                
                // 1. Ensure 'Status' column exists in Trips table for PAUSING logic
                string checkStatusColumn = @"
                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Trips') AND name = 'Status')
                    BEGIN
                        ALTER TABLE Trips ADD Status NVARCHAR(50) DEFAULT 'Active';
                        -- Update existing records to 'Active'
                        EXEC('UPDATE Trips SET Status = ''Active'' WHERE Status IS NULL');
                    END";
                using (SqlCommand cmd = new SqlCommand(checkStatusColumn, conn)) { cmd.ExecuteNonQuery(); }

                // 2. Ensure EmergencyLogs table exists
                string checkLogsTable = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EmergencyLogs')
                    BEGIN
                        CREATE TABLE EmergencyLogs (
                            Log_id INT PRIMARY KEY IDENTITY(1,1),
                            Old_Trip_id INT,
                            Reason NVARCHAR(MAX),
                            Log_Date DATETIME DEFAULT GETDATE(),
                            New_Trip_id INT
                        );
                    END";
                using (SqlCommand cmd = new SqlCommand(checkLogsTable, conn)) { cmd.ExecuteNonQuery(); }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Schema Setup Error: " + ex.Message);
        }
    }

    private void LoadActiveTrips()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                // Showing all trips that aren't 'Cancelled' or 'Finished'
                // If the user has no trips with status, we fallback to showing all trips for visibility
                string query = @"
                    SELECT 
                        t.Trip_id, 
                        d.Name as DriverName,
                        v.Model as VehicleModel,
                        s.Shipment_code as ShipmentCode,
                        t.Status,
                        t.Shipment_id,
                        t.Route_id,
                        t.Start_time
                    FROM Trips t
                    JOIN Drivers d ON t.Driver_id = d.Driver_id
                    JOIN Vehicles v ON t.Vehicle_id = v.Vehicle_id
                    JOIN Shipments s ON t.Shipment_id = s.Shipment_id
                    WHERE t.Status != 'Paused' OR t.Status IS NULL
                    ORDER BY t.Trip_id DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvActiveTrips.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    lblTitle.Text = "NO ACTIVE TRIPS FOUND - CREATE ONE IN 'TRIPS' FIRST";
                    lblTitle.BackColor = Color.Orange;
                }
                else
                {
                    lblTitle.Text = "EMERGENCY SHIPMENT REASSIGNMENT";
                    lblTitle.BackColor = Color.FromArgb(255, 82, 82);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading active trips: " + ex.Message);
        }
    }

    private void BtnSearchDrivers_Click(object? sender, EventArgs e)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                // More relaxed search: Look for 'Available' but also 'Active' drivers if no one is 'Available'
                string query = @"
                    SELECT TOP 10
                        d.Driver_id,
                        d.Name as DriverName,
                        v.Vehicle_id,
                        v.Model as VehicleModel,
                        v.Plate_number,
                        d.Status as DriverStatus
                    FROM Drivers d
                    CROSS JOIN Vehicles v
                    WHERE d.Status != 'Inactive' 
                      AND v.Status != 'Inactive'
                      AND NOT EXISTS (
                        SELECT 1 FROM Trips t 
                        WHERE (t.Driver_id = d.Driver_id OR t.Vehicle_id = v.Vehicle_id)
                        AND (t.Status = 'Active' OR t.Status IS NULL)
                      )
                    ORDER BY CASE WHEN d.Status = 'Available' THEN 0 ELSE 1 END";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAvailableDrivers.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No suitable driver-vehicle pairs found. Ensure some Drivers/Vehicles have 'Available' status and are not on active trips.", "Allocation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error searching available pairs: " + ex.Message);
        }
    }

    private void BtnReassign_Click(object? sender, EventArgs e)
    {
        if (dgvActiveTrips.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select the trip that has failed.");
            return;
        }

        if (dgvAvailableDrivers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a replacement driver and vehicle.");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtReason.Text))
        {
            MessageBox.Show("Please provide a reason for the emergency reassignment.");
            return;
        }

        int oldTripId = Convert.ToInt32(dgvActiveTrips.SelectedRows[0].Cells["Trip_id"].Value);
        int shipmentId = Convert.ToInt32(dgvActiveTrips.SelectedRows[0].Cells["Shipment_id"].Value);
        int routeId = Convert.ToInt32(dgvActiveTrips.SelectedRows[0].Cells["Route_id"].Value);
        
        int newDriverId = Convert.ToInt32(dgvAvailableDrivers.SelectedRows[0].Cells["Driver_id"].Value);
        int newVehicleId = Convert.ToInt32(dgvAvailableDrivers.SelectedRows[0].Cells["Vehicle_id"].Value);

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Mark previous trip as PAUSED
                    string updateOldTrip = "UPDATE Trips SET Status = 'Paused', End_time = GETDATE() WHERE Trip_id = @OldId";
                    using (SqlCommand cmd = new SqlCommand(updateOldTrip, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OldId", oldTripId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Create New Trip for the same shipment
                    string insertNewTrip = @"
                        INSERT INTO Trips (Driver_id, Vehicle_id, Shipment_id, Route_id, Start_time, Status) 
                        VALUES (@DriverId, @VehicleId, @ShipmentId, @RouteId, GETDATE(), 'Active');
                        SELECT CAST(scope_identity() AS int);";
                    
                    int newTripId;
                    using (SqlCommand cmd = new SqlCommand(insertNewTrip, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@DriverId", newDriverId);
                        cmd.Parameters.AddWithValue("@VehicleId", newVehicleId);
                        cmd.Parameters.AddWithValue("@ShipmentId", shipmentId);
                        cmd.Parameters.AddWithValue("@RouteId", routeId);
                        newTripId = (int)cmd.ExecuteScalar();
                    }

                    // 3. Log the Emergency Reason
                    string logReason = "INSERT INTO EmergencyLogs (Old_Trip_id, Reason, New_Trip_id) VALUES (@OldId, @Reason, @NewTripId)";
                    using (SqlCommand cmd = new SqlCommand(logReason, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OldId", oldTripId);
                        cmd.Parameters.AddWithValue("@Reason", "EMERGENCY: " + txtReason.Text);
                        cmd.Parameters.AddWithValue("@NewTripId", newTripId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("CRITICAL ACTION SUCCESSFUL:\n\n1. Previous Trip MARKED AS PAUSED.\n2. Shipment REASSIGNED to New Driver.\n3. Search optimized for Allocation Logic.", "System intelligence Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadActiveTrips();
                    dgvAvailableDrivers.DataSource = null;
                    txtReason.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Operation Failed: " + ex.Message);
        }
    }
}

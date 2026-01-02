using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class TripForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public TripForm()
    {
        InitializeComponent();
        this.Load += TripForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvTrips.CellClick += DgvTrips_CellClick;
    }

    private void TripForm_Load(object? sender, EventArgs e)
    {
        LoadComboBoxes();
        LoadData();
    }

    private void LoadComboBoxes()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                // Drivers
                SqlDataAdapter daDriver = new SqlDataAdapter("SELECT Driver_id, Name FROM Drivers", conn);
                DataTable dtDriver = new DataTable();
                daDriver.Fill(dtDriver);
                cmbDriver.DataSource = dtDriver;
                cmbDriver.DisplayMember = "Name";
                cmbDriver.ValueMember = "Driver_id";
                cmbDriver.SelectedIndex = -1;

                // Vehicles
                SqlDataAdapter daVehicle = new SqlDataAdapter("SELECT Vehicle_id, Model FROM Vehicles", conn);
                DataTable dtVehicle = new DataTable();
                daVehicle.Fill(dtVehicle);
                cmbVehicle.DataSource = dtVehicle;
                cmbVehicle.DisplayMember = "Model";
                cmbVehicle.ValueMember = "Vehicle_id";
                cmbVehicle.SelectedIndex = -1;

                // Shipments
                SqlDataAdapter daShipment = new SqlDataAdapter("SELECT Shipment_id, Shipment_code FROM Shipments", conn);
                DataTable dtShipment = new DataTable();
                daShipment.Fill(dtShipment);
                cmbShipment.DataSource = dtShipment;
                cmbShipment.DisplayMember = "Shipment_code";
                cmbShipment.ValueMember = "Shipment_id";
                cmbShipment.SelectedIndex = -1;

                // Routes
                SqlDataAdapter daRoute = new SqlDataAdapter("SELECT Route_id, Start_location + ' to ' + End_location AS RouteName FROM Routes", conn);
                DataTable dtRoute = new DataTable();
                daRoute.Fill(dtRoute);
                cmbRoute.DataSource = dtRoute;
                cmbRoute.DisplayMember = "RouteName";
                cmbRoute.ValueMember = "Route_id";
                cmbRoute.SelectedIndex = -1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading combos: " + ex.Message);
        }
    }

    private void LoadData()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        t.Trip_id, 
                        t.Driver_id, d.Name as DriverName,
                        t.Vehicle_id, v.Model as VehicleModel,
                        t.Shipment_id, s.Shipment_code as ShipmentCode,
                        t.Route_id, r.Start_location + ' - ' + r.End_location as RouteDesc,
                        t.Start_time, 
                        t.End_time 
                    FROM Trips t
                    LEFT JOIN Drivers d ON t.Driver_id = d.Driver_id
                    LEFT JOIN Vehicles v ON t.Vehicle_id = v.Vehicle_id
                    LEFT JOIN Shipments s ON t.Shipment_id = s.Shipment_id
                    LEFT JOIN Routes r ON t.Route_id = r.Route_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTrips.DataSource = dt;

                // Hide ID columns if desired, but keep them for selection
                if (dgvTrips.Columns["Driver_id"] != null) dgvTrips.Columns["Driver_id"].Visible = false;
                if (dgvTrips.Columns["Vehicle_id"] != null) dgvTrips.Columns["Vehicle_id"].Visible = false;
                if (dgvTrips.Columns["Shipment_id"] != null) dgvTrips.Columns["Shipment_id"].Visible = false;
                if (dgvTrips.Columns["Route_id"] != null) dgvTrips.Columns["Route_id"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (cmbDriver.SelectedIndex == -1 || cmbVehicle.SelectedIndex == -1 ||
            cmbShipment.SelectedIndex == -1 || cmbRoute.SelectedIndex == -1)
        {
            MessageBox.Show("All fields must be selected.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Trips (Driver_id, Vehicle_id, Shipment_id, Route_id, Start_time, End_time) VALUES (@Driver, @Vehicle, @Shipment, @Route, @Start, @End)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Driver", cmbDriver.SelectedValue);
                    cmd.Parameters.AddWithValue("@Vehicle", cmbVehicle.SelectedValue);
                    cmd.Parameters.AddWithValue("@Shipment", cmbShipment.SelectedValue);
                    cmd.Parameters.AddWithValue("@Route", cmbRoute.SelectedValue);
                    cmd.Parameters.AddWithValue("@Start", dtpStartTime.Value);
                    cmd.Parameters.AddWithValue("@End", dtpEndTime.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Trip added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding trip: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTripId.Text))
        {
            MessageBox.Show("Please select a trip to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Trips SET Driver_id=@Driver, Vehicle_id=@Vehicle, Shipment_id=@Shipment, Route_id=@Route, Start_time=@Start, End_time=@End WHERE Trip_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Driver", cmbDriver.SelectedValue);
                    cmd.Parameters.AddWithValue("@Vehicle", cmbVehicle.SelectedValue);
                    cmd.Parameters.AddWithValue("@Shipment", cmbShipment.SelectedValue);
                    cmd.Parameters.AddWithValue("@Route", cmbRoute.SelectedValue);
                    cmd.Parameters.AddWithValue("@Start", dtpStartTime.Value);
                    cmd.Parameters.AddWithValue("@End", dtpEndTime.Value);
                    cmd.Parameters.AddWithValue("@Id", txtTripId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Trip updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating trip: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTripId.Text))
        {
            MessageBox.Show("Please select a trip to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Trips WHERE Trip_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtTripId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Trip deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this trip because it is referenced by other system records (e.g., active shipment logs).", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting trip: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        txtTripId.Text = "";
        cmbDriver.SelectedIndex = -1;
        cmbVehicle.SelectedIndex = -1;
        cmbShipment.SelectedIndex = -1;
        cmbRoute.SelectedIndex = -1;
        dtpStartTime.Value = DateTime.Now;
        dtpEndTime.Value = DateTime.Now;
    }

    private void DgvTrips_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvTrips.Rows[e.RowIndex];
            txtTripId.Text = row.Cells["Trip_id"].Value.ToString();

            // Safe casting for combos
            if (row.Cells["Driver_id"].Value != DBNull.Value)
                cmbDriver.SelectedValue = row.Cells["Driver_id"].Value;

            if (row.Cells["Vehicle_id"].Value != DBNull.Value)
                cmbVehicle.SelectedValue = row.Cells["Vehicle_id"].Value;

            if (row.Cells["Shipment_id"].Value != DBNull.Value)
                cmbShipment.SelectedValue = row.Cells["Shipment_id"].Value;

            if (row.Cells["Route_id"].Value != DBNull.Value)
                cmbRoute.SelectedValue = row.Cells["Route_id"].Value;

            if (row.Cells["Start_time"].Value != DBNull.Value)
                dtpStartTime.Value = Convert.ToDateTime(row.Cells["Start_time"].Value);

            if (row.Cells["End_time"].Value != DBNull.Value)
                dtpEndTime.Value = Convert.ToDateTime(row.Cells["End_time"].Value);
        }
    }

    private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

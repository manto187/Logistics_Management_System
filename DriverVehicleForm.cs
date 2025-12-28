using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class DriverVehicleForm : Form
{
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public DriverVehicleForm()
    {
        InitializeComponent();
        this.Load += DriverVehicleForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvAssignments.CellClick += DgvAssignments_CellClick;
    }

    private void DriverVehicleForm_Load(object? sender, EventArgs e)
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

                // Load Drivers
                SqlDataAdapter daDriver = new SqlDataAdapter("SELECT Driver_id, Name FROM Drivers", conn);
                DataTable dtDriver = new DataTable();
                daDriver.Fill(dtDriver);
                cmbDriver.DataSource = dtDriver;
                cmbDriver.DisplayMember = "Name";
                cmbDriver.ValueMember = "Driver_id";
                cmbDriver.SelectedIndex = -1;

                // Load Vehicles
                SqlDataAdapter daVehicle = new SqlDataAdapter("SELECT Vehicle_id, Model FROM Vehicles", conn);
                DataTable dtVehicle = new DataTable();
                daVehicle.Fill(dtVehicle);
                cmbVehicle.DataSource = dtVehicle;
                cmbVehicle.DisplayMember = "Model";
                cmbVehicle.ValueMember = "Vehicle_id";
                cmbVehicle.SelectedIndex = -1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading dropdown data: " + ex.Message);
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
                    SELECT dv.Assignment_id, dv.Driver_id, d.Name AS DriverName, 
                           dv.Vehicle_id, v.Model AS VehicleModel, 
                           dv.Assignment_date, dv.Unassignment_date
                    FROM DriverVehicleAssignments dv
                    JOIN Drivers d ON dv.Driver_id = d.Driver_id
                    JOIN Vehicles v ON dv.Vehicle_id = v.Vehicle_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAssignments.DataSource = dt;

                if (dgvAssignments.Columns["Driver_id"] != null) dgvAssignments.Columns["Driver_id"].Visible = false;
                if (dgvAssignments.Columns["Vehicle_id"] != null) dgvAssignments.Columns["Vehicle_id"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (cmbDriver.SelectedIndex == -1 || cmbVehicle.SelectedIndex == -1)
        {
            MessageBox.Show("Please select both a driver and a vehicle.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO DriverVehicleAssignments (Driver_id, Vehicle_id, Assignment_date, Unassignment_date) VALUES (@DriverId, @VehicleId, @AssignmentDate, @UnassignmentDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverId", cmbDriver.SelectedValue);
                cmd.Parameters.AddWithValue("@VehicleId", cmbVehicle.SelectedValue);
                cmd.Parameters.AddWithValue("@AssignmentDate", dtpAssignmentDate.Value);
                cmd.Parameters.AddWithValue("@UnassignmentDate", dtpUnassignmentDate.Checked ? (object)dtpUnassignmentDate.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Assignment added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding assignment: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtAssignmentId.Text))
        {
            MessageBox.Show("Please select an assignment to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE DriverVehicleAssignments SET Driver_id = @DriverId, Vehicle_id = @VehicleId, Assignment_date = @AssignmentDate, Unassignment_date = @UnassignmentDate WHERE Assignment_id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtAssignmentId.Text);
                cmd.Parameters.AddWithValue("@DriverId", cmbDriver.SelectedValue);
                cmd.Parameters.AddWithValue("@VehicleId", cmbVehicle.SelectedValue);
                cmd.Parameters.AddWithValue("@AssignmentDate", dtpAssignmentDate.Value);
                cmd.Parameters.AddWithValue("@UnassignmentDate", dtpUnassignmentDate.Checked ? (object)dtpUnassignmentDate.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Assignment updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating assignment: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtAssignmentId.Text))
        {
            MessageBox.Show("Please select an assignment to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DriverVehicleAssignments WHERE Assignment_id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", txtAssignmentId.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Assignment deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this assignment because it is referenced by historical trip or shipment data.", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting assignment: " + ex.Message);
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
        txtAssignmentId.Text = string.Empty;
        cmbDriver.SelectedIndex = -1;
        cmbVehicle.SelectedIndex = -1;
        dtpAssignmentDate.Value = DateTime.Now;
        dtpUnassignmentDate.Value = DateTime.Now;
        dtpUnassignmentDate.Checked = false;
    }

    private void DgvAssignments_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvAssignments.Rows[e.RowIndex];
            txtAssignmentId.Text = row.Cells["Assignment_id"].Value.ToString();
            cmbDriver.SelectedValue = row.Cells["Driver_id"].Value;
            cmbVehicle.SelectedValue = row.Cells["Vehicle_id"].Value;
            dtpAssignmentDate.Value = Convert.ToDateTime(row.Cells["Assignment_date"].Value);

            if (row.Cells["Unassignment_date"].Value != DBNull.Value)
            {
                dtpUnassignmentDate.Value = Convert.ToDateTime(row.Cells["Unassignment_date"].Value);
                dtpUnassignmentDate.Checked = true;
            }
            else
            {
                dtpUnassignmentDate.Checked = false;
            }
        }
    }

    private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

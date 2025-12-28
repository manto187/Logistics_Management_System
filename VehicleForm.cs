namespace LogisticManagementSystem;

public partial class VehicleForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public VehicleForm()
    {
        InitializeComponent();
        this.Load += VehicleForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvVehicles.CellClick += DgvVehicles_CellClick;
    }

    private void VehicleForm_Load(object? sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT Vehicle_id, Model, Plate_number, Vehicle_type, Mileage, Status, Created_at FROM Vehicles WHERE Status != 'Inactive' OR Status IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVehicles.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text))
        {
            MessageBox.Show("Model and Plate Number are required.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Vehicles (Model, Plate_number, Vehicle_type, Mileage, Status, Created_at) VALUES (@Model, @Plate, @Type, @Mileage, @Status, @CreatedAt)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Plate", txtPlateNumber.Text);
                    cmd.Parameters.AddWithValue("@Type", cmbVehicleType.Text);
                    cmd.Parameters.AddWithValue("@Mileage", numMileage.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Vehicle added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding vehicle: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtVehicleId.Text))
        {
            MessageBox.Show("Please select a vehicle to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Vehicles SET Model=@Model, Plate_number=@Plate, Vehicle_type=@Type, Mileage=@Mileage, Status=@Status, Created_at=@CreatedAt WHERE Vehicle_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Plate", txtPlateNumber.Text);
                    cmd.Parameters.AddWithValue("@Type", cmbVehicleType.Text);
                    cmd.Parameters.AddWithValue("@Mileage", numMileage.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.Parameters.AddWithValue("@Id", txtVehicleId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Vehicle updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating vehicle: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtVehicleId.Text))
        {
            MessageBox.Show("Please select a vehicle to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Vehicles WHERE Vehicle_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtVehicleId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vehicle marked as inactive successfully.");

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vehicle: " + ex.Message);
            }
        }
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        txtVehicleId.Text = "";
        txtModel.Text = "";
        txtPlateNumber.Text = "";
        cmbVehicleType.SelectedIndex = -1;
        numMileage.Value = 0;
        cmbStatus.SelectedIndex = -1;
        dtpCreatedAt.Value = DateTime.Now;
    }

    private void DgvVehicles_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];
            txtVehicleId.Text = row.Cells["Vehicle_id"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtPlateNumber.Text = row.Cells["Plate_number"].Value.ToString();
            cmbVehicleType.Text = row.Cells["Vehicle_type"].Value.ToString();
            
            if (decimal.TryParse(row.Cells["Mileage"].Value.ToString(), out decimal mileage))
            {
                numMileage.Value = mileage;
            }
            
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
            if (row.Cells["Created_at"].Value != DBNull.Value)
            {
                dtpCreatedAt.Value = Convert.ToDateTime(row.Cells["Created_at"].Value);
            }
        }
    }
}

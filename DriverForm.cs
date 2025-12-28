namespace LogisticManagementSystem;

public partial class DriverForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public DriverForm()
    {
        InitializeComponent();
        this.Load += DriverForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvDrivers.CellClick += DgvDrivers_CellClick;
    }

    private void DriverForm_Load(object? sender, EventArgs e)
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
                string query = "SELECT Driver_id, Name, Phone_number, License_number, Status, Created_at FROM Drivers WHERE Status != 'Inactive' OR Status IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDrivers.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
        {
            MessageBox.Show("Name and Phone Number are required.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Drivers (Name, Phone_number, License_number, Status, Created_at) VALUES (@Name, @Phone, @License, @Status, @CreatedAt)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Driver added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding driver: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDriverId.Text))
        {
            MessageBox.Show("Please select a driver to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Drivers SET Name=@Name, Phone_number=@Phone, License_number=@License, Status=@Status, Created_at=@CreatedAt WHERE driver_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.Parameters.AddWithValue("@Id", txtDriverId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Driver updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating driver: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDriverId.Text))
        {
            MessageBox.Show("Please select a driver to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Drivers WHERE Driver_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtDriverId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Driver deleted successfully.");

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting driver: " + ex.Message);
            }
        }
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        txtDriverId.Text = "";
        txtName.Text = "";
        txtPhoneNumber.Text = "";
        txtLicenseNumber.Text = "";
        cmbStatus.SelectedIndex = -1;
        dtpCreatedAt.Value = DateTime.Now;
    }

    private void DgvDrivers_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvDrivers.Rows[e.RowIndex];
            txtDriverId.Text = row.Cells["Driver_id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["Phone_number"].Value.ToString();
            txtLicenseNumber.Text = row.Cells["License_number"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
            if (row.Cells["Created_at"].Value != DBNull.Value)
            {
                dtpCreatedAt.Value = Convert.ToDateTime(row.Cells["Created_at"].Value);
            }
        }
    }

    private void grpDriverDetails_Enter(object sender, EventArgs e)
    {

    }
}

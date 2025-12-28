using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class WarehouseForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public WarehouseForm()
    {
        InitializeComponent();
        this.Load += WarehouseForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvWarehouses.CellClick += DgvWarehouses_CellClick;
    }

    private void WarehouseForm_Load(object? sender, EventArgs e)
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
                string query = "SELECT Warehouse_id, Warehouse_name, Location FROM Warehouses";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvWarehouses.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtWarehouseName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
        {
            MessageBox.Show("Warehouse name and Location are required.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Warehouses (Warehouse_name, Location) VALUES (@Name, @Location)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtWarehouseName.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Warehouse added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding warehouse: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtWarehouseId.Text))
        {
            MessageBox.Show("Please select a warehouse to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Warehouses SET Warehouse_name=@Name, Location=@Location WHERE Warehouse_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtWarehouseName.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@Id", txtWarehouseId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Warehouse updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating warehouse: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtWarehouseId.Text))
        {
            MessageBox.Show("Please select a warehouse to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this warehouse?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Warehouses WHERE Warehouse_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtWarehouseId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Warehouse deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this warehouse because it has active inventory or shipments associated with it. Please empty the warehouse or reassignment the records first.", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting warehouse: " + ex.Message);
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
        txtWarehouseId.Text = "";
        txtWarehouseName.Text = "";
        txtLocation.Text = "";
    }

    private void DgvWarehouses_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvWarehouses.Rows[e.RowIndex];
            txtWarehouseId.Text = row.Cells["Warehouse_id"].Value.ToString();
            txtWarehouseName.Text = row.Cells["Warehouse_name"].Value.ToString();
            txtLocation.Text = row.Cells["Location"].Value.ToString();
        }
    }
}

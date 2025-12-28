using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class ShipmentForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public ShipmentForm()
    {
        InitializeComponent();
        this.Load += ShipmentForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvShipments.CellClick += DgvShipments_CellClick;
    }

    private void ShipmentForm_Load(object? sender, EventArgs e)
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
                string query = "SELECT Shipment_id, Shipment_code, Weight, Pickup_location, Dropoff_location, Status, Created_at FROM Shipments WHERE Status != 'Cancelled' OR Status IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShipments.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtShipmentCode.Text) || string.IsNullOrWhiteSpace(txtPickupLocation.Text) || string.IsNullOrWhiteSpace(txtDropoffLocation.Text))
        {
            MessageBox.Show("Code, Pickup, and Dropoff locations are required.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Shipments (Shipment_code, Weight, Pickup_location, Dropoff_location, Status, Created_at) VALUES (@Code, @Weight, @Pickup, @Dropoff, @Status, @CreatedAt)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", txtShipmentCode.Text);
                    cmd.Parameters.AddWithValue("@Weight", numWeight.Value);
                    cmd.Parameters.AddWithValue("@Pickup", txtPickupLocation.Text);
                    cmd.Parameters.AddWithValue("@Dropoff", txtDropoffLocation.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Shipment added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding shipment: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtShipmentId.Text))
        {
            MessageBox.Show("Please select a shipment to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Shipments SET Shipment_code=@Code, Weight=@Weight, Pickup_location=@Pickup, Dropoff_location=@Dropoff, Status=@Status, Created_at=@CreatedAt WHERE Shipment_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", txtShipmentCode.Text);
                    cmd.Parameters.AddWithValue("@Weight", numWeight.Value);
                    cmd.Parameters.AddWithValue("@Pickup", txtPickupLocation.Text);
                    cmd.Parameters.AddWithValue("@Dropoff", txtDropoffLocation.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@CreatedAt", dtpCreatedAt.Value);
                    cmd.Parameters.AddWithValue("@Id", txtShipmentId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Shipment updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating shipment: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtShipmentId.Text))
        {
            MessageBox.Show("Please select a shipment to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this shipment?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Shipments WHERE Shipment_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtShipmentId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Shipment marked as cancelled successfully.");

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting shipment: " + ex.Message);
            }
        }
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        txtShipmentId.Text = "";
        txtShipmentCode.Text = "";
        numWeight.Value = 0;
        txtPickupLocation.Text = "";
        txtDropoffLocation.Text = "";
        cmbStatus.SelectedIndex = -1;
        dtpCreatedAt.Value = DateTime.Now;
    }

    private void DgvShipments_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvShipments.Rows[e.RowIndex];
            txtShipmentId.Text = row.Cells["Shipment_id"].Value.ToString();
            txtShipmentCode.Text = row.Cells["Shipment_code"].Value.ToString();
            
            if (decimal.TryParse(row.Cells["Weight"].Value.ToString(), out decimal weight))
            {
                numWeight.Value = weight;
            }
            
            txtPickupLocation.Text = row.Cells["Pickup_location"].Value.ToString();
            txtDropoffLocation.Text = row.Cells["Dropoff_location"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
            
            if (row.Cells["Created_at"].Value != DBNull.Value)
            {
                dtpCreatedAt.Value = Convert.ToDateTime(row.Cells["Created_at"].Value);
            }
        }
    }
}

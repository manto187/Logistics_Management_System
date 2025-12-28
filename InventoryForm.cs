using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class InventoryForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public InventoryForm()
    {
        InitializeComponent();
        this.Load += InventoryForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvInventory.CellClick += DgvInventory_CellClick;
    }

    private void InventoryForm_Load(object? sender, EventArgs e)
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

                // Warehouses
                SqlDataAdapter daWarehouse = new SqlDataAdapter("SELECT Warehouse_id, Warehouse_name FROM Warehouses", conn);
                DataTable dtWarehouse = new DataTable();
                daWarehouse.Fill(dtWarehouse);
                cmbWarehouse.DataSource = dtWarehouse;
                cmbWarehouse.DisplayMember = "Warehouse_name";
                cmbWarehouse.ValueMember = "Warehouse_id";
                cmbWarehouse.SelectedIndex = -1;
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
                        i.Inventory_id, 
                        i.Warehouse_id, w.Warehouse_name as WarehouseName,
                        i.Item_name,
                        i.Quantity
                    FROM Inventory i
                    LEFT JOIN Warehouses w ON i.Warehouse_id = w.Warehouse_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventory.DataSource = dt;
                
                // Hide ID columns
                if(dgvInventory.Columns["Warehouse_id"] != null) dgvInventory.Columns["Warehouse_id"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (cmbWarehouse.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtItemName.Text))
        {
            MessageBox.Show("Warehouse and Item Name must be provided.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Inventory (Warehouse_id, Item_name, Quantity) VALUES (@Warehouse, @ItemName, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Warehouse", cmbWarehouse.SelectedValue);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Inventory Item added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding inventory: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtInventoryId.Text))
        {
            MessageBox.Show("Please select an item to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Inventory SET Warehouse_id=@Warehouse, Item_name=@ItemName, Quantity=@Quantity WHERE Inventory_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Warehouse", cmbWarehouse.SelectedValue);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value);
                    cmd.Parameters.AddWithValue("@Id", txtInventoryId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Inventory Item updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating inventory: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtInventoryId.Text))
        {
            MessageBox.Show("Please select an item to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Inventory WHERE Inventory_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtInventoryId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Inventory Item deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this inventory item because it is referenced in active shipment items or other records.", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting inventory: " + ex.Message);
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
        txtInventoryId.Text = "";
        cmbWarehouse.SelectedIndex = -1;
        txtItemName.Text = "";
        numQuantity.Value = 0;
    }

    private void DgvInventory_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
            txtInventoryId.Text = row.Cells["Inventory_id"].Value.ToString();
            
            if (row.Cells["Warehouse_id"].Value != DBNull.Value)
                cmbWarehouse.SelectedValue = row.Cells["Warehouse_id"].Value;
            
            txtItemName.Text = row.Cells["Item_name"].Value.ToString();
            
            if (decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out decimal quantity))
            {
                numQuantity.Value = quantity;
            }
        }
    }
}

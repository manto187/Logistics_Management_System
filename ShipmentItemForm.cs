using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class ShipmentItemForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public ShipmentItemForm()
    {
        InitializeComponent();
        this.Load += ShipmentItemForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvShipmentItems.CellClick += DgvShipmentItems_CellClick;
    }

    private void ShipmentItemForm_Load(object? sender, EventArgs e)
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

                // Shipments
                SqlDataAdapter daShipment = new SqlDataAdapter("SELECT Shipment_id, Shipment_code FROM Shipments", conn);
                DataTable dtShipment = new DataTable();
                daShipment.Fill(dtShipment);
                cmbShipment.DataSource = dtShipment;
                cmbShipment.DisplayMember = "Shipment_code";
                cmbShipment.ValueMember = "Shipment_id";
                cmbShipment.SelectedIndex = -1;

                // Inventory
                // NOTE: Assuming there is an Inventory table with Inventory_id and Item_name
                SqlDataAdapter daInventory = new SqlDataAdapter("SELECT Inventory_id, Item_name FROM Inventory", conn);
                DataTable dtInventory = new DataTable();
                daInventory.Fill(dtInventory);
                cmbInventory.DataSource = dtInventory;
                cmbInventory.DisplayMember = "Item_name";
                cmbInventory.ValueMember = "Inventory_id";
                cmbInventory.SelectedIndex = -1;
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
                        si.Ship_Item_Id, 
                        si.Shipment_id, s.Shipment_code as ShipmentCode,
                        si.Inventory_id, i.Item_name as ItemName,
                        si.Item_Quantity
                    FROM ShipmentItems si
                    LEFT JOIN Shipments s ON si.Shipment_id = s.Shipment_id
                    LEFT JOIN Inventory i ON si.Inventory_id = i.Inventory_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShipmentItems.DataSource = dt;
                
                // Hide ID columns
                if(dgvShipmentItems.Columns["Shipment_id"] != null) dgvShipmentItems.Columns["Shipment_id"].Visible = false;
                if(dgvShipmentItems.Columns["Inventory_id"] != null) dgvShipmentItems.Columns["Inventory_id"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (cmbShipment.SelectedIndex == -1 || cmbInventory.SelectedIndex == -1)
        {
            MessageBox.Show("Shipment and Inventory Item must be selected.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO ShipmentItems (Shipment_id, Inventory_id, Item_Quantity) VALUES (@Shipment, @Inventory, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Shipment", cmbShipment.SelectedValue);
                    cmd.Parameters.AddWithValue("@Inventory", cmbInventory.SelectedValue);
                    cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Shipment Item added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding items: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtShipItemId.Text))
        {
            MessageBox.Show("Please select an item to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE ShipmentItems SET Shipment_id=@Shipment, Inventory_id=@Inventory, Item_Quantity=@Quantity WHERE Ship_Item_Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Shipment", cmbShipment.SelectedValue);
                    cmd.Parameters.AddWithValue("@Inventory", cmbInventory.SelectedValue);
                    cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value);
                    cmd.Parameters.AddWithValue("@Id", txtShipItemId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Shipment Item updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating item: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtShipItemId.Text))
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
                    string query = "DELETE FROM ShipmentItems WHERE Ship_Item_Id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtShipItemId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Shipment Item deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this item because it is linked to other transaction records.", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting item: " + ex.Message);
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
        txtShipItemId.Text = "";
        cmbShipment.SelectedIndex = -1;
        cmbInventory.SelectedIndex = -1;
        numQuantity.Value = 0;
    }

    private void DgvShipmentItems_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvShipmentItems.Rows[e.RowIndex];
            txtShipItemId.Text = row.Cells["Ship_Item_Id"].Value.ToString();
            
            if (row.Cells["Shipment_id"].Value != DBNull.Value)
                cmbShipment.SelectedValue = row.Cells["Shipment_id"].Value;
            
            if (row.Cells["Inventory_id"].Value != DBNull.Value)
                cmbInventory.SelectedValue = row.Cells["Inventory_id"].Value;
            
            if (decimal.TryParse(row.Cells["Item_Quantity"].Value.ToString(), out decimal quantity))
            {
                numQuantity.Value = quantity;
            }
        }
    }
}

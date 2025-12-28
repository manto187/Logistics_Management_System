using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class RouteForm : Form
{
    // Replace with your actual connection string
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public RouteForm()
    {
        InitializeComponent();
        this.Load += RouteForm_Load;
        this.btnAdd.Click += BtnAdd_Click;
        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnDelete.Click += BtnDelete_Click;
        this.btnClear.Click += BtnClear_Click;
        this.dgvRoutes.CellClick += DgvRoutes_CellClick;
    }

    private void RouteForm_Load(object? sender, EventArgs e)
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
                string query = "SELECT Route_id, Start_location, End_location, Distance_km FROM Routes";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRoutes.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtStartLocation.Text) || string.IsNullOrWhiteSpace(txtEndLocation.Text))
        {
            MessageBox.Show("Start and End locations are required.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Routes (Start_location, End_location, Distance_km) VALUES (@Start, @End, @Distance)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Start", txtStartLocation.Text);
                    cmd.Parameters.AddWithValue("@End", txtEndLocation.Text);
                    cmd.Parameters.AddWithValue("@Distance", numDistance.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Route added successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding route: " + ex.Message);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRouteId.Text))
        {
            MessageBox.Show("Please select a route to update.");
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Routes SET Start_location=@Start, End_location=@End, Distance_km=@Distance WHERE Route_id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Start", txtStartLocation.Text);
                    cmd.Parameters.AddWithValue("@End", txtEndLocation.Text);
                    cmd.Parameters.AddWithValue("@Distance", numDistance.Value);
                    cmd.Parameters.AddWithValue("@Id", txtRouteId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Route updated successfully.");
            LoadData();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating route: " + ex.Message);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRouteId.Text))
        {
            MessageBox.Show("Please select a route to delete.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Routes WHERE Route_id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtRouteId.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Route deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete this route because it is linked to active trips or shipments. Please remove the dependent records first.", "Data Integrity Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error deleting route: " + ex.Message);
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
        txtRouteId.Text = "";
        txtStartLocation.Text = "";
        txtEndLocation.Text = "";
        numDistance.Value = 0;
    }

    private void DgvRoutes_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvRoutes.Rows[e.RowIndex];
            txtRouteId.Text = row.Cells["Route_id"].Value.ToString();
            txtStartLocation.Text = row.Cells["Start_location"].Value.ToString();
            txtEndLocation.Text = row.Cells["End_location"].Value.ToString();
            
            if (decimal.TryParse(row.Cells["Distance_km"].Value.ToString(), out decimal distance))
            {
                numDistance.Value = distance;
            }
        }
    }
}

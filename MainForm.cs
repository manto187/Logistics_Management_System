namespace LogisticManagementSystem;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void OpenChildForm(Form childForm, string title)
    {
        // Check if tab already exists
        foreach (TabPage tab in tabControlMain.TabPages)
        {
            if (tab.Text == title)
            {
                tabControlMain.SelectedTab = tab;
                return;
            }
        }

        // Create new tab if not exists
        TabPage newTab = new TabPage(title);
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        
        newTab.Controls.Add(childForm);
        tabControlMain.TabPages.Add(newTab);
        tabControlMain.SelectedTab = newTab;
        
        childForm.Show();
    }

    private void btnManageDrivers_Click(object sender, EventArgs e)
    {
        OpenChildForm(new DriverForm(), "Drivers");
    }

    private void btnManageVehicles_Click(object sender, EventArgs e)
    {
        OpenChildForm(new VehicleForm(), "Vehicles");
    }

    private void btnManageRoutes_Click(object sender, EventArgs e)
    {
        OpenChildForm(new RouteForm(), "Routes");
    }

    private void btnManageShipments_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ShipmentForm(), "Shipments");
    }

    private void btnManageWarehouses_Click(object sender, EventArgs e)
    {
        OpenChildForm(new WarehouseForm(), "Warehouses");
    }

    private void btnManageTrips_Click(object sender, EventArgs e)
    {
        OpenChildForm(new TripForm(), "Trips");
    }

    private void btnManageShipmentItems_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ShipmentItemForm(), "Items");
    }

    private void btnManageInventory_Click(object sender, EventArgs e)
    {
        OpenChildForm(new InventoryForm(), "Inventory");
    }

    private void btnManageDriverVehicle_Click(object sender, EventArgs e)
    {
        OpenChildForm(new DriverVehicleForm(), "Assignments");
    }
}


namespace LogisticManagementSystem;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlSidebar = new Panel();
        btnEmergencyAlert = new Button();
        btnManageDriverVehicle = new Button();
        btnManageInventory = new Button();
        btnManageShipmentItems = new Button();
        btnManageTrips = new Button();
        btnManageWarehouses = new Button();
        btnManageShipments = new Button();
        btnManageRoutes = new Button();
        btnManageVehicles = new Button();
        btnManageDrivers = new Button();
        pnlLogo = new Panel();
        lblTitle = new Label();
        tabControlMain = new TabControl();
        tabPageHome = new TabPage();
        pnlHomeHero = new Panel();
        lblHomeHeading = new Label();
        lblSubHeading = new Label();
        pnlSidebar.SuspendLayout();
        pnlLogo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(51, 51, 76);
        pnlSidebar.Controls.Add(btnEmergencyAlert);
        pnlSidebar.Controls.Add(btnManageDriverVehicle);
        pnlSidebar.Controls.Add(btnManageInventory);
        pnlSidebar.Controls.Add(btnManageShipmentItems);
        pnlSidebar.Controls.Add(btnManageTrips);
        pnlSidebar.Controls.Add(btnManageWarehouses);
        pnlSidebar.Controls.Add(btnManageShipments);
        pnlSidebar.Controls.Add(btnManageRoutes);
        pnlSidebar.Controls.Add(btnManageVehicles);
        pnlSidebar.Controls.Add(btnManageDrivers);
        pnlSidebar.Controls.Add(pnlLogo);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(220, 1000);
        pnlSidebar.TabIndex = 10;
        // 
        // btnEmergencyAlert
        // 
        btnEmergencyAlert.BackColor = Color.FromArgb(255, 82, 82);
        btnEmergencyAlert.Dock = DockStyle.Top;
        btnEmergencyAlert.FlatAppearance.BorderSize = 0;
        btnEmergencyAlert.FlatStyle = FlatStyle.Flat;
        btnEmergencyAlert.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEmergencyAlert.ForeColor = Color.White;
        btnEmergencyAlert.Location = new Point(0, 640);
        btnEmergencyAlert.Name = "btnEmergencyAlert";
        btnEmergencyAlert.Padding = new Padding(12, 0, 0, 0);
        btnEmergencyAlert.Size = new Size(220, 60);
        btnEmergencyAlert.TabIndex = 10;
        btnEmergencyAlert.Text = "   EMERGENCY!";
        btnEmergencyAlert.TextAlign = ContentAlignment.MiddleLeft;
        btnEmergencyAlert.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnEmergencyAlert.UseVisualStyleBackColor = false;
        btnEmergencyAlert.Click += btnEmergencyAlert_Click;
        // 
        // btnManageDriverVehicle
        // 
        btnManageDriverVehicle.Dock = DockStyle.Top;
        btnManageDriverVehicle.FlatAppearance.BorderSize = 0;
        btnManageDriverVehicle.FlatStyle = FlatStyle.Flat;
        btnManageDriverVehicle.Font = new Font("Segoe UI", 10F);
        btnManageDriverVehicle.ForeColor = Color.Gainsboro;
        btnManageDriverVehicle.Location = new Point(0, 580);
        btnManageDriverVehicle.Name = "btnManageDriverVehicle";
        btnManageDriverVehicle.Padding = new Padding(12, 0, 0, 0);
        btnManageDriverVehicle.Size = new Size(220, 60);
        btnManageDriverVehicle.TabIndex = 9;
        btnManageDriverVehicle.Text = "   Assignments";
        btnManageDriverVehicle.TextAlign = ContentAlignment.MiddleLeft;
        btnManageDriverVehicle.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageDriverVehicle.UseVisualStyleBackColor = true;
        btnManageDriverVehicle.Click += btnManageDriverVehicle_Click;
        // 
        // btnManageInventory
        // 
        btnManageInventory.Dock = DockStyle.Top;
        btnManageInventory.FlatAppearance.BorderSize = 0;
        btnManageInventory.FlatStyle = FlatStyle.Flat;
        btnManageInventory.Font = new Font("Segoe UI", 10F);
        btnManageInventory.ForeColor = Color.Gainsboro;
        btnManageInventory.Location = new Point(0, 520);
        btnManageInventory.Name = "btnManageInventory";
        btnManageInventory.Padding = new Padding(12, 0, 0, 0);
        btnManageInventory.Size = new Size(220, 60);
        btnManageInventory.TabIndex = 8;
        btnManageInventory.Text = "   Inventory";
        btnManageInventory.TextAlign = ContentAlignment.MiddleLeft;
        btnManageInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageInventory.UseVisualStyleBackColor = true;
        btnManageInventory.Click += btnManageInventory_Click;
        // 
        // btnManageShipmentItems
        // 
        btnManageShipmentItems.Dock = DockStyle.Top;
        btnManageShipmentItems.FlatAppearance.BorderSize = 0;
        btnManageShipmentItems.FlatStyle = FlatStyle.Flat;
        btnManageShipmentItems.Font = new Font("Segoe UI", 10F);
        btnManageShipmentItems.ForeColor = Color.Gainsboro;
        btnManageShipmentItems.Location = new Point(0, 460);
        btnManageShipmentItems.Name = "btnManageShipmentItems";
        btnManageShipmentItems.Padding = new Padding(12, 0, 0, 0);
        btnManageShipmentItems.Size = new Size(220, 60);
        btnManageShipmentItems.TabIndex = 7;
        btnManageShipmentItems.Text = "   Shipment Items";
        btnManageShipmentItems.TextAlign = ContentAlignment.MiddleLeft;
        btnManageShipmentItems.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageShipmentItems.UseVisualStyleBackColor = true;
        btnManageShipmentItems.Click += btnManageShipmentItems_Click;
        // 
        // btnManageTrips
        // 
        btnManageTrips.Dock = DockStyle.Top;
        btnManageTrips.FlatAppearance.BorderSize = 0;
        btnManageTrips.FlatStyle = FlatStyle.Flat;
        btnManageTrips.Font = new Font("Segoe UI", 10F);
        btnManageTrips.ForeColor = Color.Gainsboro;
        btnManageTrips.Location = new Point(0, 400);
        btnManageTrips.Name = "btnManageTrips";
        btnManageTrips.Padding = new Padding(12, 0, 0, 0);
        btnManageTrips.Size = new Size(220, 60);
        btnManageTrips.TabIndex = 6;
        btnManageTrips.Text = "   Trips";
        btnManageTrips.TextAlign = ContentAlignment.MiddleLeft;
        btnManageTrips.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageTrips.UseVisualStyleBackColor = true;
        btnManageTrips.Click += btnManageTrips_Click;
        // 
        // btnManageWarehouses
        // 
        btnManageWarehouses.Dock = DockStyle.Top;
        btnManageWarehouses.FlatAppearance.BorderSize = 0;
        btnManageWarehouses.FlatStyle = FlatStyle.Flat;
        btnManageWarehouses.Font = new Font("Segoe UI", 10F);
        btnManageWarehouses.ForeColor = Color.Gainsboro;
        btnManageWarehouses.Location = new Point(0, 340);
        btnManageWarehouses.Name = "btnManageWarehouses";
        btnManageWarehouses.Padding = new Padding(12, 0, 0, 0);
        btnManageWarehouses.Size = new Size(220, 60);
        btnManageWarehouses.TabIndex = 5;
        btnManageWarehouses.Text = "   Warehouses";
        btnManageWarehouses.TextAlign = ContentAlignment.MiddleLeft;
        btnManageWarehouses.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageWarehouses.UseVisualStyleBackColor = true;
        btnManageWarehouses.Click += btnManageWarehouses_Click;
        // 
        // btnManageShipments
        // 
        btnManageShipments.Dock = DockStyle.Top;
        btnManageShipments.FlatAppearance.BorderSize = 0;
        btnManageShipments.FlatStyle = FlatStyle.Flat;
        btnManageShipments.Font = new Font("Segoe UI", 10F);
        btnManageShipments.ForeColor = Color.Gainsboro;
        btnManageShipments.Location = new Point(0, 280);
        btnManageShipments.Name = "btnManageShipments";
        btnManageShipments.Padding = new Padding(12, 0, 0, 0);
        btnManageShipments.Size = new Size(220, 60);
        btnManageShipments.TabIndex = 4;
        btnManageShipments.Text = "   Shipments";
        btnManageShipments.TextAlign = ContentAlignment.MiddleLeft;
        btnManageShipments.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageShipments.UseVisualStyleBackColor = true;
        btnManageShipments.Click += btnManageShipments_Click;
        // 
        // btnManageRoutes
        // 
        btnManageRoutes.Dock = DockStyle.Top;
        btnManageRoutes.FlatAppearance.BorderSize = 0;
        btnManageRoutes.FlatStyle = FlatStyle.Flat;
        btnManageRoutes.Font = new Font("Segoe UI", 10F);
        btnManageRoutes.ForeColor = Color.Gainsboro;
        btnManageRoutes.Location = new Point(0, 220);
        btnManageRoutes.Name = "btnManageRoutes";
        btnManageRoutes.Padding = new Padding(12, 0, 0, 0);
        btnManageRoutes.Size = new Size(220, 60);
        btnManageRoutes.TabIndex = 3;
        btnManageRoutes.Text = "   Routes";
        btnManageRoutes.TextAlign = ContentAlignment.MiddleLeft;
        btnManageRoutes.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageRoutes.UseVisualStyleBackColor = true;
        btnManageRoutes.Click += btnManageRoutes_Click;
        // 
        // btnManageVehicles
        // 
        btnManageVehicles.Dock = DockStyle.Top;
        btnManageVehicles.FlatAppearance.BorderSize = 0;
        btnManageVehicles.FlatStyle = FlatStyle.Flat;
        btnManageVehicles.Font = new Font("Segoe UI", 10F);
        btnManageVehicles.ForeColor = Color.Gainsboro;
        btnManageVehicles.Location = new Point(0, 160);
        btnManageVehicles.Name = "btnManageVehicles";
        btnManageVehicles.Padding = new Padding(12, 0, 0, 0);
        btnManageVehicles.Size = new Size(220, 60);
        btnManageVehicles.TabIndex = 2;
        btnManageVehicles.Text = "   Vehicles";
        btnManageVehicles.TextAlign = ContentAlignment.MiddleLeft;
        btnManageVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageVehicles.UseVisualStyleBackColor = true;
        btnManageVehicles.Click += btnManageVehicles_Click;
        // 
        // btnManageDrivers
        // 
        btnManageDrivers.Dock = DockStyle.Top;
        btnManageDrivers.FlatAppearance.BorderSize = 0;
        btnManageDrivers.FlatStyle = FlatStyle.Flat;
        btnManageDrivers.Font = new Font("Segoe UI", 10F);
        btnManageDrivers.ForeColor = Color.Gainsboro;
        btnManageDrivers.Location = new Point(0, 100);
        btnManageDrivers.Name = "btnManageDrivers";
        btnManageDrivers.Padding = new Padding(12, 0, 0, 0);
        btnManageDrivers.Size = new Size(220, 60);
        btnManageDrivers.TabIndex = 1;
        btnManageDrivers.Text = "   Drivers";
        btnManageDrivers.TextAlign = ContentAlignment.MiddleLeft;
        btnManageDrivers.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnManageDrivers.UseVisualStyleBackColor = true;
        btnManageDrivers.Click += btnManageDrivers_Click;
        // 
        // pnlLogo
        // 
        pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
        pnlLogo.Controls.Add(lblTitle);
        pnlLogo.Dock = DockStyle.Top;
        pnlLogo.Location = new Point(0, 0);
        pnlLogo.Name = "pnlLogo";
        pnlLogo.Size = new Size(220, 100);
        pnlLogo.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(220, 100);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "LOGISTIC SYSTEM";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tabControlMain
        // 
        tabControlMain.Controls.Add(tabPageHome);
        tabControlMain.Dock = DockStyle.Fill;
        tabControlMain.Location = new Point(220, 0);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new Size(980, 1000);
        tabControlMain.TabIndex = 11;
        tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
        // 
        // tabPageHome
        // 
        tabPageHome.BackColor = Color.White;
        tabPageHome.Controls.Add(pnlHomeHero);
        tabPageHome.Location = new Point(4, 24);
        tabPageHome.Name = "tabPageHome";
        tabPageHome.Padding = new Padding(3);
        tabPageHome.Size = new Size(972, 972);
        tabPageHome.TabIndex = 0;
        tabPageHome.Text = "Dashboard";
        // 
        // pnlHomeHero
        // 
        pnlHomeHero.BackColor = Color.FromArgb(51, 51, 76);
        pnlHomeHero.Controls.Add(lblSubHeading);
        pnlHomeHero.Controls.Add(lblHomeHeading);
        pnlHomeHero.Dock = DockStyle.Fill;
        pnlHomeHero.Location = new Point(3, 3);
        pnlHomeHero.Name = "pnlHomeHero";
        pnlHomeHero.Size = new Size(966, 966);
        pnlHomeHero.TabIndex = 0;
        // 
        // lblHomeHeading
        // 
        lblHomeHeading.Anchor = AnchorStyles.None;
        lblHomeHeading.AutoSize = true;
        lblHomeHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
        lblHomeHeading.ForeColor = Color.White;
        lblHomeHeading.Location = new Point(148, 381);
        lblHomeHeading.Name = "lblHomeHeading";
        lblHomeHeading.Size = new Size(734, 65);
        lblHomeHeading.TabIndex = 0;
        lblHomeHeading.Text = "VEHICLE MANAGEMENT SYSTEM";
        lblHomeHeading.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubHeading
        // 
        lblSubHeading.Anchor = AnchorStyles.None;
        lblSubHeading.AutoSize = true;
        lblSubHeading.Font = new Font("Segoe UI", 14F);
        lblSubHeading.ForeColor = Color.Gainsboro;
        lblSubHeading.Location = new Point(328, 458);
        lblSubHeading.Name = "lblSubHeading";
        lblSubHeading.Size = new Size(367, 25);
        lblSubHeading.TabIndex = 1;
        lblSubHeading.Text = "Professional Logistics && Fleet Optimization";
        lblSubHeading.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 1000);
        Controls.Add(tabControlMain);
        Controls.Add(pnlSidebar);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Logistic Management System - Dashboard";
        pnlSidebar.ResumeLayout(false);
        pnlLogo.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Panel pnlLogo;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnManageDrivers;
    private System.Windows.Forms.Button btnManageVehicles;
    private System.Windows.Forms.Button btnManageRoutes;
    private System.Windows.Forms.Button btnManageShipments;
    private System.Windows.Forms.Button btnManageWarehouses;
    private System.Windows.Forms.Button btnManageTrips;
    private System.Windows.Forms.Button btnManageShipmentItems;
    private System.Windows.Forms.Button btnManageInventory;
    private System.Windows.Forms.Button btnManageDriverVehicle;
    private System.Windows.Forms.Button btnEmergencyAlert;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageHome;
    private System.Windows.Forms.Panel pnlHomeHero;
    private System.Windows.Forms.Label lblHomeHeading;
    private System.Windows.Forms.Label lblSubHeading;

}

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
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.pnlLogo = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnManageDrivers = new System.Windows.Forms.Button();
        this.btnManageVehicles = new System.Windows.Forms.Button();
        this.btnManageRoutes = new System.Windows.Forms.Button();
        this.btnManageShipments = new System.Windows.Forms.Button();
        this.btnManageWarehouses = new System.Windows.Forms.Button();
        this.btnManageTrips = new System.Windows.Forms.Button();
        this.btnManageShipmentItems = new System.Windows.Forms.Button();
        this.btnManageInventory = new System.Windows.Forms.Button();
        this.btnManageDriverVehicle = new System.Windows.Forms.Button();
        this.tabControlMain = new System.Windows.Forms.TabControl();
        this.pnlSidebar.SuspendLayout();
        this.pnlLogo.SuspendLayout();

        this.SuspendLayout();
        // 
        // pnlSidebar
        // 
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.pnlSidebar.Controls.Add(this.btnManageDriverVehicle);
        this.pnlSidebar.Controls.Add(this.btnManageInventory);
        this.pnlSidebar.Controls.Add(this.btnManageShipmentItems);
        this.pnlSidebar.Controls.Add(this.btnManageTrips);
        this.pnlSidebar.Controls.Add(this.btnManageWarehouses);
        this.pnlSidebar.Controls.Add(this.btnManageShipments);
        this.pnlSidebar.Controls.Add(this.btnManageRoutes);
        this.pnlSidebar.Controls.Add(this.btnManageVehicles);
        this.pnlSidebar.Controls.Add(this.btnManageDrivers);
        this.pnlSidebar.Controls.Add(this.pnlLogo);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Size = new System.Drawing.Size(220, 1000);
        this.pnlSidebar.TabIndex = 10;
        // 
        // pnlLogo
        // 
        this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
        this.pnlLogo.Controls.Add(this.lblTitle);
        this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlLogo.Location = new System.Drawing.Point(0, 0);
        this.pnlLogo.Name = "pnlLogo";
        this.pnlLogo.Size = new System.Drawing.Size(220, 100);
        this.pnlLogo.TabIndex = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(220, 100);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "LOGISTIC SYSTEM";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnManageDrivers
        // 
        this.btnManageDrivers.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageDrivers.FlatAppearance.BorderSize = 0;
        this.btnManageDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageDrivers.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageDrivers.Location = new System.Drawing.Point(0, 100);
        this.btnManageDrivers.Name = "btnManageDrivers";
        this.btnManageDrivers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageDrivers.Size = new System.Drawing.Size(220, 60);
        this.btnManageDrivers.TabIndex = 1;
        this.btnManageDrivers.Text = "   Drivers";
        this.btnManageDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageDrivers.UseVisualStyleBackColor = true;
        this.btnManageDrivers.Click += new System.EventHandler(this.btnManageDrivers_Click);
        // 
        // btnManageVehicles
        // 
        this.btnManageVehicles.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageVehicles.FlatAppearance.BorderSize = 0;
        this.btnManageVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageVehicles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageVehicles.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageVehicles.Location = new System.Drawing.Point(0, 160);
        this.btnManageVehicles.Name = "btnManageVehicles";
        this.btnManageVehicles.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageVehicles.Size = new System.Drawing.Size(220, 60);
        this.btnManageVehicles.TabIndex = 2;
        this.btnManageVehicles.Text = "   Vehicles";
        this.btnManageVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageVehicles.UseVisualStyleBackColor = true;
        this.btnManageVehicles.Click += new System.EventHandler(this.btnManageVehicles_Click);
        // 
        // btnManageRoutes
        // 
        this.btnManageRoutes.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageRoutes.FlatAppearance.BorderSize = 0;
        this.btnManageRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageRoutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageRoutes.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageRoutes.Location = new System.Drawing.Point(0, 220);
        this.btnManageRoutes.Name = "btnManageRoutes";
        this.btnManageRoutes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageRoutes.Size = new System.Drawing.Size(220, 60);
        this.btnManageRoutes.TabIndex = 3;
        this.btnManageRoutes.Text = "   Routes";
        this.btnManageRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageRoutes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageRoutes.UseVisualStyleBackColor = true;
        this.btnManageRoutes.Click += new System.EventHandler(this.btnManageRoutes_Click);
        // 
        // btnManageShipments
        // 
        this.btnManageShipments.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageShipments.FlatAppearance.BorderSize = 0;
        this.btnManageShipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageShipments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageShipments.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageShipments.Location = new System.Drawing.Point(0, 280);
        this.btnManageShipments.Name = "btnManageShipments";
        this.btnManageShipments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageShipments.Size = new System.Drawing.Size(220, 60);
        this.btnManageShipments.TabIndex = 4;
        this.btnManageShipments.Text = "   Shipments";
        this.btnManageShipments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageShipments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageShipments.UseVisualStyleBackColor = true;
        this.btnManageShipments.Click += new System.EventHandler(this.btnManageShipments_Click);
        // 
        // btnManageWarehouses
        // 
        this.btnManageWarehouses.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageWarehouses.FlatAppearance.BorderSize = 0;
        this.btnManageWarehouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageWarehouses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageWarehouses.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageWarehouses.Location = new System.Drawing.Point(0, 340);
        this.btnManageWarehouses.Name = "btnManageWarehouses";
        this.btnManageWarehouses.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageWarehouses.Size = new System.Drawing.Size(220, 60);
        this.btnManageWarehouses.TabIndex = 5;
        this.btnManageWarehouses.Text = "   Warehouses";
        this.btnManageWarehouses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageWarehouses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageWarehouses.UseVisualStyleBackColor = true;
        this.btnManageWarehouses.Click += new System.EventHandler(this.btnManageWarehouses_Click);
        // 
        // btnManageTrips
        // 
        this.btnManageTrips.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageTrips.FlatAppearance.BorderSize = 0;
        this.btnManageTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageTrips.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageTrips.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageTrips.Location = new System.Drawing.Point(0, 400);
        this.btnManageTrips.Name = "btnManageTrips";
        this.btnManageTrips.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageTrips.Size = new System.Drawing.Size(220, 60);
        this.btnManageTrips.TabIndex = 6;
        this.btnManageTrips.Text = "   Trips";
        this.btnManageTrips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageTrips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageTrips.UseVisualStyleBackColor = true;
        this.btnManageTrips.Click += new System.EventHandler(this.btnManageTrips_Click);
        // 
        // btnManageShipmentItems
        // 
        this.btnManageShipmentItems.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageShipmentItems.FlatAppearance.BorderSize = 0;
        this.btnManageShipmentItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageShipmentItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageShipmentItems.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageShipmentItems.Location = new System.Drawing.Point(0, 460);
        this.btnManageShipmentItems.Name = "btnManageShipmentItems";
        this.btnManageShipmentItems.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageShipmentItems.Size = new System.Drawing.Size(220, 60);
        this.btnManageShipmentItems.TabIndex = 7;
        this.btnManageShipmentItems.Text = "   Shipment Items";
        this.btnManageShipmentItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageShipmentItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageShipmentItems.UseVisualStyleBackColor = true;
        this.btnManageShipmentItems.Click += new System.EventHandler(this.btnManageShipmentItems_Click);
        // 
        // btnManageInventory
        // 
        this.btnManageInventory.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageInventory.FlatAppearance.BorderSize = 0;
        this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageInventory.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageInventory.Location = new System.Drawing.Point(0, 520);
        this.btnManageInventory.Name = "btnManageInventory";
        this.btnManageInventory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageInventory.Size = new System.Drawing.Size(220, 60);
        this.btnManageInventory.TabIndex = 8;
        this.btnManageInventory.Text = "   Inventory";
        this.btnManageInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageInventory.UseVisualStyleBackColor = true;
        this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
        // 
        // btnManageDriverVehicle
        // 
        this.btnManageDriverVehicle.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnManageDriverVehicle.FlatAppearance.BorderSize = 0;
        this.btnManageDriverVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnManageDriverVehicle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnManageDriverVehicle.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnManageDriverVehicle.Location = new System.Drawing.Point(0, 580);
        this.btnManageDriverVehicle.Name = "btnManageDriverVehicle";
        this.btnManageDriverVehicle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnManageDriverVehicle.Size = new System.Drawing.Size(220, 60);
        this.btnManageDriverVehicle.TabIndex = 9;
        this.btnManageDriverVehicle.Text = "   Assignments";
        this.btnManageDriverVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnManageDriverVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnManageDriverVehicle.UseVisualStyleBackColor = true;
        this.btnManageDriverVehicle.Click += new System.EventHandler(this.btnManageDriverVehicle_Click);
        // 
        // tabControlMain
        // 
        this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControlMain.Location = new System.Drawing.Point(220, 0);
        this.tabControlMain.Name = "tabControlMain";
        this.tabControlMain.SelectedIndex = 0;
        this.tabControlMain.Size = new System.Drawing.Size(980, 1000);
        this.tabControlMain.TabIndex = 11;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1200, 1000);
        this.Controls.Add(this.tabControlMain);
        this.Controls.Add(this.pnlSidebar);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Logistic Management System - Dashboard";
        this.pnlSidebar.ResumeLayout(false);
        this.pnlLogo.ResumeLayout(false);
        this.ResumeLayout(false);

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
    private System.Windows.Forms.TabControl tabControlMain;

}

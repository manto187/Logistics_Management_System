namespace LogisticManagementSystem;

partial class TripForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

#region Windows Form Designer generated code

    private void InitializeComponent()
    {
        layoutPanelMain = new TableLayoutPanel();
        panelInputs = new Panel();
        grpTripDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtTripId = new TextBox();
        lblDriver = new Label();
        cmbDriver = new ComboBox();
        lblVehicle = new Label();
        cmbVehicle = new ComboBox();
        lblShipment = new Label();
        cmbShipment = new ComboBox();
        lblRoute = new Label();
        cmbRoute = new ComboBox();
        lblStart = new Label();
        dtpStartTime = new DateTimePicker();
        lblEnd = new Label();
        dtpEndTime = new DateTimePicker();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvTrips = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpTripDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvTrips, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 500);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpTripDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 314);
        panelInputs.TabIndex = 0;
        // 
        // grpTripDetails
        // 
        this.grpTripDetails.BackColor = System.Drawing.Color.White;
        this.grpTripDetails.Controls.Add(this.tlpInputs);
        this.grpTripDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpTripDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpTripDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpTripDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpTripDetails.Location = new System.Drawing.Point(10, 10);
        this.grpTripDetails.Name = "grpTripDetails";
        this.grpTripDetails.Size = new Size(774, 294);
        this.grpTripDetails.TabIndex = 0;
        this.grpTripDetails.TabStop = false;
        this.grpTripDetails.Text = "TRIP SCHEDULE";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtTripId, 1, 0);
        tlpInputs.Controls.Add(lblDriver, 0, 1);
        tlpInputs.Controls.Add(cmbDriver, 1, 1);
        tlpInputs.Controls.Add(lblVehicle, 0, 2);
        tlpInputs.Controls.Add(cmbVehicle, 1, 2);
        tlpInputs.Controls.Add(lblShipment, 0, 3);
        tlpInputs.Controls.Add(cmbShipment, 1, 3);
        tlpInputs.Controls.Add(lblRoute, 0, 4);
        tlpInputs.Controls.Add(cmbRoute, 1, 4);
        tlpInputs.Controls.Add(lblStart, 0, 5);
        tlpInputs.Controls.Add(dtpStartTime, 1, 5);
        tlpInputs.Controls.Add(lblEnd, 0, 6);
        tlpInputs.Controls.Add(dtpEndTime, 1, 6);
        tlpInputs.Dock = DockStyle.Top;
        tlpInputs.Location = new Point(3, 19);
        tlpInputs.Name = "tlpInputs";
        tlpInputs.RowCount = 7;
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.Size = new Size(768, 220);
        tlpInputs.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.Anchor = AnchorStyles.Left;
        lblId.Location = new Point(3, 3);
        lblId.Name = "lblId";
        lblId.Size = new Size(100, 23);
        lblId.TabIndex = 0;
        lblId.Text = "Trip ID:";
        // 
        // txtTripId
        // 
        txtTripId.BackColor = SystemColors.ControlLight;
        txtTripId.Dock = DockStyle.Fill;
        txtTripId.Location = new Point(123, 3);
        txtTripId.Name = "txtTripId";
        txtTripId.ReadOnly = true;
        txtTripId.Size = new Size(642, 23);
        txtTripId.TabIndex = 1;
        // 
        // lblDriver
        // 
        lblDriver.Anchor = AnchorStyles.Left;
        lblDriver.Location = new Point(3, 33);
        lblDriver.Name = "lblDriver";
        lblDriver.Size = new Size(100, 23);
        lblDriver.TabIndex = 2;
        lblDriver.Text = "Driver:";
        // 
        // cmbDriver
        // 
        cmbDriver.Dock = DockStyle.Fill;
        cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDriver.FormattingEnabled = true;
        cmbDriver.Location = new Point(123, 33);
        cmbDriver.Name = "cmbDriver";
        cmbDriver.Size = new Size(642, 23);
        cmbDriver.TabIndex = 3;
        // 
        // lblVehicle
        // 
        lblVehicle.Anchor = AnchorStyles.Left;
        lblVehicle.Location = new Point(3, 63);
        lblVehicle.Name = "lblVehicle";
        lblVehicle.Size = new Size(100, 23);
        lblVehicle.TabIndex = 4;
        lblVehicle.Text = "Vehicle:";
        // 
        // cmbVehicle
        // 
        cmbVehicle.Dock = DockStyle.Fill;
        cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbVehicle.FormattingEnabled = true;
        cmbVehicle.Location = new Point(123, 63);
        cmbVehicle.Name = "cmbVehicle";
        cmbVehicle.Size = new Size(642, 23);
        cmbVehicle.TabIndex = 5;
        // 
        // lblShipment
        // 
        lblShipment.Anchor = AnchorStyles.Left;
        lblShipment.Location = new Point(3, 93);
        lblShipment.Name = "lblShipment";
        lblShipment.Size = new Size(100, 23);
        lblShipment.TabIndex = 6;
        lblShipment.Text = "Shipment:";
        // 
        // cmbShipment
        // 
        cmbShipment.Dock = DockStyle.Fill;
        cmbShipment.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbShipment.FormattingEnabled = true;
        cmbShipment.Location = new Point(123, 93);
        cmbShipment.Name = "cmbShipment";
        cmbShipment.Size = new Size(642, 23);
        cmbShipment.TabIndex = 7;
        // 
        // lblRoute
        // 
        lblRoute.Anchor = AnchorStyles.Left;
        lblRoute.Location = new Point(3, 123);
        lblRoute.Name = "lblRoute";
        lblRoute.Size = new Size(100, 23);
        lblRoute.TabIndex = 8;
        lblRoute.Text = "Route:";
        // 
        // cmbRoute
        // 
        cmbRoute.Dock = DockStyle.Fill;
        cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRoute.FormattingEnabled = true;
        cmbRoute.Location = new Point(123, 123);
        cmbRoute.Name = "cmbRoute";
        cmbRoute.Size = new Size(642, 23);
        cmbRoute.TabIndex = 9;
        // 
        // lblStart
        // 
        lblStart.Anchor = AnchorStyles.Left;
        lblStart.Location = new Point(3, 153);
        lblStart.Name = "lblStart";
        lblStart.Size = new Size(100, 23);
        lblStart.TabIndex = 10;
        lblStart.Text = "Start Time:";
        // 
        // dtpStartTime
        // 
        dtpStartTime.Dock = DockStyle.Fill;
        dtpStartTime.Format = DateTimePickerFormat.Custom;
        dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        dtpStartTime.Location = new Point(123, 153);
        dtpStartTime.Name = "dtpStartTime";
        dtpStartTime.Size = new Size(642, 23);
        dtpStartTime.TabIndex = 11;
        // 
        // lblEnd
        // 
        lblEnd.Anchor = AnchorStyles.Left;
        lblEnd.Location = new Point(3, 183);
        lblEnd.Name = "lblEnd";
        lblEnd.Size = new Size(100, 23);
        lblEnd.TabIndex = 12;
        lblEnd.Text = "End Time:";
        // 
        // dtpEndTime
        // 
        dtpEndTime.Dock = DockStyle.Fill;
        dtpEndTime.Format = DateTimePickerFormat.Custom;
        dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        dtpEndTime.Location = new Point(123, 183);
        dtpEndTime.Name = "dtpEndTime";
        dtpEndTime.Size = new Size(642, 23);
        dtpEndTime.TabIndex = 13;
        // 
        // flowLayoutPanelButtons
        // 
        flowLayoutPanelButtons.Controls.Add(btnAdd);
        flowLayoutPanelButtons.Controls.Add(btnUpdate);
        flowLayoutPanelButtons.Controls.Add(btnDelete);
        flowLayoutPanelButtons.Controls.Add(btnClear);
        flowLayoutPanelButtons.Dock = DockStyle.Bottom;
        flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanelButtons.Location = new Point(3, 251);
        flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
        flowLayoutPanelButtons.Size = new Size(768, 40);
        flowLayoutPanelButtons.TabIndex = 1;
        // 
        // btnAdd
        // 
        this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(665, 3);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new Size(100, 30);
        this.btnAdd.TabIndex = 0;
        this.btnAdd.Text = "SAVE";
        this.btnAdd.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(559, 3);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(100, 30);
        this.btnUpdate.TabIndex = 1;
        this.btnUpdate.Text = "UPDATE";
        this.btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(453, 3);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(100, 30);
        this.btnDelete.TabIndex = 2;
        this.btnDelete.Text = "DELETE";
        this.btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnClear
        // 
        this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnClear.ForeColor = System.Drawing.Color.White;
        this.btnClear.Location = new System.Drawing.Point(347, 3);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(100, 30);
        this.btnClear.TabIndex = 3;
        this.btnClear.Text = "CLEAR";
        this.btnClear.UseVisualStyleBackColor = false;

        // 
        // dgvTrips
        // 
        this.dgvTrips.AllowUserToAddRows = false;
        this.dgvTrips.AllowUserToDeleteRows = false;
        this.dgvTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTrips.BackgroundColor = System.Drawing.Color.White;
        this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvTrips.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvTrips.EnableHeadersVisualStyles = false;
        this.dgvTrips.Location = new System.Drawing.Point(3, 323);
        this.dgvTrips.MultiSelect = false;
        this.dgvTrips.Name = "dgvTrips";
        this.dgvTrips.ReadOnly = true;
        this.dgvTrips.RowHeadersVisible = false;
        this.dgvTrips.RowTemplate.Height = 35;
        this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvTrips.Size = new Size(794, 184);
        this.dgvTrips.TabIndex = 1;
        this.dgvTrips.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvTrips.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvTrips.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvTrips.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // TripForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 500);
        Controls.Add(layoutPanelMain);
        Name = "TripForm";
        Text = "Trip Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpTripDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpTripDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtTripId;
    
    private System.Windows.Forms.Label lblDriver;
    private System.Windows.Forms.ComboBox cmbDriver;
    
    private System.Windows.Forms.Label lblVehicle;
    private System.Windows.Forms.ComboBox cmbVehicle;
    
    private System.Windows.Forms.Label lblShipment;
    private System.Windows.Forms.ComboBox cmbShipment;
    
    private System.Windows.Forms.Label lblRoute;
    private System.Windows.Forms.ComboBox cmbRoute;
    
    private System.Windows.Forms.Label lblStart;
    private System.Windows.Forms.DateTimePicker dtpStartTime;
    private System.Windows.Forms.Label lblEnd;
    private System.Windows.Forms.DateTimePicker dtpEndTime;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvTrips;
}

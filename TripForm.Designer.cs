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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
        grpTripDetails.BackColor = Color.White;
        grpTripDetails.Controls.Add(tlpInputs);
        grpTripDetails.Controls.Add(flowLayoutPanelButtons);
        grpTripDetails.Dock = DockStyle.Fill;
        grpTripDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpTripDetails.ForeColor = Color.FromArgb(51, 51, 76);
        grpTripDetails.Location = new Point(10, 10);
        grpTripDetails.Name = "grpTripDetails";
        grpTripDetails.Size = new Size(774, 294);
        grpTripDetails.TabIndex = 0;
        grpTripDetails.TabStop = false;
        grpTripDetails.Text = "TRIP SCHEDULE";
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
        tlpInputs.Location = new Point(3, 21);
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
        txtTripId.Size = new Size(642, 25);
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
        cmbDriver.Size = new Size(642, 25);
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
        cmbVehicle.Size = new Size(642, 25);
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
        cmbShipment.Size = new Size(642, 25);
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
        cmbRoute.Size = new Size(642, 25);
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
        dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        dtpStartTime.Dock = DockStyle.Fill;
        dtpStartTime.Format = DateTimePickerFormat.Custom;
        dtpStartTime.Location = new Point(123, 153);
        dtpStartTime.Name = "dtpStartTime";
        dtpStartTime.Size = new Size(642, 25);
        dtpStartTime.TabIndex = 11;
        // 
        // lblEnd
        // 
        lblEnd.Anchor = AnchorStyles.Left;
        lblEnd.Location = new Point(3, 188);
        lblEnd.Name = "lblEnd";
        lblEnd.Size = new Size(100, 23);
        lblEnd.TabIndex = 12;
        lblEnd.Text = "End Time:";
        // 
        // dtpEndTime
        // 
        dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        dtpEndTime.Dock = DockStyle.Fill;
        dtpEndTime.Format = DateTimePickerFormat.Custom;
        dtpEndTime.Location = new Point(123, 183);
        dtpEndTime.Name = "dtpEndTime";
        dtpEndTime.Size = new Size(642, 25);
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
        btnAdd.BackColor = Color.FromArgb(51, 51, 76);
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(665, 3);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 30);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "SAVE";
        btnAdd.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.FromArgb(0, 150, 136);
        btnUpdate.FlatAppearance.BorderSize = 0;
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(559, 3);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(100, 30);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "UPDATE";
        btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(255, 82, 82);
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(453, 3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(100, 30);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "DELETE";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.FromArgb(158, 158, 158);
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnClear.ForeColor = Color.White;
        btnClear.Location = new Point(347, 3);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(100, 30);
        btnClear.TabIndex = 3;
        btnClear.Text = "CLEAR";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // dgvTrips
        // 
        dgvTrips.AllowUserToAddRows = false;
        dgvTrips.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
        dgvTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTrips.BackgroundColor = Color.White;
        dgvTrips.BorderStyle = BorderStyle.None;
        dgvTrips.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvTrips.DefaultCellStyle = dataGridViewCellStyle2;
        dgvTrips.Dock = DockStyle.Fill;
        dgvTrips.EnableHeadersVisualStyles = false;
        dgvTrips.Location = new Point(3, 323);
        dgvTrips.MultiSelect = false;
        dgvTrips.Name = "dgvTrips";
        dgvTrips.ReadOnly = true;
        dgvTrips.RowHeadersVisible = false;
        dgvTrips.RowTemplate.Height = 35;
        dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTrips.Size = new Size(794, 174);
        dgvTrips.TabIndex = 1;
        dgvTrips.CellContentClick += dgvTrips_CellContentClick;
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

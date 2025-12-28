namespace LogisticManagementSystem;

partial class ShipmentForm
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
        grpShipmentDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtShipmentId = new TextBox();
        lblCode = new Label();
        txtShipmentCode = new TextBox();
        lblWeight = new Label();
        numWeight = new NumericUpDown();
        lblPickup = new Label();
        txtPickupLocation = new TextBox();
        lblDropoff = new Label();
        txtDropoffLocation = new TextBox();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        lblDate = new Label();
        dtpCreatedAt = new DateTimePicker();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvShipments = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpShipmentDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvShipments, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 450);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpShipmentDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 314);
        panelInputs.TabIndex = 0;
        // 
        // grpShipmentDetails
        // 
        this.grpShipmentDetails.BackColor = System.Drawing.Color.White;
        this.grpShipmentDetails.Controls.Add(this.tlpInputs);
        this.grpShipmentDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpShipmentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpShipmentDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpShipmentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpShipmentDetails.Location = new System.Drawing.Point(10, 10);
        this.grpShipmentDetails.Name = "grpShipmentDetails";
        this.grpShipmentDetails.Size = new System.Drawing.Size(774, 294);
        this.grpShipmentDetails.TabIndex = 0;
        this.grpShipmentDetails.TabStop = false;
        this.grpShipmentDetails.Text = "SHIPMENT TRACKING";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtShipmentId, 1, 0);
        tlpInputs.Controls.Add(lblCode, 0, 1);
        tlpInputs.Controls.Add(txtShipmentCode, 1, 1);
        tlpInputs.Controls.Add(lblWeight, 0, 2);
        tlpInputs.Controls.Add(numWeight, 1, 2);
        tlpInputs.Controls.Add(lblPickup, 0, 3);
        tlpInputs.Controls.Add(txtPickupLocation, 1, 3);
        tlpInputs.Controls.Add(lblDropoff, 0, 4);
        tlpInputs.Controls.Add(txtDropoffLocation, 1, 4);
        tlpInputs.Controls.Add(lblStatus, 0, 5);
        tlpInputs.Controls.Add(cmbStatus, 1, 5);
        tlpInputs.Controls.Add(lblDate, 0, 6);
        tlpInputs.Controls.Add(dtpCreatedAt, 1, 6);
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
        lblId.Text = "Shipment ID:";
        // 
        // txtShipmentId
        // 
        txtShipmentId.BackColor = SystemColors.ControlLight;
        txtShipmentId.Dock = DockStyle.Fill;
        txtShipmentId.Location = new Point(123, 3);
        txtShipmentId.Name = "txtShipmentId";
        txtShipmentId.ReadOnly = true;
        txtShipmentId.Size = new Size(642, 23);
        txtShipmentId.TabIndex = 1;
        // 
        // lblCode
        // 
        lblCode.Anchor = AnchorStyles.Left;
        lblCode.Location = new Point(3, 33);
        lblCode.Name = "lblCode";
        lblCode.Size = new Size(100, 23);
        lblCode.TabIndex = 2;
        lblCode.Text = "Shipment Code:";
        // 
        // txtShipmentCode
        // 
        txtShipmentCode.Dock = DockStyle.Fill;
        txtShipmentCode.Location = new Point(123, 33);
        txtShipmentCode.Name = "txtShipmentCode";
        txtShipmentCode.Size = new Size(642, 23);
        txtShipmentCode.TabIndex = 3;
        // 
        // lblWeight
        // 
        lblWeight.Anchor = AnchorStyles.Left;
        lblWeight.Location = new Point(3, 63);
        lblWeight.Name = "lblWeight";
        lblWeight.Size = new Size(100, 23);
        lblWeight.TabIndex = 4;
        lblWeight.Text = "Weight (kg):";
        // 
        // numWeight
        // 
        numWeight.Dock = DockStyle.Fill;
        numWeight.Location = new Point(123, 63);
        numWeight.DecimalPlaces = 2;
        numWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numWeight.Name = "numWeight";
        numWeight.Size = new Size(642, 23);
        numWeight.TabIndex = 5;
        // 
        // lblPickup
        // 
        lblPickup.Anchor = AnchorStyles.Left;
        lblPickup.Location = new Point(3, 93);
        lblPickup.Name = "lblPickup";
        lblPickup.Size = new Size(100, 23);
        lblPickup.TabIndex = 6;
        lblPickup.Text = "Pickup Loc:";
        // 
        // txtPickupLocation
        // 
        txtPickupLocation.Dock = DockStyle.Fill;
        txtPickupLocation.Location = new Point(123, 93);
        txtPickupLocation.Name = "txtPickupLocation";
        txtPickupLocation.Size = new Size(642, 23);
        txtPickupLocation.TabIndex = 7;
        // 
        // lblDropoff
        // 
        lblDropoff.Anchor = AnchorStyles.Left;
        lblDropoff.Location = new Point(3, 123);
        lblDropoff.Name = "lblDropoff";
        lblDropoff.Size = new Size(100, 23);
        lblDropoff.TabIndex = 8;
        lblDropoff.Text = "Dropoff Loc:";
        // 
        // txtDropoffLocation
        // 
        txtDropoffLocation.Dock = DockStyle.Fill;
        txtDropoffLocation.Location = new Point(123, 123);
        txtDropoffLocation.Name = "txtDropoffLocation";
        txtDropoffLocation.Size = new Size(642, 23);
        txtDropoffLocation.TabIndex = 9;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Left;
        lblStatus.Location = new Point(3, 153);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(100, 23);
        lblStatus.TabIndex = 10;
        lblStatus.Text = "Status:";
        // 
        // cmbStatus
        // 
        cmbStatus.Dock = DockStyle.Fill;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.Items.AddRange(new object[] { "Pending", "In Transit", "Delivered", "Cancelled" });
        cmbStatus.Location = new Point(123, 153);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(642, 23);
        cmbStatus.TabIndex = 11;
        // 
        // lblDate
        // 
        lblDate.Anchor = AnchorStyles.Left;
        lblDate.Location = new Point(3, 183);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(100, 23);
        lblDate.TabIndex = 12;
        lblDate.Text = "Created At:";
        // 
        // dtpCreatedAt
        // 
        dtpCreatedAt.Dock = DockStyle.Fill;
        dtpCreatedAt.Location = new Point(123, 183);
        dtpCreatedAt.Name = "dtpCreatedAt";
        dtpCreatedAt.Size = new Size(642, 23);
        dtpCreatedAt.TabIndex = 13;
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
        this.btnAdd.Size = new System.Drawing.Size(100, 30);
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
        // dgvShipments
        // 
        this.dgvShipments.AllowUserToAddRows = false;
        this.dgvShipments.AllowUserToDeleteRows = false;
        this.dgvShipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvShipments.BackgroundColor = System.Drawing.Color.White;
        this.dgvShipments.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvShipments.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvShipments.EnableHeadersVisualStyles = false;
        this.dgvShipments.Location = new System.Drawing.Point(3, 323);
        this.dgvShipments.MultiSelect = false;
        this.dgvShipments.Name = "dgvShipments";
        this.dgvShipments.ReadOnly = true;
        this.dgvShipments.RowHeadersVisible = false;
        this.dgvShipments.RowTemplate.Height = 35;
        this.dgvShipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvShipments.Size = new Size(794, 124);
        this.dgvShipments.TabIndex = 1;
        this.dgvShipments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvShipments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvShipments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvShipments.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // ShipmentForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(layoutPanelMain);
        Name = "ShipmentForm";
        Text = "Shipment Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpShipmentDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpShipmentDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtShipmentId;
    private System.Windows.Forms.Label lblCode;
    private System.Windows.Forms.TextBox txtShipmentCode;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.NumericUpDown numWeight;
    private System.Windows.Forms.Label lblPickup;
    private System.Windows.Forms.TextBox txtPickupLocation;
    private System.Windows.Forms.Label lblDropoff;
    private System.Windows.Forms.TextBox txtDropoffLocation;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dtpCreatedAt;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvShipments;
}

namespace LogisticManagementSystem;

partial class VehicleForm
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
        grpVehicleDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtVehicleId = new TextBox();
        lblModel = new Label();
        txtModel = new TextBox();
        lblPlate = new Label();
        txtPlateNumber = new TextBox();
        lblType = new Label();
        cmbVehicleType = new ComboBox();
        lblMileage = new Label();
        numMileage = new NumericUpDown();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        lblDate = new Label();
        dtpCreatedAt = new DateTimePicker();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvVehicles = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpVehicleDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvVehicles, 0, 1);
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
        panelInputs.Controls.Add(grpVehicleDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 314);
        panelInputs.TabIndex = 0;
        // 
        // grpVehicleDetails
        // 
        this.grpVehicleDetails.BackColor = System.Drawing.Color.White;
        this.grpVehicleDetails.Controls.Add(this.tlpInputs);
        this.grpVehicleDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpVehicleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpVehicleDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpVehicleDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpVehicleDetails.Location = new System.Drawing.Point(10, 10);
        this.grpVehicleDetails.Name = "grpVehicleDetails";
        this.grpVehicleDetails.Size = new System.Drawing.Size(774, 294);
        this.grpVehicleDetails.TabIndex = 0;
        this.grpVehicleDetails.TabStop = false;
        this.grpVehicleDetails.Text = "VEHICLE INFORMATION";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtVehicleId, 1, 0);
        tlpInputs.Controls.Add(lblModel, 0, 1);
        tlpInputs.Controls.Add(txtModel, 1, 1);
        tlpInputs.Controls.Add(lblPlate, 0, 2);
        tlpInputs.Controls.Add(txtPlateNumber, 1, 2);
        tlpInputs.Controls.Add(lblType, 0, 3);
        tlpInputs.Controls.Add(cmbVehicleType, 1, 3);
        tlpInputs.Controls.Add(lblMileage, 0, 4);
        tlpInputs.Controls.Add(numMileage, 1, 4);
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
        lblId.Text = "Vehicle ID:";
        // 
        // txtVehicleId
        // 
        txtVehicleId.BackColor = SystemColors.ControlLight;
        txtVehicleId.Dock = DockStyle.Fill;
        txtVehicleId.Location = new Point(123, 3);
        txtVehicleId.Name = "txtVehicleId";
        txtVehicleId.ReadOnly = true;
        txtVehicleId.Size = new Size(642, 23);
        txtVehicleId.TabIndex = 1;
        // 
        // lblModel
        // 
        lblModel.Anchor = AnchorStyles.Left;
        lblModel.Location = new Point(3, 33);
        lblModel.Name = "lblModel";
        lblModel.Size = new Size(100, 23);
        lblModel.TabIndex = 2;
        lblModel.Text = "Model:";
        // 
        // txtModel
        // 
        txtModel.Dock = DockStyle.Fill;
        txtModel.Location = new Point(123, 33);
        txtModel.Name = "txtModel";
        txtModel.Size = new Size(642, 23);
        txtModel.TabIndex = 3;
        // 
        // lblPlate
        // 
        lblPlate.Anchor = AnchorStyles.Left;
        lblPlate.Location = new Point(3, 63);
        lblPlate.Name = "lblPlate";
        lblPlate.Size = new Size(100, 23);
        lblPlate.TabIndex = 4;
        lblPlate.Text = "Plate Number:";
        // 
        // txtPlateNumber
        // 
        txtPlateNumber.Dock = DockStyle.Fill;
        txtPlateNumber.Location = new Point(123, 63);
        txtPlateNumber.Name = "txtPlateNumber";
        txtPlateNumber.Size = new Size(642, 23);
        txtPlateNumber.TabIndex = 5;
        // 
        // lblType
        // 
        lblType.Anchor = AnchorStyles.Left;
        lblType.Location = new Point(3, 93);
        lblType.Name = "lblType";
        lblType.Size = new Size(100, 23);
        lblType.TabIndex = 6;
        lblType.Text = "Vehicle Type:";
        // 
        // cmbVehicleType
        // 
        cmbVehicleType.Dock = DockStyle.Fill;
        cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbVehicleType.Items.AddRange(new object[] { "Sedan", "SUV", "Truck", "Van", "Motorcycle" });
        cmbVehicleType.Location = new Point(123, 93);
        cmbVehicleType.Name = "cmbVehicleType";
        cmbVehicleType.Size = new Size(642, 23);
        cmbVehicleType.TabIndex = 7;
        // 
        // lblMileage
        // 
        lblMileage.Anchor = AnchorStyles.Left;
        lblMileage.Location = new Point(3, 123);
        lblMileage.Name = "lblMileage";
        lblMileage.Size = new Size(100, 23);
        lblMileage.TabIndex = 8;
        lblMileage.Text = "Mileage:";
        // 
        // numMileage
        // 
        numMileage.Dock = DockStyle.Fill;
        numMileage.Location = new Point(123, 123);
        numMileage.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numMileage.Name = "numMileage";
        numMileage.Size = new Size(642, 23);
        numMileage.TabIndex = 9;
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
        cmbStatus.Items.AddRange(new object[] { "Active", "Maintenance", "Retired", "Reserved" });
        cmbStatus.Location = new Point(123, 153);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(642, 23);
        cmbStatus.TabIndex = 11;
        // 
        // lblDate
        // 
        lblDate.Anchor = AnchorStyles.Left;
        lblDate.Location = new Point(3, 188);
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
        // dgvVehicles
        // 
        this.dgvVehicles.AllowUserToAddRows = false;
        this.dgvVehicles.AllowUserToDeleteRows = false;
        this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
        this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvVehicles.EnableHeadersVisualStyles = false;
        this.dgvVehicles.Location = new System.Drawing.Point(3, 323);
        this.dgvVehicles.MultiSelect = false;
        this.dgvVehicles.Name = "dgvVehicles";
        this.dgvVehicles.ReadOnly = true;
        this.dgvVehicles.RowHeadersVisible = false;
        this.dgvVehicles.RowTemplate.Height = 35;
        this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvVehicles.Size = new System.Drawing.Size(794, 124);
        this.dgvVehicles.TabIndex = 1;
        this.dgvVehicles.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvVehicles.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvVehicles.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // VehicleForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(layoutPanelMain);
        Name = "VehicleForm";
        Text = "Vehicle Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpVehicleDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpVehicleDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtVehicleId;
    private System.Windows.Forms.Label lblModel;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.Label lblPlate;
    private System.Windows.Forms.TextBox txtPlateNumber;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.ComboBox cmbVehicleType;
    private System.Windows.Forms.Label lblMileage;
    private System.Windows.Forms.NumericUpDown numMileage;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dtpCreatedAt;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvVehicles;
}

namespace LogisticManagementSystem;

partial class DriverForm
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
        grpDriverDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtDriverId = new TextBox();
        lblName = new Label();
        txtName = new TextBox();
        lblPhone = new Label();
        txtPhoneNumber = new TextBox();
        lblLicense = new Label();
        txtLicenseNumber = new TextBox();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        lblDate = new Label();
        dtpCreatedAt = new DateTimePicker();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvDrivers = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpDriverDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvDrivers, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 523F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(1248, 822);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpDriverDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(1242, 517);
        panelInputs.TabIndex = 0;
        // 
        // grpDriverDetails
        // 
        this.grpDriverDetails.BackColor = System.Drawing.Color.White;
        this.grpDriverDetails.Controls.Add(this.tlpInputs);
        this.grpDriverDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpDriverDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpDriverDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpDriverDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpDriverDetails.Location = new System.Drawing.Point(10, 10);
        this.grpDriverDetails.Name = "grpDriverDetails";
        this.grpDriverDetails.Size = new System.Drawing.Size(1222, 497);
        this.grpDriverDetails.TabIndex = 0;
        this.grpDriverDetails.TabStop = false;
        this.grpDriverDetails.Text = "DRIVER REGISTRATION";

        grpDriverDetails.Enter += grpDriverDetails_Enter;
        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtDriverId, 1, 0);
        tlpInputs.Controls.Add(lblName, 0, 1);
        tlpInputs.Controls.Add(txtName, 1, 1);
        tlpInputs.Controls.Add(lblPhone, 0, 2);
        tlpInputs.Controls.Add(txtPhoneNumber, 1, 2);
        tlpInputs.Controls.Add(lblLicense, 0, 3);
        tlpInputs.Controls.Add(txtLicenseNumber, 1, 3);
        tlpInputs.Controls.Add(lblStatus, 0, 4);
        tlpInputs.Controls.Add(cmbStatus, 1, 4);
        tlpInputs.Controls.Add(lblDate, 0, 5);
        tlpInputs.Controls.Add(dtpCreatedAt, 1, 5);
        tlpInputs.Dock = DockStyle.Top;
        tlpInputs.Location = new Point(3, 19);
        tlpInputs.Name = "tlpInputs";
        tlpInputs.RowCount = 6;
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.Size = new Size(1216, 180);
        tlpInputs.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.Anchor = AnchorStyles.Left;
        lblId.Location = new Point(3, 3);
        lblId.Name = "lblId";
        lblId.Size = new Size(100, 23);
        lblId.TabIndex = 0;
        lblId.Text = "Driver ID:";
        // 
        // txtDriverId
        // 
        txtDriverId.BackColor = Color.AntiqueWhite;
        txtDriverId.Dock = DockStyle.Fill;
        txtDriverId.Location = new Point(123, 3);
        txtDriverId.Name = "txtDriverId";
        txtDriverId.ReadOnly = true;
        txtDriverId.Size = new Size(1090, 23);
        txtDriverId.TabIndex = 1;
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.Left;
        lblName.Location = new Point(3, 33);
        lblName.Name = "lblName";
        lblName.Size = new Size(100, 23);
        lblName.TabIndex = 2;
        lblName.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Dock = DockStyle.Fill;
        txtName.Location = new Point(123, 33);
        txtName.Name = "txtName";
        txtName.Size = new Size(1090, 23);
        txtName.TabIndex = 3;
        // 
        // lblPhone
        // 
        lblPhone.Anchor = AnchorStyles.Left;
        lblPhone.Location = new Point(3, 63);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(100, 23);
        lblPhone.TabIndex = 4;
        lblPhone.Text = "Phone Number:";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Dock = DockStyle.Fill;
        txtPhoneNumber.Location = new Point(123, 63);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.Size = new Size(1090, 23);
        txtPhoneNumber.TabIndex = 5;
        // 
        // lblLicense
        // 
        lblLicense.Anchor = AnchorStyles.Left;
        lblLicense.Location = new Point(3, 93);
        lblLicense.Name = "lblLicense";
        lblLicense.Size = new Size(100, 23);
        lblLicense.TabIndex = 6;
        lblLicense.Text = "License Number:";
        // 
        // txtLicenseNumber
        // 
        txtLicenseNumber.Dock = DockStyle.Fill;
        txtLicenseNumber.Location = new Point(123, 93);
        txtLicenseNumber.Name = "txtLicenseNumber";
        txtLicenseNumber.Size = new Size(1090, 23);
        txtLicenseNumber.TabIndex = 7;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Left;
        lblStatus.Location = new Point(3, 123);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(100, 23);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Status:";
        // 
        // cmbStatus
        // 
        cmbStatus.Dock = DockStyle.Fill;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.Items.AddRange(new object[] { "Active", "Inactive", "On Leave" });
        cmbStatus.Location = new Point(123, 123);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(1090, 23);
        cmbStatus.TabIndex = 9;
        // 
        // lblDate
        // 
        lblDate.Anchor = AnchorStyles.Left;
        lblDate.Location = new Point(3, 153);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(100, 23);
        lblDate.TabIndex = 10;
        lblDate.Text = "Created At:";
        // 
        // dtpCreatedAt
        // 
        dtpCreatedAt.Dock = DockStyle.Fill;
        dtpCreatedAt.Location = new Point(123, 153);
        dtpCreatedAt.Name = "dtpCreatedAt";
        dtpCreatedAt.Size = new Size(1090, 23);
        dtpCreatedAt.TabIndex = 11;
        // 
        // flowLayoutPanelButtons
        // 
        flowLayoutPanelButtons.Controls.Add(btnAdd);
        flowLayoutPanelButtons.Controls.Add(btnUpdate);
        flowLayoutPanelButtons.Controls.Add(btnDelete);
        flowLayoutPanelButtons.Controls.Add(btnClear);
        flowLayoutPanelButtons.Dock = DockStyle.Bottom;
        flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanelButtons.Location = new Point(3, 454);
        flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
        flowLayoutPanelButtons.Size = new Size(1216, 40);
        flowLayoutPanelButtons.TabIndex = 1;
        // 
        // btnAdd
        // 
        this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(1113, 3);
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
        this.btnUpdate.Location = new System.Drawing.Point(1007, 3);
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
        this.btnDelete.Location = new System.Drawing.Point(901, 3);
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
        this.btnClear.Location = new System.Drawing.Point(795, 3);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(100, 30);
        this.btnClear.TabIndex = 3;
        this.btnClear.Text = "CLEAR";
        this.btnClear.UseVisualStyleBackColor = false;

        // 
        // dgvDrivers
        // 
        this.dgvDrivers.AllowUserToAddRows = false;
        this.dgvDrivers.AllowUserToDeleteRows = false;
        this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
        this.dgvDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvDrivers.EnableHeadersVisualStyles = false;
        this.dgvDrivers.Location = new System.Drawing.Point(3, 526);
        this.dgvDrivers.MultiSelect = false;
        this.dgvDrivers.Name = "dgvDrivers";
        this.dgvDrivers.ReadOnly = true;
        this.dgvDrivers.RowHeadersVisible = false;
        this.dgvDrivers.RowTemplate.Height = 35;
        this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvDrivers.Size = new System.Drawing.Size(1242, 293);
        this.dgvDrivers.TabIndex = 1;
        this.dgvDrivers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvDrivers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvDrivers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // DriverForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1248, 822);
        Controls.Add(layoutPanelMain);
        Name = "DriverForm";
        Text = "Driver Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpDriverDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpDriverDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtDriverId;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.Label lblLicense;
    private System.Windows.Forms.TextBox txtLicenseNumber;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dtpCreatedAt;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvDrivers;
}

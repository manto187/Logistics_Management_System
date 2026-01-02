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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
        grpDriverDetails.BackColor = Color.White;
        grpDriverDetails.Controls.Add(tlpInputs);
        grpDriverDetails.Controls.Add(flowLayoutPanelButtons);
        grpDriverDetails.Dock = DockStyle.Fill;
        grpDriverDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpDriverDetails.ForeColor = Color.FromArgb(51, 51, 76);
        grpDriverDetails.Location = new Point(10, 10);
        grpDriverDetails.Name = "grpDriverDetails";
        grpDriverDetails.Size = new Size(1222, 497);
        grpDriverDetails.TabIndex = 0;
        grpDriverDetails.TabStop = false;
        grpDriverDetails.Text = "DRIVER REGISTRATION";
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
        tlpInputs.Location = new Point(3, 21);
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
        txtDriverId.Size = new Size(1090, 25);
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
        txtName.Size = new Size(1090, 25);
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
        txtPhoneNumber.Size = new Size(1090, 25);
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
        txtLicenseNumber.Size = new Size(1090, 25);
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
        cmbStatus.Size = new Size(1090, 25);
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
        dtpCreatedAt.Size = new Size(1090, 25);
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
        btnAdd.BackColor = Color.FromArgb(51, 51, 76);
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(1113, 3);
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
        btnUpdate.Location = new Point(1007, 3);
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
        btnDelete.Location = new Point(901, 3);
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
        btnClear.Location = new Point(795, 3);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(100, 30);
        btnClear.TabIndex = 3;
        btnClear.Text = "CLEAR";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // dgvDrivers
        // 
        dgvDrivers.AllowUserToAddRows = false;
        dgvDrivers.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
        dgvDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDrivers.BackgroundColor = Color.White;
        dgvDrivers.BorderStyle = BorderStyle.None;
        dgvDrivers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvDrivers.DefaultCellStyle = dataGridViewCellStyle2;
        dgvDrivers.Dock = DockStyle.Fill;
        dgvDrivers.EnableHeadersVisualStyles = false;
        dgvDrivers.Location = new Point(3, 526);
        dgvDrivers.MultiSelect = false;
        dgvDrivers.Name = "dgvDrivers";
        dgvDrivers.ReadOnly = true;
        dgvDrivers.RowHeadersVisible = false;
        dgvDrivers.RowTemplate.Height = 35;
        dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDrivers.Size = new Size(1242, 293);
        dgvDrivers.TabIndex = 1;
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

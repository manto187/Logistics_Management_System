namespace LogisticManagementSystem;

partial class DriverVehicleForm
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
        grpAssignmentDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtAssignmentId = new TextBox();
        lblDriver = new Label();
        cmbDriver = new ComboBox();
        lblVehicle = new Label();
        cmbVehicle = new ComboBox();
        lblAssignmentDate = new Label();
        dtpAssignmentDate = new DateTimePicker();
        lblUnassignmentDate = new Label();
        dtpUnassignmentDate = new DateTimePicker();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvAssignments = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpAssignmentDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvAssignments, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 500);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpAssignmentDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 254);
        panelInputs.TabIndex = 0;
        // 
        // grpAssignmentDetails
        // 
        this.grpAssignmentDetails.BackColor = System.Drawing.Color.White;
        this.grpAssignmentDetails.Controls.Add(this.tlpInputs);
        this.grpAssignmentDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpAssignmentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpAssignmentDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpAssignmentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpAssignmentDetails.Location = new System.Drawing.Point(10, 10);
        this.grpAssignmentDetails.Name = "grpAssignmentDetails";
        this.grpAssignmentDetails.Size = new System.Drawing.Size(774, 234);
        this.grpAssignmentDetails.TabIndex = 0;
        this.grpAssignmentDetails.TabStop = false;
        this.grpAssignmentDetails.Text = "DRIVER-VEHICLE ASSIGNMENT";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtAssignmentId, 1, 0);
        tlpInputs.Controls.Add(lblDriver, 0, 1);
        tlpInputs.Controls.Add(cmbDriver, 1, 1);
        tlpInputs.Controls.Add(lblVehicle, 0, 2);
        tlpInputs.Controls.Add(cmbVehicle, 1, 2);
        tlpInputs.Controls.Add(lblAssignmentDate, 0, 3);
        tlpInputs.Controls.Add(dtpAssignmentDate, 1, 3);
        tlpInputs.Controls.Add(lblUnassignmentDate, 0, 4);
        tlpInputs.Controls.Add(dtpUnassignmentDate, 1, 4);
        tlpInputs.Dock = DockStyle.Top;
        tlpInputs.Location = new Point(3, 19);
        tlpInputs.Name = "tlpInputs";
        tlpInputs.RowCount = 5;
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.Size = new Size(768, 150);
        tlpInputs.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.Anchor = AnchorStyles.Left;
        lblId.Location = new Point(3, 3);
        lblId.Name = "lblId";
        lblId.Size = new Size(100, 23);
        lblId.TabIndex = 0;
        lblId.Text = "Assignment ID:";
        // 
        // txtAssignmentId
        // 
        this.txtAssignmentId.BackColor = System.Drawing.SystemColors.ControlLight;
        this.txtAssignmentId.Dock = System.Windows.Forms.DockStyle.Fill;
        this.txtAssignmentId.Location = new System.Drawing.Point(153, 3);
        this.txtAssignmentId.Name = "txtAssignmentId";
        this.txtAssignmentId.ReadOnly = true;
        this.txtAssignmentId.Size = new System.Drawing.Size(612, 23);
        this.txtAssignmentId.TabIndex = 1;

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
        this.cmbDriver.Dock = System.Windows.Forms.DockStyle.Fill;
        this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbDriver.FormattingEnabled = true;
        this.cmbDriver.Location = new System.Drawing.Point(153, 33);
        this.cmbDriver.Name = "cmbDriver";
        this.cmbDriver.Size = new Size(612, 23);
        this.cmbDriver.TabIndex = 3;

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
        this.cmbVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbVehicle.FormattingEnabled = true;
        this.cmbVehicle.Location = new System.Drawing.Point(153, 63);
        this.cmbVehicle.Name = "cmbVehicle";
        this.cmbVehicle.Size = new Size(612, 23);
        this.cmbVehicle.TabIndex = 5;
        this.cmbVehicle.SelectedIndexChanged += new System.EventHandler(this.cmbVehicle_SelectedIndexChanged);

        // 
        // lblAssignmentDate
        // 
        lblAssignmentDate.Anchor = AnchorStyles.Left;
        lblAssignmentDate.Location = new Point(3, 93);
        lblAssignmentDate.Name = "lblAssignmentDate";
        lblAssignmentDate.Size = new Size(140, 23);
        lblAssignmentDate.TabIndex = 6;
        lblAssignmentDate.Text = "Assignment Date:";
        // 
        // dtpAssignmentDate
        // 
        dtpAssignmentDate.Dock = DockStyle.Fill;
        dtpAssignmentDate.Location = new Point(153, 93);
        dtpAssignmentDate.Name = "dtpAssignmentDate";
        dtpAssignmentDate.Size = new Size(612, 23);
        dtpAssignmentDate.TabIndex = 7;
        // 
        // lblUnassignmentDate
        // 
        lblUnassignmentDate.Anchor = AnchorStyles.Left;
        lblUnassignmentDate.Location = new Point(3, 123);
        lblUnassignmentDate.Name = "lblUnassignmentDate";
        lblUnassignmentDate.Size = new Size(140, 23);
        lblUnassignmentDate.TabIndex = 8;
        lblUnassignmentDate.Text = "Unassignment Date:";
        // 
        // dtpUnassignmentDate
        // 
        dtpUnassignmentDate.Checked = false;
        dtpUnassignmentDate.Dock = DockStyle.Fill;
        dtpUnassignmentDate.Location = new Point(153, 123);
        dtpUnassignmentDate.Name = "dtpUnassignmentDate";
        dtpUnassignmentDate.ShowCheckBox = true;
        dtpUnassignmentDate.Size = new Size(612, 23);
        dtpUnassignmentDate.TabIndex = 9;
        // 
        // flowLayoutPanelButtons
        // 
        flowLayoutPanelButtons.Controls.Add(btnAdd);
        flowLayoutPanelButtons.Controls.Add(btnUpdate);
        flowLayoutPanelButtons.Controls.Add(btnDelete);
        flowLayoutPanelButtons.Controls.Add(btnClear);
        flowLayoutPanelButtons.Dock = DockStyle.Bottom;
        flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanelButtons.Location = new Point(3, 191);
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
        this.btnAdd.Text = "ASSIGN";
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
        // dgvAssignments
        // 
        this.dgvAssignments.AllowUserToAddRows = false;
        this.dgvAssignments.AllowUserToDeleteRows = false;
        this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
        this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvAssignments.EnableHeadersVisualStyles = false;
        this.dgvAssignments.Location = new System.Drawing.Point(3, 263);
        this.dgvAssignments.MultiSelect = false;
        this.dgvAssignments.Name = "dgvAssignments";
        this.dgvAssignments.ReadOnly = true;
        this.dgvAssignments.RowHeadersVisible = false;
        this.dgvAssignments.RowTemplate.Height = 35;
        this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvAssignments.Size = new Size(794, 234);
        this.dgvAssignments.TabIndex = 1;
        this.dgvAssignments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvAssignments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvAssignments.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // DriverVehicleForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Controls.Add(this.layoutPanelMain);
        this.Name = "DriverVehicleForm";
        this.Text = "Driver-Vehicle Assignment Management";

        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpAssignmentDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpAssignmentDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;

    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtAssignmentId;

    private System.Windows.Forms.Label lblDriver;
    private System.Windows.Forms.ComboBox cmbDriver;

    private System.Windows.Forms.Label lblVehicle;
    private System.Windows.Forms.ComboBox cmbVehicle;

    private System.Windows.Forms.Label lblAssignmentDate;
    private System.Windows.Forms.DateTimePicker dtpAssignmentDate;

    private System.Windows.Forms.Label lblUnassignmentDate;
    private System.Windows.Forms.DateTimePicker dtpUnassignmentDate;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvAssignments;
}

namespace LogisticManagementSystem;

partial class WarehouseForm
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
        grpWarehouseDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtWarehouseId = new TextBox();
        lblName = new Label();
        txtWarehouseName = new TextBox();
        lblLocation = new Label();
        txtLocation = new TextBox();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvWarehouses = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpWarehouseDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvWarehouses).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvWarehouses, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 450);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpWarehouseDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 174);
        panelInputs.TabIndex = 0;
        // 
        // grpWarehouseDetails
        // 
        this.grpWarehouseDetails.BackColor = System.Drawing.Color.White;
        this.grpWarehouseDetails.Controls.Add(this.tlpInputs);
        this.grpWarehouseDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpWarehouseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpWarehouseDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpWarehouseDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpWarehouseDetails.Location = new System.Drawing.Point(10, 10);
        this.grpWarehouseDetails.Name = "grpWarehouseDetails";
        this.grpWarehouseDetails.Size = new System.Drawing.Size(774, 154);
        this.grpWarehouseDetails.TabIndex = 0;
        this.grpWarehouseDetails.TabStop = false;
        this.grpWarehouseDetails.Text = "WAREHOUSE REGISTRATION";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtWarehouseId, 1, 0);
        tlpInputs.Controls.Add(lblName, 0, 1);
        tlpInputs.Controls.Add(txtWarehouseName, 1, 1);
        tlpInputs.Controls.Add(lblLocation, 0, 2);
        tlpInputs.Controls.Add(txtLocation, 1, 2);
        tlpInputs.Dock = DockStyle.Top;
        tlpInputs.Location = new Point(3, 19);
        tlpInputs.Name = "tlpInputs";
        tlpInputs.RowCount = 3;
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.Size = new Size(768, 90);
        tlpInputs.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.Anchor = AnchorStyles.Left;
        lblId.Location = new Point(3, 3);
        lblId.Name = "lblId";
        lblId.Size = new Size(100, 23);
        lblId.TabIndex = 0;
        lblId.Text = "Warehouse ID:";
        // 
        // txtWarehouseId
        // 
        txtWarehouseId.BackColor = SystemColors.ControlLight;
        txtWarehouseId.Dock = DockStyle.Fill;
        txtWarehouseId.Location = new Point(123, 3);
        txtWarehouseId.Name = "txtWarehouseId";
        txtWarehouseId.ReadOnly = true;
        txtWarehouseId.Size = new Size(642, 23);
        txtWarehouseId.TabIndex = 1;
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.Left;
        lblName.Location = new Point(3, 33);
        lblName.Name = "lblName";
        lblName.Size = new Size(100, 23);
        lblName.TabIndex = 2;
        lblName.Text = "Warehouse Name:";
        // 
        // txtWarehouseName
        // 
        txtWarehouseName.Dock = DockStyle.Fill;
        txtWarehouseName.Location = new Point(123, 33);
        txtWarehouseName.Name = "txtWarehouseName";
        txtWarehouseName.Size = new Size(642, 23);
        txtWarehouseName.TabIndex = 3;
        // 
        // lblLocation
        // 
        lblLocation.Anchor = AnchorStyles.Left;
        lblLocation.Location = new Point(3, 63);
        lblLocation.Name = "lblLocation";
        lblLocation.Size = new Size(100, 23);
        lblLocation.TabIndex = 4;
        lblLocation.Text = "Location:";
        // 
        // txtLocation
        // 
        txtLocation.Dock = DockStyle.Fill;
        txtLocation.Location = new Point(123, 63);
        txtLocation.Name = "txtLocation";
        txtLocation.Size = new Size(642, 23);
        txtLocation.TabIndex = 5;
        // 
        // flowLayoutPanelButtons
        // 
        flowLayoutPanelButtons.Controls.Add(btnAdd);
        flowLayoutPanelButtons.Controls.Add(btnUpdate);
        flowLayoutPanelButtons.Controls.Add(btnDelete);
        flowLayoutPanelButtons.Controls.Add(btnClear);
        flowLayoutPanelButtons.Dock = DockStyle.Bottom;
        flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanelButtons.Location = new Point(3, 111);
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
        // dgvWarehouses
        // 
        this.dgvWarehouses.AllowUserToAddRows = false;
        this.dgvWarehouses.AllowUserToDeleteRows = false;
        this.dgvWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvWarehouses.BackgroundColor = System.Drawing.Color.White;
        this.dgvWarehouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvWarehouses.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvWarehouses.EnableHeadersVisualStyles = false;
        this.dgvWarehouses.Location = new System.Drawing.Point(3, 183);
        this.dgvWarehouses.MultiSelect = false;
        this.dgvWarehouses.Name = "dgvWarehouses";
        this.dgvWarehouses.ReadOnly = true;
        this.dgvWarehouses.RowHeadersVisible = false;
        this.dgvWarehouses.RowTemplate.Height = 35;
        this.dgvWarehouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvWarehouses.Size = new Size(794, 264);
        this.dgvWarehouses.TabIndex = 1;
        this.dgvWarehouses.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvWarehouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvWarehouses.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvWarehouses.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // WarehouseForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(layoutPanelMain);
        Name = "WarehouseForm";
        Text = "Warehouse Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpWarehouseDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvWarehouses).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpWarehouseDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtWarehouseId;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtWarehouseName;
    private System.Windows.Forms.Label lblLocation;
    private System.Windows.Forms.TextBox txtLocation;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvWarehouses;
}

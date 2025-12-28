namespace LogisticManagementSystem;

partial class InventoryForm
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
        grpInventoryDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtInventoryId = new TextBox();
        lblWarehouse = new Label();
        cmbWarehouse = new ComboBox();
        lblItemName = new Label();
        txtItemName = new TextBox();
        lblQuantity = new Label();
        numQuantity = new NumericUpDown();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvInventory = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpInventoryDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvInventory, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 500);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpInventoryDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 214);
        panelInputs.TabIndex = 0;
        // 
        //
        // grpInventoryDetails
        //
        this.grpInventoryDetails.BackColor = System.Drawing.Color.White;
        this.grpInventoryDetails.Controls.Add(this.tlpInputs);
        this.grpInventoryDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpInventoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpInventoryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpInventoryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpInventoryDetails.Location = new System.Drawing.Point(10, 10);
        this.grpInventoryDetails.Name = "grpInventoryDetails";
        this.grpInventoryDetails.Size = new System.Drawing.Size(774, 194);
        this.grpInventoryDetails.TabIndex = 0;
        this.grpInventoryDetails.TabStop = false;
        this.grpInventoryDetails.Text = "INVENTORY MANAGEMENT";
        //
        // tlpInputs
        //
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtInventoryId, 1, 0);
        tlpInputs.Controls.Add(lblWarehouse, 0, 1);
        tlpInputs.Controls.Add(cmbWarehouse, 1, 1);
        tlpInputs.Controls.Add(lblItemName, 0, 2);
        tlpInputs.Controls.Add(txtItemName, 1, 2);
        tlpInputs.Controls.Add(lblQuantity, 0, 3);
        tlpInputs.Controls.Add(numQuantity, 1, 3);
        tlpInputs.Dock = DockStyle.Top;
        tlpInputs.Location = new Point(3, 19);
        tlpInputs.Name = "tlpInputs";
        tlpInputs.RowCount = 4;
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpInputs.Size = new Size(768, 120);
        tlpInputs.TabIndex = 0;
        //
        // lblId
        //
        lblId.Anchor = AnchorStyles.Left;
        lblId.Location = new Point(3, 3);
        lblId.Name = "lblId";
        lblId.Size = new Size(100, 23);
        lblId.TabIndex = 0;
        lblId.Text = "Inventory ID:";
        //
        // txtInventoryId
        //
        txtInventoryId.BackColor = SystemColors.ControlLight;
        txtInventoryId.Dock = DockStyle.Fill;
        txtInventoryId.Location = new Point(123, 3);
        txtInventoryId.Name = "txtInventoryId";
        txtInventoryId.ReadOnly = true;
        txtInventoryId.Size = new Size(642, 23);
        txtInventoryId.TabIndex = 1;
        //
        // lblWarehouse
        //
        lblWarehouse.Anchor = AnchorStyles.Left;
        lblWarehouse.Location = new Point(3, 33);
        lblWarehouse.Name = "lblWarehouse";
        lblWarehouse.Size = new Size(100, 23);
        lblWarehouse.TabIndex = 2;
        lblWarehouse.Text = "Warehouse:";
        //
        // cmbWarehouse
        //
        cmbWarehouse.Dock = DockStyle.Fill;
        cmbWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbWarehouse.FormattingEnabled = true;
        cmbWarehouse.Location = new Point(123, 33);
        cmbWarehouse.Name = "cmbWarehouse";
        cmbWarehouse.Size = new Size(642, 23);
        cmbWarehouse.TabIndex = 3;
        //
        // lblItemName
        //
        lblItemName.Anchor = AnchorStyles.Left;
        lblItemName.Location = new Point(3, 63);
        lblItemName.Name = "lblItemName";
        lblItemName.Size = new Size(100, 23);
        lblItemName.TabIndex = 4;
        lblItemName.Text = "Item Name:";
        //
        // txtItemName
        //
        txtItemName.Dock = DockStyle.Fill;
        txtItemName.Location = new Point(123, 63);
        txtItemName.Name = "txtItemName";
        txtItemName.Size = new Size(642, 23);
        txtItemName.TabIndex = 5;
        //
        // lblQuantity
        //
        lblQuantity.Anchor = AnchorStyles.Left;
        lblQuantity.Location = new Point(3, 93);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(100, 23);
        lblQuantity.TabIndex = 6;
        lblQuantity.Text = "Quantity:";
        //
        // numQuantity
        //
        numQuantity.Dock = DockStyle.Fill;
        numQuantity.Location = new Point(123, 93);
        numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numQuantity.Name = "numQuantity";
        numQuantity.Size = new Size(642, 23);
        numQuantity.TabIndex = 7;
        //
        // flowLayoutPanelButtons
        //
        flowLayoutPanelButtons.Controls.Add(btnAdd);
        flowLayoutPanelButtons.Controls.Add(btnUpdate);
        flowLayoutPanelButtons.Controls.Add(btnDelete);
        flowLayoutPanelButtons.Controls.Add(btnClear);
        flowLayoutPanelButtons.Dock = DockStyle.Bottom;
        flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanelButtons.Location = new Point(3, 151);
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
        this.btnClear.Size = new Size(100, 30);
        this.btnClear.TabIndex = 3;
        this.btnClear.Text = "CLEAR";
        this.btnClear.UseVisualStyleBackColor = false;
        //
        // dgvInventory
        //
        this.dgvInventory.AllowUserToAddRows = false;
        this.dgvInventory.AllowUserToDeleteRows = false;
        this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
        this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvInventory.EnableHeadersVisualStyles = false;
        this.dgvInventory.Location = new System.Drawing.Point(3, 223);
        this.dgvInventory.MultiSelect = false;
        this.dgvInventory.Name = "dgvInventory";
        this.dgvInventory.ReadOnly = true;
        this.dgvInventory.RowHeadersVisible = false;
        this.dgvInventory.RowTemplate.Height = 35;
        this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvInventory.Size = new Size(794, 274);
        this.dgvInventory.TabIndex = 1;
        this.dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvInventory.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvInventory.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        //
        // InventoryForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 500);
        Controls.Add(layoutPanelMain);
        Name = "InventoryForm";
        Text = "Inventory Management System";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpInventoryDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpInventoryDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtInventoryId;
    
    private System.Windows.Forms.Label lblWarehouse;
    private System.Windows.Forms.ComboBox cmbWarehouse;
    
    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.TextBox txtItemName;
    
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.NumericUpDown numQuantity;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvInventory;
}

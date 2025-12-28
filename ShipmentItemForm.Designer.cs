namespace LogisticManagementSystem;

partial class ShipmentItemForm
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
        grpItemDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtShipItemId = new TextBox();
        lblShipment = new Label();
        cmbShipment = new ComboBox();
        lblInventory = new Label();
        cmbInventory = new ComboBox();
        lblQuantity = new Label();
        numQuantity = new NumericUpDown();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvShipmentItems = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpItemDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvShipmentItems, 0, 1);
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
        panelInputs.Controls.Add(grpItemDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 214);
        panelInputs.TabIndex = 0;
        // 
        // grpItemDetails
        // 
        this.grpItemDetails.BackColor = System.Drawing.Color.White;
        this.grpItemDetails.Controls.Add(this.tlpInputs);
        this.grpItemDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpItemDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpItemDetails.Location = new System.Drawing.Point(10, 10);
        this.grpItemDetails.Name = "grpItemDetails";
        this.grpItemDetails.Size = new Size(774, 194);
        this.grpItemDetails.TabIndex = 0;
        this.grpItemDetails.TabStop = false;
        this.grpItemDetails.Text = "SHIPMENT ITEM DETAILS";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtShipItemId, 1, 0);
        tlpInputs.Controls.Add(lblShipment, 0, 1);
        tlpInputs.Controls.Add(cmbShipment, 1, 1);
        tlpInputs.Controls.Add(lblInventory, 0, 2);
        tlpInputs.Controls.Add(cmbInventory, 1, 2);
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
        lblId.Text = "Item ID:";
        // 
        // txtShipItemId
        // 
        txtShipItemId.BackColor = SystemColors.ControlLight;
        txtShipItemId.Dock = DockStyle.Fill;
        txtShipItemId.Location = new Point(123, 3);
        txtShipItemId.Name = "txtShipItemId";
        txtShipItemId.ReadOnly = true;
        txtShipItemId.Size = new Size(642, 23);
        txtShipItemId.TabIndex = 1;
        // 
        // lblShipment
        // 
        lblShipment.Anchor = AnchorStyles.Left;
        lblShipment.Location = new Point(3, 33);
        lblShipment.Name = "lblShipment";
        lblShipment.Size = new Size(100, 23);
        lblShipment.TabIndex = 2;
        lblShipment.Text = "Shipment:";
        // 
        // cmbShipment
        // 
        cmbShipment.Dock = DockStyle.Fill;
        cmbShipment.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbShipment.FormattingEnabled = true;
        cmbShipment.Location = new Point(123, 33);
        cmbShipment.Name = "cmbShipment";
        cmbShipment.Size = new Size(642, 23);
        cmbShipment.TabIndex = 3;
        // 
        // lblInventory
        // 
        lblInventory.Anchor = AnchorStyles.Left;
        lblInventory.Location = new Point(3, 63);
        lblInventory.Name = "lblInventory";
        lblInventory.Size = new Size(100, 23);
        lblInventory.TabIndex = 4;
        lblInventory.Text = "Inventory Item:";
        // 
        // cmbInventory
        // 
        cmbInventory.Dock = DockStyle.Fill;
        cmbInventory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbInventory.FormattingEnabled = true;
        cmbInventory.Location = new Point(123, 63);
        cmbInventory.Name = "cmbInventory";
        cmbInventory.Size = new Size(642, 23);
        cmbInventory.TabIndex = 5;
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
        flowLayoutPanelButtons.Location = new Point(3, 171);
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
        this.btnUpdate.Size = new Size(100, 30);
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
        this.btnDelete.Size = new Size(100, 30);
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
        // dgvShipmentItems
        // 
        this.dgvShipmentItems.AllowUserToAddRows = false;
        this.dgvShipmentItems.AllowUserToDeleteRows = false;
        this.dgvShipmentItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvShipmentItems.BackgroundColor = System.Drawing.Color.White;
        this.dgvShipmentItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvShipmentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvShipmentItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvShipmentItems.EnableHeadersVisualStyles = false;
        this.dgvShipmentItems.Location = new System.Drawing.Point(3, 223);
        this.dgvShipmentItems.MultiSelect = false;
        this.dgvShipmentItems.Name = "dgvShipmentItems";
        this.dgvShipmentItems.ReadOnly = true;
        this.dgvShipmentItems.RowHeadersVisible = false;
        this.dgvShipmentItems.RowTemplate.Height = 35;
        this.dgvShipmentItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvShipmentItems.Size = new Size(794, 274);
        this.dgvShipmentItems.TabIndex = 1;
        this.dgvShipmentItems.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvShipmentItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvShipmentItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvShipmentItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // ShipmentItemForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 500);
        Controls.Add(layoutPanelMain);
        Name = "ShipmentItemForm";
        Text = "Shipment Items Management";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpItemDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpItemDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtShipItemId;
    
    private System.Windows.Forms.Label lblShipment;
    private System.Windows.Forms.ComboBox cmbShipment;
    
    private System.Windows.Forms.Label lblInventory;
    private System.Windows.Forms.ComboBox cmbInventory;
    
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.NumericUpDown numQuantity;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvShipmentItems;
}

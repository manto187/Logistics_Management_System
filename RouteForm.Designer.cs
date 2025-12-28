namespace LogisticManagementSystem;

partial class RouteForm
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
        grpRouteDetails = new GroupBox();
        tlpInputs = new TableLayoutPanel();
        lblId = new Label();
        txtRouteId = new TextBox();
        lblStartLocation = new Label();
        txtStartLocation = new TextBox();
        lblEndLocation = new Label();
        txtEndLocation = new TextBox();
        lblDistance = new Label();
        numDistance = new NumericUpDown();
        flowLayoutPanelButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvRoutes = new DataGridView();
        layoutPanelMain.SuspendLayout();
        panelInputs.SuspendLayout();
        grpRouteDetails.SuspendLayout();
        tlpInputs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
        flowLayoutPanelButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRoutes).BeginInit();
        SuspendLayout();
        // 
        // layoutPanelMain
        // 
        layoutPanelMain.ColumnCount = 1;
        layoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutPanelMain.Controls.Add(panelInputs, 0, 0);
        layoutPanelMain.Controls.Add(dgvRoutes, 0, 1);
        layoutPanelMain.Dock = DockStyle.Fill;
        layoutPanelMain.Location = new Point(0, 0);
        layoutPanelMain.Name = "layoutPanelMain";
        layoutPanelMain.RowCount = 2;
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
        layoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutPanelMain.Size = new Size(800, 450);
        layoutPanelMain.TabIndex = 0;
        // 
        // panelInputs
        // 
        panelInputs.Controls.Add(grpRouteDetails);
        panelInputs.Dock = DockStyle.Fill;
        panelInputs.Location = new Point(3, 3);
        panelInputs.Name = "panelInputs";
        panelInputs.Padding = new Padding(10);
        panelInputs.Size = new Size(794, 214);
        panelInputs.TabIndex = 0;
        // 
        // grpRouteDetails
        // 
        this.grpRouteDetails.BackColor = System.Drawing.Color.White;
        this.grpRouteDetails.Controls.Add(this.tlpInputs);
        this.grpRouteDetails.Controls.Add(this.flowLayoutPanelButtons);
        this.grpRouteDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpRouteDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.grpRouteDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpRouteDetails.Location = new System.Drawing.Point(10, 10);
        this.grpRouteDetails.Name = "grpRouteDetails";
        this.grpRouteDetails.Size = new System.Drawing.Size(774, 194);
        this.grpRouteDetails.TabIndex = 0;
        this.grpRouteDetails.TabStop = false;
        this.grpRouteDetails.Text = "ROUTE PLANNING";

        // 
        // tlpInputs
        // 
        tlpInputs.ColumnCount = 2;
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpInputs.Controls.Add(lblId, 0, 0);
        tlpInputs.Controls.Add(txtRouteId, 1, 0);
        tlpInputs.Controls.Add(lblStartLocation, 0, 1);
        tlpInputs.Controls.Add(txtStartLocation, 1, 1);
        tlpInputs.Controls.Add(lblEndLocation, 0, 2);
        tlpInputs.Controls.Add(txtEndLocation, 1, 2);
        tlpInputs.Controls.Add(lblDistance, 0, 3);
        tlpInputs.Controls.Add(numDistance, 1, 3);
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
        lblId.Text = "Route ID:";
        // 
        // txtRouteId
        // 
        txtRouteId.BackColor = SystemColors.ControlLight;
        txtRouteId.Dock = DockStyle.Fill;
        txtRouteId.Location = new Point(123, 3);
        txtRouteId.Name = "txtRouteId";
        txtRouteId.ReadOnly = true;
        txtRouteId.Size = new Size(642, 23);
        txtRouteId.TabIndex = 1;
        // 
        // lblStartLocation
        // 
        lblStartLocation.Anchor = AnchorStyles.Left;
        lblStartLocation.Location = new Point(3, 33);
        lblStartLocation.Name = "lblStartLocation";
        lblStartLocation.Size = new Size(100, 23);
        lblStartLocation.TabIndex = 2;
        lblStartLocation.Text = "Start Location:";
        // 
        // txtStartLocation
        // 
        txtStartLocation.Dock = DockStyle.Fill;
        txtStartLocation.Location = new Point(123, 33);
        txtStartLocation.Name = "txtStartLocation";
        txtStartLocation.Size = new Size(642, 23);
        txtStartLocation.TabIndex = 3;
        // 
        // lblEndLocation
        // 
        lblEndLocation.Anchor = AnchorStyles.Left;
        lblEndLocation.Location = new Point(3, 63);
        lblEndLocation.Name = "lblEndLocation";
        lblEndLocation.Size = new Size(100, 23);
        lblEndLocation.TabIndex = 4;
        lblEndLocation.Text = "End Location:";
        // 
        // txtEndLocation
        // 
        txtEndLocation.Dock = DockStyle.Fill;
        txtEndLocation.Location = new Point(123, 63);
        txtEndLocation.Name = "txtEndLocation";
        txtEndLocation.Size = new Size(642, 23);
        txtEndLocation.TabIndex = 5;
        // 
        // lblDistance
        // 
        lblDistance.Anchor = AnchorStyles.Left;
        lblDistance.Location = new Point(3, 93);
        lblDistance.Name = "lblDistance";
        lblDistance.Size = new Size(100, 23);
        lblDistance.TabIndex = 6;
        lblDistance.Text = "Distance (km):";
        // 
        // numDistance
        // 
        numDistance.Dock = DockStyle.Fill;
        numDistance.Location = new Point(123, 93);
        numDistance.DecimalPlaces = 2;
        numDistance.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numDistance.Name = "numDistance";
        numDistance.Size = new Size(642, 23);
        numDistance.TabIndex = 7;
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
        this.btnClear.Location = new Point(347, 3);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(100, 30);
        this.btnClear.TabIndex = 3;
        this.btnClear.Text = "CLEAR";
        this.btnClear.UseVisualStyleBackColor = false;

        // 
        // dgvRoutes
        // 
        this.dgvRoutes.AllowUserToAddRows = false;
        this.dgvRoutes.AllowUserToDeleteRows = false;
        this.dgvRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvRoutes.BackgroundColor = System.Drawing.Color.White;
        this.dgvRoutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvRoutes.EnableHeadersVisualStyles = false;
        this.dgvRoutes.Location = new System.Drawing.Point(3, 223);
        this.dgvRoutes.MultiSelect = false;
        this.dgvRoutes.Name = "dgvRoutes";
        this.dgvRoutes.ReadOnly = true;
        this.dgvRoutes.RowHeadersVisible = false;
        this.dgvRoutes.RowTemplate.Height = 35;
        this.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRoutes.Size = new Size(794, 224);
        this.dgvRoutes.TabIndex = 1;
        this.dgvRoutes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        this.dgvRoutes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvRoutes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        this.dgvRoutes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        // 
        // RouteForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(layoutPanelMain);
        Name = "RouteForm";
        Text = "Route Management";
        layoutPanelMain.ResumeLayout(false);
        panelInputs.ResumeLayout(false);
        grpRouteDetails.ResumeLayout(false);
        tlpInputs.ResumeLayout(false);
        tlpInputs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
        flowLayoutPanelButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRoutes).EndInit();
        ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.TableLayoutPanel layoutPanelMain;
    private System.Windows.Forms.Panel panelInputs;
    private System.Windows.Forms.GroupBox grpRouteDetails;
    private System.Windows.Forms.TableLayoutPanel tlpInputs;
    
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtRouteId;
    private System.Windows.Forms.Label lblStartLocation;
    private System.Windows.Forms.TextBox txtStartLocation;
    private System.Windows.Forms.Label lblEndLocation;
    private System.Windows.Forms.TextBox txtEndLocation;
    private System.Windows.Forms.Label lblDistance;
    private System.Windows.Forms.NumericUpDown numDistance;
    
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvRoutes;
}

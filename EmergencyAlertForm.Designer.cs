namespace LogisticManagementSystem;

partial class EmergencyAlertForm
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
        this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
        this.grpActiveTrips = new System.Windows.Forms.GroupBox();
        this.dgvActiveTrips = new System.Windows.Forms.DataGridView();
        this.grpAvailableDrivers = new System.Windows.Forms.GroupBox();
        this.dgvAvailableDrivers = new System.Windows.Forms.DataGridView();
        this.panelControls = new System.Windows.Forms.Panel();
        this.lblReason = new System.Windows.Forms.Label();
        this.txtReason = new System.Windows.Forms.TextBox();
        this.btnReassign = new System.Windows.Forms.Button();
        this.btnSearchDrivers = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();

        this.layoutMain.SuspendLayout();
        this.grpActiveTrips.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTrips)).BeginInit();
        this.grpAvailableDrivers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDrivers)).BeginInit();
        this.panelControls.SuspendLayout();
        this.SuspendLayout();

        // layoutMain
        this.layoutMain.ColumnCount = 1;
        this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.layoutMain.Controls.Add(this.lblTitle, 0, 0);
        this.layoutMain.Controls.Add(this.grpActiveTrips, 0, 1);
        this.layoutMain.Controls.Add(this.grpAvailableDrivers, 0, 2);
        this.layoutMain.Controls.Add(this.panelControls, 0, 3);
        this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layoutMain.Location = new System.Drawing.Point(0, 0);
        this.layoutMain.Name = "layoutMain";
        this.layoutMain.RowCount = 4;
        this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        this.layoutMain.Size = new System.Drawing.Size(900, 600);
        this.layoutMain.TabIndex = 0;

        // lblTitle
        this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(900, 50);
        this.lblTitle.TabIndex = 4;
        this.lblTitle.Text = "EMERGENCY SHIPMENT REASSIGNMENT";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpActiveTrips
        this.grpActiveTrips.Controls.Add(this.dgvActiveTrips);
        this.grpActiveTrips.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpActiveTrips.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpActiveTrips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpActiveTrips.Location = new System.Drawing.Point(10, 60);
        this.grpActiveTrips.Margin = new System.Windows.Forms.Padding(10);
        this.grpActiveTrips.Name = "grpActiveTrips";
        this.grpActiveTrips.Size = new System.Drawing.Size(880, 160);
        this.grpActiveTrips.TabIndex = 0;
        this.grpActiveTrips.TabStop = false;
        this.grpActiveTrips.Text = "Step 1: Select Active Trip (Emergency Occurred)";

        // dgvActiveTrips
        this.dgvActiveTrips.AllowUserToAddRows = false;
        this.dgvActiveTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvActiveTrips.BackgroundColor = System.Drawing.Color.White;
        this.dgvActiveTrips.ColumnHeadersHeight = 30;
        this.dgvActiveTrips.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvActiveTrips.Location = new System.Drawing.Point(3, 21);
        this.dgvActiveTrips.MultiSelect = false;
        this.dgvActiveTrips.Name = "dgvActiveTrips";
        this.dgvActiveTrips.ReadOnly = true;
        this.dgvActiveTrips.RowHeadersVisible = false;
        this.dgvActiveTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvActiveTrips.Size = new System.Drawing.Size(874, 136);
        this.dgvActiveTrips.TabIndex = 0;

        // grpAvailableDrivers
        this.grpAvailableDrivers.Controls.Add(this.dgvAvailableDrivers);
        this.grpAvailableDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpAvailableDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpAvailableDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.grpAvailableDrivers.Location = new System.Drawing.Point(10, 240);
        this.grpAvailableDrivers.Margin = new System.Windows.Forms.Padding(10);
        this.grpAvailableDrivers.Name = "grpAvailableDrivers";
        this.grpAvailableDrivers.Size = new System.Drawing.Size(880, 160);
        this.grpAvailableDrivers.TabIndex = 1;
        this.grpAvailableDrivers.TabStop = false;
        this.grpAvailableDrivers.Text = "Step 2: Select Replacement Driver && Vehicle";

        // dgvAvailableDrivers
        this.dgvAvailableDrivers.AllowUserToAddRows = false;
        this.dgvAvailableDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvAvailableDrivers.BackgroundColor = System.Drawing.Color.White;
        this.dgvAvailableDrivers.ColumnHeadersHeight = 30;
        this.dgvAvailableDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvAvailableDrivers.Location = new System.Drawing.Point(3, 21);
        this.dgvAvailableDrivers.MultiSelect = false;
        this.dgvAvailableDrivers.Name = "dgvAvailableDrivers";
        this.dgvAvailableDrivers.ReadOnly = true;
        this.dgvAvailableDrivers.RowHeadersVisible = false;
        this.dgvAvailableDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvAvailableDrivers.Size = new System.Drawing.Size(874, 136);
        this.dgvAvailableDrivers.TabIndex = 0;

        // panelControls
        this.panelControls.BackColor = System.Drawing.Color.White;
        this.panelControls.Controls.Add(this.lblReason);
        this.panelControls.Controls.Add(this.txtReason);
        this.panelControls.Controls.Add(this.btnReassign);
        this.panelControls.Controls.Add(this.btnSearchDrivers);
        this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelControls.Location = new System.Drawing.Point(3, 503);
        this.panelControls.Name = "panelControls";
        this.panelControls.Padding = new System.Windows.Forms.Padding(10);
        this.panelControls.Size = new System.Drawing.Size(894, 94);
        this.panelControls.TabIndex = 2;

        // lblReason
        this.lblReason.AutoSize = true;
        this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblReason.Location = new System.Drawing.Point(13, 10);
        this.lblReason.Name = "lblReason";
        this.lblReason.Size = new System.Drawing.Size(109, 15);
        this.lblReason.TabIndex = 0;
        this.lblReason.Text = "Emergency Reason:";

        // txtReason
        this.txtReason.Location = new System.Drawing.Point(13, 28);
        this.txtReason.Multiline = true;
        this.txtReason.Name = "txtReason";
        this.txtReason.Size = new System.Drawing.Size(500, 50);
        this.txtReason.TabIndex = 1;

        // btnReassign
        this.btnReassign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
        this.btnReassign.FlatAppearance.BorderSize = 0;
        this.btnReassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReassign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnReassign.ForeColor = System.Drawing.Color.White;
        this.btnReassign.Location = new System.Drawing.Point(700, 28);
        this.btnReassign.Name = "btnReassign";
        this.btnReassign.Size = new System.Drawing.Size(180, 50);
        this.btnReassign.TabIndex = 3;
        this.btnReassign.Text = "REASSIGN INSTANTLY";
        this.btnReassign.UseVisualStyleBackColor = false;

        // btnSearchDrivers
        this.btnSearchDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.btnSearchDrivers.FlatAppearance.BorderSize = 0;
        this.btnSearchDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSearchDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnSearchDrivers.ForeColor = System.Drawing.Color.White;
        this.btnSearchDrivers.Location = new System.Drawing.Point(530, 28);
        this.btnSearchDrivers.Name = "btnSearchDrivers";
        this.btnSearchDrivers.Size = new System.Drawing.Size(160, 50);
        this.btnSearchDrivers.TabIndex = 2;
        this.btnSearchDrivers.Text = "SEARCH AVAILABLE";
        this.btnSearchDrivers.UseVisualStyleBackColor = false;

        // EmergencyAlertForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 600);
        this.Controls.Add(this.layoutMain);
        this.Name = "EmergencyAlertForm";
        this.Text = "Emergency Shipment Recovery";
        this.layoutMain.ResumeLayout(false);
        this.grpActiveTrips.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTrips)).EndInit();
        this.grpAvailableDrivers.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDrivers)).EndInit();
        this.panelControls.ResumeLayout(false);
        this.panelControls.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutMain;
    private System.Windows.Forms.GroupBox grpActiveTrips;
    private System.Windows.Forms.DataGridView dgvActiveTrips;
    private System.Windows.Forms.GroupBox grpAvailableDrivers;
    private System.Windows.Forms.DataGridView dgvAvailableDrivers;
    private System.Windows.Forms.Panel panelControls;
    private System.Windows.Forms.Label lblReason;
    private System.Windows.Forms.TextBox txtReason;
    private System.Windows.Forms.Button btnReassign;
    private System.Windows.Forms.Button btnSearchDrivers;
    private System.Windows.Forms.Label lblTitle;
}

namespace LogisticManagementSystem;

partial class SignupForm
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
        lblFullName = new Label();
        txtFullName = new TextBox();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnRegister = new Button();
        btnBackToLogin = new Button();
        panelHeader = new Panel();
        lblTitle = new Label();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblFullName.Location = new Point(40, 80);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new Size(73, 19);
        lblFullName.TabIndex = 0;
        lblFullName.Text = "Full Name:";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtFullName.Location = new Point(40, 105);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(320, 25);
        txtFullName.TabIndex = 1;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblUsername.Location = new Point(40, 145);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(74, 19);
        lblUsername.TabIndex = 2;
        lblUsername.Text = "Username:";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtUsername.Location = new Point(40, 170);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(320, 25);
        txtUsername.TabIndex = 3;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblPassword.Location = new Point(40, 210);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 19);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password:";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtPassword.Location = new Point(40, 235);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(320, 25);
        txtPassword.TabIndex = 5;
        // 
        // btnRegister
        // 
        this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.btnRegister.FlatAppearance.BorderSize = 0;
        this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnRegister.ForeColor = System.Drawing.Color.White;
        this.btnRegister.Location = new System.Drawing.Point(40, 290);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(150, 40);
        this.btnRegister.TabIndex = 6;
        this.btnRegister.Text = "Sign Up";
        this.btnRegister.UseVisualStyleBackColor = false;

        // 
        // btnBackToLogin
        // 
        btnBackToLogin.FlatStyle = FlatStyle.Flat;
        btnBackToLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnBackToLogin.Location = new Point(210, 290);
        btnBackToLogin.Name = "btnBackToLogin";
        btnBackToLogin.Size = new Size(150, 40);
        btnBackToLogin.TabIndex = 7;
        btnBackToLogin.Text = "Back to Login";
        btnBackToLogin.UseVisualStyleBackColor = true;
        // 
        // panelHeader
        // 
        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
        this.panelHeader.Controls.Add(this.lblTitle);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(400, 60);
        this.panelHeader.TabIndex = 8;

        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(400, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "CREATE ACCOUNT";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SignupForm
        // 
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(400, 360);
        Controls.Add(panelHeader);
        Controls.Add(btnBackToLogin);
        Controls.Add(btnRegister);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblUsername);
        Controls.Add(txtFullName);
        Controls.Add(lblFullName);
        FormBorderStyle = FormBorderStyle.None;
        Name = "SignupForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sign Up";
        panelHeader.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblFullName;
    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnBackToLogin;
    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
}

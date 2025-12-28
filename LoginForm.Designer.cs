namespace LogisticManagementSystem;

partial class LoginForm
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
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnCancel = new Button();
        lnkSignup = new LinkLabel();
        panelHeader = new Panel();
        lblTitle = new Label();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 10F);
        lblUsername.Location = new Point(40, 90);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(74, 19);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Username:";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 10F);
        txtUsername.Location = new Point(40, 115);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(320, 25);
        txtUsername.TabIndex = 1;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 10F);
        lblPassword.Location = new Point(40, 160);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 19);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Password:";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 10F);
        txtPassword.Location = new Point(40, 185);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(320, 25);
        txtPassword.TabIndex = 3;
        // 
        // btnLogin
        // 
        this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLogin.ForeColor = System.Drawing.Color.White;
        this.btnLogin.Location = new System.Drawing.Point(40, 240);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(150, 40);
        this.btnLogin.TabIndex = 4;
        this.btnLogin.Text = "Login";
        this.btnLogin.UseVisualStyleBackColor = false;

        // 
        // btnCancel
        // 
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Segoe UI", 10F);
        btnCancel.Location = new Point(210, 240);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(150, 40);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // lnkSignup
        // 
        lnkSignup.AutoSize = true;
        lnkSignup.Location = new Point(140, 290);
        lnkSignup.Name = "lnkSignup";
        lnkSignup.Size = new Size(175, 15);
        lnkSignup.TabIndex = 6;
        lnkSignup.TabStop = true;
        lnkSignup.Text = "Don't have an account? Sign Up";
        lnkSignup.LinkClicked += lnkSignup_LinkClicked_1;
        // 
        // panelHeader
        // 
        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
        this.panelHeader.Controls.Add(this.lblTitle);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(400, 60);
        this.panelHeader.TabIndex = 6;

        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(400, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "LOGISTIC SYSTEM LOGIN";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancel;
        ClientSize = new Size(400, 320);
        Controls.Add(lnkSignup);
        Controls.Add(panelHeader);
        Controls.Add(btnCancel);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblUsername);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        panelHeader.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.LinkLabel lnkSignup;
}

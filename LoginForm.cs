using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class LoginForm : Form
{
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public LoginForm()
    {
        InitializeComponent();
        this.btnLogin.Click += BtnLogin_Click;
        this.btnCancel.Click += BtnCancel_Click;
        this.lnkSignup.LinkClicked += LnkSignup_LinkClicked;
    }

    private void LnkSignup_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        using (SignupForm signupForm = new SignupForm())
        {
            signupForm.ShowDialog();
        }
        this.Show();
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (ValidateLogin(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateLogin(string username, string password)
    {
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            // Note: In a real app, use hashed passwords!
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void lnkSignup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }
}

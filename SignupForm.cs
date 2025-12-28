using System.Data;
using System.Data.SqlClient;

namespace LogisticManagementSystem;

public partial class SignupForm : Form
{
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=Logistics_Management;Integrated Security=True";

    public SignupForm()
    {
        InitializeComponent();
        this.btnRegister.Click += BtnRegister_Click;
        this.btnBackToLogin.Click += BtnBackToLogin_Click;
    }

    private void BtnRegister_Click(object? sender, EventArgs e)
    {
        string fullName = txtFullName.Text.Trim();
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            if (RegisterUser(fullName, username, password))
            {
                MessageBox.Show("Account created successfully! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Using OK to indicate success registration
                this.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool RegisterUser(string fullName, string username, string password)
    {
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        {
            conn.Open();

            // Check if username already exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@Username", username);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Username already taken. Please choose another one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Insert new user
            string insertQuery = "INSERT INTO Users (Username, Password, FullName) VALUES (@Username, @Password, @FullName)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
            {
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);
                insertCmd.Parameters.AddWithValue("@FullName", fullName);
                insertCmd.ExecuteNonQuery();
                return true;
            }
        }
    }

    private void BtnBackToLogin_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

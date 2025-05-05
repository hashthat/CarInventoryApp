using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarListApp
{
    public partial class LoginForm : Form
    {
        // The connectionString to VehicleDB which is the database used for the project.
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";

        public LoginForm() // The loginform is initialized!
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // The event handler for the login button. Click on this button
            // and the validation of the username and password is implemented
            // in order to have a secure login!
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (ValidateUser(username, password))
            {
                this.DialogResult = DialogResult.OK; // Set dialog result to OK if validated
                this.Close(); // Close the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password."); // Show error if credentials are invalid
            }

            
            // Login form for UserName and PAssword Validation.
            LoginForm loginForm = new LoginForm();

            if (ValidateUser(username, password))
            {
                // Hide the login form
                this.Hide();

                // Open the VehicleForm
                VehicleForm vehicleForm = new VehicleForm();
                vehicleForm.FormClosed += (s, args) => this.Close(); // Close login form when VehicleForm closes
                vehicleForm.Show(); // opens the VehicleFrom when information is true!
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
            // handling the register button. First go to the Register Form when clicked!
        {
            string username = txtUser.Text; // get username from text
            string password = txtPass.Text; // Get password from Text

            if (RegisterUser(username, password))
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Username already exists.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Table_User WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        private bool RegisterUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            { // establish connection!
                string checkUser = "SELECT COUNT(*) FROM Table_User WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(checkUser, conn))
                { // Command
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open(); // open data with connection. Username is appended.

                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                        return false;
                    // This adds the new username or the new User to the Data Table
                    // This way the user can log in again even after running the program
                    // closing the program, and they can log in anytime!
                    string insertUser = "INSERT INTO Table_User (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertUser, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.ExecuteNonQuery();
                    } // insert through commands to add the perameters of the username and password.

                    return true;
                }
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog(); // Success!
        }
    }
}

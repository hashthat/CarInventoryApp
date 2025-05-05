using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarListApp
{
    public partial class RegisterForm : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSubRegister_Click(object sender, EventArgs e)
        {
            string firstName = textRegFirst.Text.Trim();
            string lastName = textRegisterLast.Text.Trim();
            string userName = textRegUser.Text.Trim();
            string password = textRegPass.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkUserQuery = "SELECT COUNT(*) FROM Table_User WHERE UserName = @UserName";
                string insertQuery = @"INSERT INTO Table_User (FirstName, LastName, UserName, Password) 
                                       VALUES (@FirstName, @LastName, @UserName, @Password)";

                conn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", userName);
                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.");
                        return;
                    }
                }

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                    insertCmd.Parameters.AddWithValue("@LastName", lastName);
                    insertCmd.Parameters.AddWithValue("@UserName", userName);
                    insertCmd.Parameters.AddWithValue("@Password", password);

                    int rows = insertCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Close(); // or redirect to login
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
            }
        }
    }
}
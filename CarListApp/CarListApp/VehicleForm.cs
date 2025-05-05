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
    public partial class VehicleForm : Form
    {
        public VehicleForm()
            // The Constructor that runs when the form is initialized.
            // There is the comboBoxVehicleType that fills the ComboBox with Choices of organized Data.
            // LoadVehiclData("All") Loads all the vehicle data from all types into a full view on the dataGrid.
        {
            InitializeComponent();
            comboBoxVehicleType.Items.AddRange(new string[] { "All", "Car", "Truck", "SUV" });
            comboBoxVehicleType.SelectedIndex = 0;
            comboBoxVehicleType.SelectedIndexChanged += ComboBoxVehicleType;
            LoadVehicleData("All"); // This loads the data after the user selects the type of Vehicle
        }


        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the logic behind the combo box to select the Data by Type of Vehicle in the DataGridView
        /// </summary>
        
        private void ComboBoxVehicleType(object sender, EventArgs e)
        {
            string selectedType = comboBoxVehicleType.SelectedItem.ToString(); // Appends Selected item from Combobox to string in order to be added as Data
            LoadVehicleData(selectedType);
        }


        private void LoadVehicleData(string vehicleType) // Load Data based on Vehicle Type
        {
            // Data is loaded based on what's found on the DataBase. The connectionString connects with the database.
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";
            string query = "";
            // The DataTable is Bound to the DataGridView1 to display the VehicleList to the User.
            // The data is organized by the type of Vehicle that's been stored on the database.
            switch (vehicleType)
            {
                case "Car":
                    query = "SELECT * FROM CarShow WHERE Type = 'Car'";
                    break;
                case "Truck":
                    query = "SELECT * FROM CarShow WHERE Type = 'Truck'";
                    break;
                case "SUV":
                    query = "SELECT * FROM CarShow WHERE Type = 'SUV'";
                    break;
                case "All":
                default:
                    query = "SELECT * FROM CarShow"; // Fetch all data from CarShow
                    break;
            }
            // Using the established connection from the database (VehicleDB).
            // This opens the DataTable in order to fill the DataTable with 
            // Existing data from the database.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clears data to then bind the data so it can be viewed by the user.
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dt; 
                }
            }
        }

    


        // btnAdd is designed to add the vehicle or the object created to the database.
        // The Button is useful for creating new inventory from the user.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // connecting to the database (VehicleDB)
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";
            // This constructor 
            using (SqlConnection conn = new SqlConnection(connectionString))
            { // inserting the data to view on the GridView.
                string sql = @"
            INSERT INTO CarShow (Type, Make, Model, Year, Price, Color, Condition, TruckType, Drivetrain)
            VALUES (@Type, @Make, @Model, @Year, @Price, @Color, @Condition, @TruckType, @Drivetrain)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    // Adding the Values from the properties the user created
                    // and adding perameters which are added to the SQLcommand object.
                    // @parameter binds the values from the user input.
                {
                    cmd.Parameters.AddWithValue("@Type", comboBoxVehicleType.Text);
                    cmd.Parameters.AddWithValue("@Make", textMake.Text);
                    cmd.Parameters.AddWithValue("@Model", textModel.Text);
                    cmd.Parameters.AddWithValue("@Year", int.Parse(textYear.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(textPrice.Text));
                    cmd.Parameters.AddWithValue("@Color", textColor.Text);
                    cmd.Parameters.AddWithValue("@Condition", textCondition.Text);
                    cmd.Parameters.AddWithValue("@TruckType", string.IsNullOrWhiteSpace(textTruckType.Text) ? DBNull.Value : (object)textTruckType.Text);
                    cmd.Parameters.AddWithValue("@Drivetrain", string.IsNullOrWhiteSpace(textDrivetrain.Text) ? DBNull.Value : (object)textDrivetrain.Text);

                    conn.Open(); // open database connection (VehicleDB)
                    cmd.ExecuteNonQuery(); // Execute SQL Query
                    MessageBox.Show("Vehicle added!"); // Success!!
                }
            }

            // Reload data into DataGridView after adding a vehicle
            LoadVehicleData(comboBoxVehicleType.Text);
        }


        private void btnDelete_Click(object sender, EventArgs e)
            // This is the button which deletes data from the GridBox.
            // The idea is that the data can be added and deleted for the
            // convenience of a car salesman.
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int vehicleId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // Retreiving the Vehicles ID

                // The connection to the VehicleDB using the localdb method
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";
                // executing the SQL command. ExecuteNonQuery() is the command to delete the data based on its Id
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // this matches the Id of the vehicle for deleting the data from the table.
                    string sql = "DELETE FROM Vehicle WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", vehicleId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle deleted.");
                    }
                }
                // Reload the data on the grid. Delete Success!!
                LoadVehicleData(comboBoxVehicleType.Text);
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // A double click on the dataGridView to find my script!
        }
    }
}

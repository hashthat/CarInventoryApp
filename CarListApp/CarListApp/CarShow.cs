using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarListApp
{
    public partial class CarShow : Form
    {
        public CarShow()
        {
            InitializeComponent();
        }

        private void vehicleData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // connecting to the Database Developed through the tables for the VehicleList.mdf;  
            string string2connect = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\C:\Users\earth\Desktop\CarInventoryApp\CarListApp\CarListApp\VehicleList.mdf;Integrated Security=True;Connect Timeout=45;";
            string stringQuery = @"
SELECT 'Car' AS Make, Model, Year, Price, Color, Transmission FROM [Table(car)]
UNION ALL
SELECT 'Truck', Make, Model, Year, Price, Color, TruckType, Drivetrain FROM [Table(Truck)]
UNION ALL
SELECT 'SUV', Make, Model, Year, Price, Color, Drivetrain, Condition FROM [Table(SUV)]";

            SqlConnection conn = new SqlConnection(string2connect);
            SqlDataAdapter adapter = new SqlDataAdapter(stringQuery, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            vehicleDataGrid.DataSource = dt;


        }
    }
}

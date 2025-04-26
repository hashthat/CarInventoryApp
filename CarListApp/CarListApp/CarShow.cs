using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace CarListApp
{
    public partial class CarShow : Form
    {
        public CarShow()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CarShow_Load);

        }


        private void vehicleData_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void CarShow_Load(object sender, EventArgs e)
        {
            string string2connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleListDB;Integrated Security=True;";

            // string string2connect = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VehicleListSQL.mdf;Integrated Security=True;Connect Timeout=45;";
            //string string2connect = @"Data Source=(localdb)/MSSQLLocalDB;AttachDbFilename=C:\Users\earth\Desktop\CarInventoryApp\CarListApp\CarListApp\VehicleListSQL.mdf;Integrated Security=True;Connect Timeout=45;";
            string stringQuery = @"
SELECT 
    'Car' AS VehicleType, 
    Make, 
    Model, 
    Year, 
    Price, 
    Color, 
    Transmission AS Extra1, 
    NULL AS Extra2 
FROM [Table_Car]

UNION ALL

SELECT 
    'Truck' AS VehicleType, 
    Make, 
    Model, 
    Year, 
    Price, 
    Color, 
    TruckType AS Extra1, 
    Drivetrain AS Extra2 
FROM [Table_Truck]

UNION ALL

SELECT 
    'SUV' AS VehicleType, 
    Make, 
    Model, 
    Year, 
    Price, 
    Color, 
    Drivetrain AS Extra1, 
    Condition AS Extra2 
FROM [Table_SUV]";

            using (SqlConnection conn = new SqlConnection(string2connect))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(stringQuery, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    vehicleDataGrid.DataSource = dt;
                }
            }
        }

    }
}

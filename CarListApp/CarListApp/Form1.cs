using System.Formats.Asn1;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace CarListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // The options are hidden by default until the checkbox of a Truck or SUV are selected.
            grpVehicleType.Visible = false;
            cmbDrivetrain.Visible = false;
            cmbTruckType.Visible = false;
            cmbCondition.Visible = false;
            lblCondition.Visible = false;
            lblDrivetrain.Visible = false;
            lblTruckType.Visible = false;

            // filling in the dropdown menu's with code. these are arrays to a string to create a list of options. 
            cmbDrivetrain.Items.AddRange(new string[] { "RWD", "FWD", "AWD", "4x4" });
            cmbTruckType.Items.AddRange(new string[] { "Compact", "Midsize", "Full-Size", "3/4-ton HD", "1-ton HD" });
            cmbCondition.Items.AddRange(new string[] { "New", "Used", "Certified Pre-Owned" });

            // These are events checking on what is selected from the user as part of the GUI.
            chkTruckSUV.CheckedChanged += chkTruckSUV_CheckedChanged;
            rdoTruck.CheckedChanged += rdoTruck_CheckedChanged;
            rdoSUV.CheckedChanged += rdoSUV_CheckedChanged;
            // AddCar.Click += AddCar_Click; <-- This was a fun mistake! I manually created an AddCar.Click method
            // and the problem I ran into was I submitted the form twice everytime I clicked the button. One of those
            // fun Rabbit trails I created while learning about C# in WinForms.
        }



        private void labMake_Click(object sender, EventArgs e)
        {
            // testing from GUI, added function for thinking
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // testing from GUI, added function for thinking
        }

        private void AddCar_Click(object? sender, EventArgs e) // The Event Handler works well!
        {
            // The button is pressed, are the fields for the properties filled out submit
            // the data to the listbox??
            // these are getting the deets from the class in order to successfully creating an object
            // in the ListBox which would the goal of the CarList Class, is creating a car!
            string make = txtMake.Text;
            string model = txtModel.Text;
            string color = txtColor.Text;

            // filling out the details of the class to give the object value through a constructor
            // this is making sure the user gives input to creating a formal list of objects
            // given it is a list of cars in a hypothetical car lot.
            // https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-9.0




            if (string.IsNullOrWhiteSpace(make)) // This function checks for white space in order to return the message box
            {
                MessageBox.Show("Enter the brand of your car in the Make section!");
                return;
            }

            if (string.IsNullOrWhiteSpace(model)) // This function checks for white space in order to return the message box
            {
                MessageBox.Show("Please enter the model of the vehicle!");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year)) // TryParse(txtYear.Text) takes the string text and converts the string into an integer.
                                                           // As Long is this is true "out int year" writes the integer as the year variable
                                                           // that gets assigned to the constructor in order to write the data onto the car list
                                                           // as a car object in the list box.
            {
                MessageBox.Show("Please enter the full year! Example: 2025");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter the price of the vehicle! No commas or characters. Example: 23699");
                return;
            }


            if (string.IsNullOrWhiteSpace(color))
            {
                MessageBox.Show("What Color is the vehicle!?");
                return;
            }

            // getting into the radiobutton input from the user.
            // the default is !pressed --> the user can only press one or the other
            // I considered a drop down menu but it seemed the more presentable method
            // and the way that might make more sense is by selecting one with radiobuttons!
            // Determine transmission type using RadioButtons
            string transmission = "";
            if (rioManual.Checked)
            {
                // Radio button Manual Transmission selection
                transmission = "Manual";
            }
            else if (rioAutomatic.Checked)
            {
                // radio button Automatic Transmission selection
                transmission = "Automatic";
            }
            else
            {
                // if neither are checked, prompt the user to do so.
                MessageBox.Show("Please determine if the vehicle has a Manual or Automatic transmission!");
                return;
            }





            CarList vehicle;

            // Polymorphism! -- Checking the input of the combination boxes from the user.
            // Check if it's an SUV first
            if (rdoSUV.Checked)
            {
                if (cmbCondition.SelectedItem == null || cmbDrivetrain.SelectedItem == null)
                {
                    MessageBox.Show("Please select the condition and drivetrain of the SUV.");
                    return;
                }

                string drivetrain = cmbDrivetrain.SelectedItem?.ToString() ?? "Unknown";
                string condition = cmbCondition.SelectedItem?.ToString() ?? "Unknown";

                vehicle = new SUVList(make, model, year, price, color, transmission, drivetrain, condition);
            }

            else if (chkTruckSUV.Checked)
            {
                if (cmbTruckType.SelectedItem == null || cmbDrivetrain.SelectedItem == null)
                // this is simply checking whether there is blank space in the checkbox
                // and whether or not something is selected as one of the items to describe
                // and build the object whether a car, truck, or SUV!
                {
                    MessageBox.Show("Please select a truck type and drivetrain.");
                    return; // interaction with the user to help guide them.
                }

                string truckType = cmbTruckType.SelectedItem.ToString() ?? "Unknown";
                string drivetrain = cmbDrivetrain.SelectedItem?.ToString() ?? "Unknown";


                vehicle = new TruckList(make, model, year, price, color, transmission, drivetrain, truckType); // constructor for the Truck Object
            }
            else
            {
                vehicle = new CarList(make, model, year, price, color, transmission);
            }




            // Display the vehicle constructor to the ListOfCars listbox.
            ListOfCars.Items.Add(vehicle.GetDisplayInfo());


            // Create Car object
            // CarList newCar = new CarList(make, model, year, price, color, transmission);

            // taking the ListOfCars pointing to the listbox. The Items being the class properties that are filled out
            // through the text boxes. Easy method is to get the data and use GetDisplayInfo
            // https://learn.microsoft.com/en-us/dotnet/api/system.web.webpages.displayinfo?view=aspnet-webpages-3.2

            // ListOfCars.Items.Add(newCar.GetDisplayInfo());

            // https://learn.microsoft.com/en-us/dotNet/api/system.windows.forms.textboxbase.clear?view=windowsdesktop-9.0
            ClearForm();
        }

        private void rioAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton did not need any logic, but clicked on from GUI for testing
        }

        private void rioManual_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton did not need any logic, but clicked on from GUI for testing
        }



        private void ClearForm()
        {
            // This is the clear form after the submit button is pressed
            // Each field or textbox is cleared so a new entry and be parsed to the list of cars!
            txtMake.Text = "";
            txtModel.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
            rioManual.Checked = false; // radiobuttons are set to false as a reset
            rioAutomatic.Checked = false; // radiobutton reset!
        }

        private void chkTruckSUV_CheckedChanged(object? sender, EventArgs e)
        {
            // this function provides a method to show new properties depending on
            // whether the object is as Truck or SUV.
            grpVehicleType.Visible = chkTruckSUV.Checked;

            cmbDrivetrain.Visible = chkTruckSUV.Checked;

            if (!chkTruckSUV.Checked)
            {
                // radio buttons and their defaults. As long as nothing is checked on the "Truck or SUV" checkbox
                // the application focuses on the properties of a CarList object. But that is part of the application
                // to select different vehicle types while the carlist is the blueprint of the instance of a Car, Truck, SUV.
                rdoTruck.Checked = false;
                rdoSUV.Checked = false;
                cmbTruckType.Visible = false;
                cmbCondition.Visible = false;
            }
        }

        private void rdoTruck_CheckedChanged(object? sender, EventArgs e)
        {
            // if the Truck radio button is checked, this implements the visibility
            // of the form and the new properties to the object given the subclass(s) that were created.
            if (rdoTruck.Checked)
            {
                cmbTruckType.Visible = true;
                cmbCondition.Visible = false;
                lblTruckType.Visible = true;
                lblCondition.Visible = false;
            }
        }

        private void rdoSUV_CheckedChanged(object? sender, EventArgs e)
        {
            // If the SUV radio button is checked the conditions are visible for the new subclass.
            if (rdoSUV.Checked)
            {
                cmbDrivetrain.Visible = true;
                lblDrivetrain.Visible = true;
                cmbCondition.Visible = true;
                cmbTruckType.Visible = false;
                lblCondition.Visible = true;
                lblTruckType.Visible = false;
            }
        }

        // reference to Form1
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // This is a groupbox
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This event was created by double clicking groupBox1. It really does nothing for the application
        }

        private void grpVehicleType_Enter(object sender, EventArgs e)
        {
            // these are the vehicle type radio button events I created by double clicking the radiobutton on the GUI
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            // groupbox1, I double clicked while navigating the GUI learning about the ins and outs of the application.
        }

        private void ListOfCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // I double clicked on the ListOfCars list box. Essentially there is an event in code
            // but the list itself is for display purposes and the use of creating objects via Trucks, Cars, SUV's -- 
            // maybe I will look into learning about RV's and creating a different type of app dedicated to camping!
        }

        private void chkTruckSUV_CheckedChanged_1(object sender, EventArgs e)
        {
            // A simple if else statement handling the (check event) users interaction with the GUI application.
            if (!chkTruckSUV.Checked)
            {
                cmbDrivetrain.Visible = false; // Combination box will not show if the checkbox is unchecked
                lblDrivetrain.Visible = false; // label does not show if the checkbox is not checked for a TRUCK or SUV
            }
            else
            {
                cmbDrivetrain.Visible = true; // these state that the combination box is visible when the checkbox is checked
                lblDrivetrain.Visible = true; // the label will show when the user checks the "this is a truck or SUV" checkbox.
            }
        }

        private void lblTruckType_Click(object sender, EventArgs e)
        {

        }

        private void cmbDrivetrain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowCarList_Click(object sender, EventArgs e)
        {
            CarShow carShowForm = new CarShow(); // Create a new CarShow form
            carShowForm.Show(); // Open it non-modally (can interact with both forms)
        }

    }
}

using System.Formats.Asn1;
using System;
using System.Windows.Forms;

namespace CarListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labMake_Click(object sender, EventArgs e)
        {
            // testing from GUI, added function for thinking
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // testing from GUI, added function for thinking
        }

        private void AddCar_Click(object sender, EventArgs e)
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
                transmission = "Manual";
            }
            else if (rioAutomatic.Checked)
            {
                transmission = "Automatic";
            }
            else
            {
                MessageBox.Show("Please determine if the vehicle has a Manual or Automatic transmission!");
                return;
            }

            // Create Car object
            CarList newCar = new CarList(make, model, year, price, color, transmission);

            // taking the ListOfCars pointing to the listbox. The Items being the class properties that are filled out
            // through the text boxes. Easy method is to get the data and use GetDisplayInfo
            // https://learn.microsoft.com/en-us/dotnet/api/system.web.webpages.displayinfo?view=aspnet-webpages-3.2

            ListOfCars.Items.Add(newCar.GetDisplayInfo()); 

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
    }
}

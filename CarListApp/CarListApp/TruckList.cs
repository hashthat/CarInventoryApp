using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp
{
    public class TruckList : CarList 
        // TruckList is inheriting the main properties provided by the CarList which are seen in the constructor TruckList below.
        // the purpose is for the user interaction and hopefully some organization to the classes and the development of the code
        // as the growth of the application continues.
    {
        public string Drivetrain; // The user input for a Truck has a drivetrain option.
        public string TruckType; // There are ALOT of trucks out there, what kind of truck is this object?!

        public TruckList(string make, string model, int year, decimal price, string color, string transmission, string drivetrain, string truckType)
            : base(make, model, year, price, color, transmission) // This constructor constructs an object using the baseclass
                                                                  // CarList and adds to the properties from the current class.
        {
            Drivetrain = drivetrain; // creating values to the variables for the constructor to build an object "Truck"
            TruckType = truckType; // The second value and variable for the constructor to create a Truck Object.
        }

        public override string GetDisplayInfo()
        {
            // as part of creating a new class, there is the "override" method of inheriting properties from the
            // baseclass. But, there is a slight change to the code of the CarList class given there was the need
            // to "Virtualize" the constructor in order to make the properties portable and available to be used
            // in the new subclasses. The override method simplay overrides the method from the CarList using the
            // new properties of the subclass to create a truck object and appending the object to the List of Vehicles.
            return $"{Year} {Make} {Model} ({TruckType}) - {Color} - {Transmission} - {Drivetrain} - ${Price}";
        }
    }

}

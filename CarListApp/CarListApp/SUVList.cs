using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp
{
    public class SUVList : CarList // The SUV is the second Subclass to the CarList Class as we develop new instances of the CarList blueprint.
    {
        public string Drivetrain { get; set; } // Properties that create the new object Class. The Drivetrain is shared with the Truck Class
        public string Condition { get; set; } // This is stating how the condition of the SUV is. It's one feature that makes the SUV class different from the others.

        public SUVList(string make, string model, int year, decimal price, string color, string transmission, string drivetrain, string condition)
            : base(make, model, year, price, color, transmission)
            // the same base class breakdown as the truck class. We are inheriting a few new properties, but the Drivetrain and Condition
            // of the SUV make it unique as the SUV object gets constructed.
        {
            Drivetrain = drivetrain; // Variables for the constructor
            Condition = condition;
        }

        public override string GetDisplayInfo()
            // using the override method to the CarClass Virtual String. This inherits the CarList properties and appends the SUV propperties as part of the new object!
        {
            return $"{Year} {Make} {Model} SUV - {Color} - {Transmission} - {Drivetrain} - {Condition} - ${Price}";
        }
    }

}

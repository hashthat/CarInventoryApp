using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
    // Creating the car class first creating the properties a buyer would find for information on a car from a used car lot
    public class CarList // The Class!
    {
        // These are the properties to create an instance of a car object
        public string Make {  get; set; }
        public string Model { get; set; }
        // public string Condition { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }

        // after declaring the properties that create a car object
        // the constructor builds the object from the user input to create the Car Object to append to the list!

        public CarList(string make, string model, int year, decimal price, string color, string transmission) // Constructor!
        {
            // this is simply creating values or variables
            // The constructor creates an object from the class declared above.
            // The constructor needs a reference to what the objects are as the getters and setters 
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            Transmission = transmission;
        }

        public virtual string GetDisplayInfo()
        {
           // I had changed this code to Virtualize the DisplayInfo in order to create portability within the classes.
           // this returns the values of the CarList class (this class) but it is virtualized so the return can be
           // virtualized yet overridden by a new constructor from a SubClass. So the Subclass inherits the values of
           // the CarList class and appends the values of the new variables constructed in the subclass to distinguish
           // the objects even though they share the same blueprint.
           return $"{Year} {Make} {Model} - {Color} - {Transmission} - ${Price}";
        }


    }

}

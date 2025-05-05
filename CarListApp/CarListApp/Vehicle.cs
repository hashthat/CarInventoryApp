using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }         // Car, Truck, SUV
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Condition { get; set; }
        public string TruckType { get; set; }    // Nullable, for Trucks
        public string Drivetrain { get; set; }   // Nullable, for SUVs
    }
}

using System;

namespace OOPInheritance
{
    // Parent Class: Vehicle
    public class Vehicle
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Constructor
        public Vehicle(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Method to display vehicle info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Make} {Model} ({Year}), Color: {Color}");
        }
    }
}

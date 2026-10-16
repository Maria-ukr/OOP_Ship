using System;
using System.Text;

namespace Laba_7
{
    internal class Ship
    {
        protected string Name { get; set; }
        protected string Country { get; set; }
        protected string Purpose { get; set; }
        protected double Displacement { get; set; }
        protected double EnginePower { get; set; }
        protected string FuelType { get; set; }

        public Ship(string name, string country, string purpose, double displacement, double enginePower, string fuelType)
        {
            Name = name;
            Country = country;
            Purpose = purpose;
            Displacement = displacement;
            EnginePower = enginePower;
            FuelType = fuelType;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\n");
            Console.WriteLine($"{Name} is {Purpose} of {Country}");
            Console.WriteLine($"Displacement: {Displacement} tons");
            Console.WriteLine($"Engine Power: {EnginePower} hp");
            Console.WriteLine($"Fuel Type: {FuelType}");
        }
    }
}

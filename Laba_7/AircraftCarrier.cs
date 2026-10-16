using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7
{
    internal class AircraftCarrier : Ship
    {
        protected int Aircraft_capacity { get; set; }
        protected string Aircraft_type { get; set; }
        public AircraftCarrier(string name, string country, string purpose, double displacement, double enginePower, string fuelType, int capacity, string a_type) : base (name, country, purpose, displacement, enginePower, fuelType)
        {
            Aircraft_capacity = capacity;
            Aircraft_type = a_type;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Additional information about Aircraft Carrier:");
            Console.WriteLine($"Aircraft Capacity: {Aircraft_capacity}");
            Console.WriteLine($"Aircraft Type: {Aircraft_type}");
        }
    }
}

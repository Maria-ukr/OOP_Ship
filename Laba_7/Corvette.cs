using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_7
{
    internal class Corvette : MissileCarrier
    {
        protected int CrewCapacity { get; set; }
        public Corvette(string name, string country, string purpose, double displacement, double enginePower, string fuelType, int total_missiles, string missile_type, int crew) : base(name, country, purpose, displacement, enginePower, fuelType, total_missiles, missile_type) {
            CrewCapacity = crew;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Additional information about Corvette:");
            Console.WriteLine($"Total Crew Capacity: {CrewCapacity}");
        }
    }
}

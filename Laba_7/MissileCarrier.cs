using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7
{
    internal class MissileCarrier : Ship
    {
        protected int Total_missiles { get; set; }
        protected string Missile_type { get; set; }
        public MissileCarrier(string name, string country, string purpose, double displacement, double enginePower, string fuelType, int missiles, string m_type) : base(name, country, purpose, displacement, enginePower, fuelType)
        {
            Total_missiles = missiles;
            Missile_type = m_type;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Additional information about Missile Carrier:");
            Console.WriteLine($"Total Missiles: {Total_missiles}");
            Console.WriteLine($"Missile Type: {Missile_type}");
        }
    }
}

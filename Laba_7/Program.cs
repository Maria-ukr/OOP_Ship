using System;

namespace Laba_7
{
    internal class Program
    {
        static void Main()
        {
            Ship ship1 = new Ship("Titanic", "United Kingdom", "Passenger Ship", 52310, 46000, "Coal");
            ship1.DisplayInfo();
            AircraftCarrier gerald_R = new AircraftCarrier("Gerald R. Ford", "United States", "Aircraft Carrier", 100000, 100000, "Nuclear", 75, "F/A-18 Super Hornet");
            gerald_R.DisplayInfo();
            MissileCarrier arleigh_Burke = new MissileCarrier("Arleigh Burke-class", "United States", "Missile carriers", 97000, 100000, "Nuclear", 90, "Tomahawk");
            arleigh_Burke.DisplayInfo();
            Corvette hetman_Mazepa = new Corvette("Hetman Ivan Mazepa (F211)", "Türkiye for Ukraine", "A Ukrainian Navy corvette", 2300, 42430, "Diesel and gas turbine", 16, "Harpoon, VL MICA", 93);
            hetman_Mazepa.DisplayInfo();
        }
    }
}

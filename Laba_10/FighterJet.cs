using System;

namespace Laba_10
{
    class FighterJet : Plane
    {
        public FighterJet(string plane_id, string fuel, double fuel_per_km, double speed) : base(plane_id, fuel, fuel_per_km, speed)
        {}
        public override void InputData()
        {
            bool isValid = false;
            while(!isValid)
            {
                Console.WriteLine($"Enter distance for fighter jet {plane_id} in km to fly: ");
                string s = Console.ReadLine();
                if (double.TryParse(s, out double res))
                {
                    distance_to_fly = res;
                    calculate_fuel_needs = distance_to_fly * fuel_per_km;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
        }
        public override void GetHoursInUp()
        {
            double totalHours = distance_to_fly / speed;
            int hours = (int)totalHours;
            int minutes = (int)Math.Round((totalHours - hours) * 60);
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            Console.WriteLine($"The fighter jet {plane_id} can be in air {hours} hours and {minutes} minutes!");
        }
    }
}

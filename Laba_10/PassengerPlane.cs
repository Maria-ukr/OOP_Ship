using System;

namespace Laba_10
{
    class PassengerPlane : Plane
    {
        private int passengerCount;

        public PassengerPlane(
            string plane_id, 
            string fuel, 
            double fuel_per_km,
            int passengerCount, 
            double distance_to_fly, double speed) : base(plane_id, fuel, fuel_per_km, speed)
        {
            this.passengerCount = passengerCount;
            this.distance_to_fly = distance_to_fly;
        }

        public override void InputData()
        { }

        public void OutputData()
        {
            Console.WriteLine($"Passenger plane has {passengerCount} passengers.");
        }
        public override void GetHoursInUp() {
            calculate_fuel_needs = distance_to_fly * fuel_per_km;
            double totalHours = calculate_fuel_needs / speed;
            int hours = (int)totalHours;
            int minutes = (int)Math.Round((totalHours - hours) * 60);
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            Console.WriteLine($"The passenger plane {plane_id} can be in air {hours} hours and {minutes} minutes!");
        }

    }
}

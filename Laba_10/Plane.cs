using System;

namespace Laba_10
{
    abstract class Plane
    {
        protected string plane_id;
        protected string fuel;
        protected double fuel_per_km;
        protected double speed;
        protected double distance_to_fly;
        protected double calculate_fuel_needs;

        protected Plane(string plane_id, string fuel, double fuel_per_km, double speed)
        {
            this.plane_id = plane_id;
            this.fuel = fuel;
            this.fuel_per_km = fuel_per_km;
            this.speed = speed;
        }
        public abstract void InputData();
        public abstract void GetHoursInUp();
    }
}

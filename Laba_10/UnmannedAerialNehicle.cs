using System;

namespace Laba_10
{
    abstract class UnmannedAerialNehicle
    {
        protected string model_name;
        protected double battery_level;
        protected double max_altitude;
        protected double speed;
        protected string execute_mission;

        protected UnmannedAerialNehicle(
            string model_name,
            double battery_level,
            double altitude,
            double speed
            )
        {
            this.model_name = model_name;
            this.battery_level = battery_level;
            this.max_altitude = altitude;
            this.speed = speed;
        }

        public void DispalayInfo()
        {
            Console.WriteLine($">>> Info about UAN: {model_name} with speed: {speed}");
            Console.WriteLine($"        and max altitude of fly: {max_altitude}");
        }
        public abstract void StatusCheck();
        public abstract string ExecuteMission(string exec_mission);
    }
}

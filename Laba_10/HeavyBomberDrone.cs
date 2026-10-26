using System;

namespace Laba_10
{
    class HeavyBomberDrone : UnmannedAerialNehicle
    {
        public HeavyBomberDrone(
            string model_name,
            double battery_level,
            double altitude,
            double speed) : base(model_name, battery_level, altitude, speed)
        {

        }
        public override void StatusCheck()
        {
            base.DispalayInfo();
            Console.WriteLine($"Max battery: {battery_level}");
        }

        public override string ExecuteMission(string exec_mission)
        {
            return execute_mission = exec_mission;
        }
    }
}

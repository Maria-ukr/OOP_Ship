using System;

namespace Laba_10
{
    class MavicDrone : UnmannedAerialNehicle
    {
        protected bool has_drop_system;
        public MavicDrone(
            string model_name,
            double battery_level,
            double altitude,
            double speed, bool has_drop_system) : base(model_name, battery_level, altitude, speed)
        {
            this.has_drop_system = has_drop_system;
        }
        public override string ExecuteMission(string exec_mission)
        {
            return execute_mission = exec_mission;
        }

        public override void StatusCheck()
        {
            base.DispalayInfo();
            Console.WriteLine($"Max battery: {battery_level}");
            Console.WriteLine($"Drop system: {(has_drop_system ? "Yes" : "No")}");
            string checkMission = !string.IsNullOrEmpty(this.execute_mission) ? this.execute_mission : "No mission assigned";
            Console.WriteLine($"Execute mission: {checkMission}");
            Console.WriteLine("\n");
        }
    }
}

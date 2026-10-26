using System;

namespace Laba_10
{
    internal class Program
    {
        static void Main()
        {
            MavicDrone mavic = new MavicDrone(
                "Mavic 3 Pro", 95.5, 500, 60, true); 
            mavic.ExecuteMission("Conducting reconnaissance and artillery adjustment");
            mavic.StatusCheck();
            HeavyBomberDrone babaYaga = new HeavyBomberDrone(
                "Vampire (Baba Yaga)", 100, 300, 40);
            babaYaga.StatusCheck(); 
            babaYaga.ExecuteMission("Night sortie and dropping mines on enemy positions");
        }
    }
}

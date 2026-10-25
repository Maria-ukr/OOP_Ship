using System;

namespace Laba_10
{
    internal class Program
    {
        static void Main()
        {
            FighterJet jet = new FighterJet(
                "F-16 Fighting Falcon", 
                "Jet fuel (JP-8)", 5, 1500);
            jet.InputData();
            jet.GetHoursInUp();

            PassengerPlane pasPlane = new PassengerPlane(
                "Boeing 737-800", 
                "disel", 3, 189, 5000, 842);
            pasPlane.OutputData();
            pasPlane.GetHoursInUp();
        }
    }
}

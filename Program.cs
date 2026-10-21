using System;

namespace Laba_8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"\n--- Class Transport:");
            Transport tr1 = new Transport("Universal Transport", 50000);
            Transport tr2 = new Transport("Cargo Van 2024", 32000);
            tr1.Display_Info();
            tr2.Display_Info();

            Console.WriteLine($"\n--- Class FreightTransport:");
            FreightTransport ft1 = new FreightTransport("MAN TGX", 18, 600);
            ft1.Display_Info();
            FreightTransport ft2 = new FreightTransport("Volvo FH16", 14, 350);
            ft2.Display_Info();
            FreightTransport ft3 = new FreightTransport("Mercedes Atego", 10, 200);
            ft3.Display_Info();

            Console.WriteLine($"\n--- Class PassengerTransport:");
            PassengerTransport pt1 = new PassengerTransport("Mercedes Sprinter", 28);
            pt1.TicketCost = 400;
            pt1.Display_Info();
            PassengerTransport pt2 = new PassengerTransport("Volvo 9700", 55);
            pt2.TicketCost = 860;
            pt2.Display_Info();
            PassengerTransport pt3 = new PassengerTransport("Bogdan A-092", 22);
            pt3.TicketCost = 22;
            pt3.Display_Info();
        }
    }
}

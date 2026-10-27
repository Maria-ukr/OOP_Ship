using System;

namespace Laba_10
{
    internal class Program
    {
        static void Main()
        {
            Liner[] liners = new Liner[]
            {
                new Liner("Royal", 5000, 22.5, 1200000000),
                new Liner("Carnival", 3500, 20.0, 800000000),
                new Liner("Norwegian", 4000, 21.5, 950000000),
                new Liner("Princess", 3200, 21.0, 850000000),
                new Liner("Princess", 3200, 21.0, 850000000),
            };
            for(int i = 0; i < liners.Length-1; i++)
            {
                Console.WriteLine($"{liners[i] == liners[i + 1]}");
                Console.WriteLine($"{liners[i] > liners[i + 1]}");
                Console.WriteLine($"{liners[i] < liners[i + 1]}");
            }
            Console.WriteLine($"{liners[3] + liners[2]}");
        }
    }
}

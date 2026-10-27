using System;

namespace Laba_10
{
    class Liner
    {
        protected string brand = "Linear";
        protected int passengers = 0;
        protected double speed = 0;
        protected double cost = 0;

        public Liner() { }

        public Liner(string brand, int passengers, double speed, double cost) {
            this.brand = brand;
            this.passengers = passengers;
            this.speed = speed;
            this.cost = cost;
        }

        public void dispalyInfo()
        {
            Console.WriteLine($">>>  Liner brand: {brand}");
            Console.WriteLine($"     passengers: {passengers}");
            Console.WriteLine($"     speed: {speed} and cost: {cost}");
            Console.WriteLine("\n");
        }
        public static bool operator ==(Liner a, Liner b)
        {
            if (a.brand == b.brand && a.passengers == b.passengers
                && a.speed == b.speed && a.cost == b.cost)
            {
                Console.WriteLine($"Liner {a.brand} and Liner {b.brand} are equal !");
                return true;
            }
            else
            {
                Console.WriteLine($"Liner {a.brand} and Liner {b.brand} are NOT equal !");
                return false;
            }
        }
        public static bool operator !=(Liner a, Liner b)
        {
            if (a.brand != b.brand || a.passengers != b.passengers
                || a.speed != b.speed || a.cost != b.cost)
            {
                Console.WriteLine($"Liner {a.brand} and Liner {b.brand} are NOT equal !");
                return true;
            }
            else
            {
                Console.WriteLine($"Liner {a.brand} and Liner {b.brand} are equal !");
                return false;
            }
        }
        public static bool operator >(Liner a, Liner b) { 
            if(a.passengers > b.passengers)
            {
                Console.WriteLine($"Liner {a.brand} has more passengers then {b.brand}");
                return true;
            } else
            {
                Console.WriteLine($"Liner {b.brand} has more passengers then {a.brand}");
                return false;
            }
        }
        public static bool operator <(Liner a, Liner b)
        {
            if (a.passengers < b.passengers)
            {
                Console.WriteLine($"Liner {a.brand} has less passengers then {b.brand}");
                return true;
            }
            else
            {
                Console.WriteLine($"Liner {b.brand} has less passengers then {a.brand}");
                return false;
            }
        }
        public static Liner operator+(Liner a, Liner b) {
            Liner liner = new Liner();
            liner.brand = $"{a.brand}/{b.brand}";
            liner.passengers = a.passengers + b.passengers;
            liner.speed = (a.speed + b.speed) / 2;
            liner.cost = a.cost + b.cost;
            liner.dispalyInfo();
            return liner;
        }
    }
}

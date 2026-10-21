using System;

namespace Laba_8
{
    internal class Transport
    {
        protected string model;
        protected double net_profit;

        public Transport () { }

        public Transport (string model, double net_profit)
        {
            this.model = model;
            this.net_profit = net_profit;
        }

        protected virtual void Calculate_Net_Profit()
        {
            Console.WriteLine($"Class Transport Calculate NET profit {net_profit}");
        }

        public void Display_Info()
        {
            Console.WriteLine($"{model}");
            Console.WriteLine($"       has NET Profit: {net_profit}");
        }
    }
}

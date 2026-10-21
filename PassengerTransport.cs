using System;

namespace Laba_8
{
    internal class PassengerTransport : Transport
    {
        private int passenger_count;
        private int ticket_cost = 700;

        public int TicketCost
        {
            get { return ticket_cost; }
            set
            {
                ticket_cost = value;
            }
        }
        public PassengerTransport(
            string model,
            int passenger_count = 0) : base()
        {
            this.model = model;
            this.passenger_count = passenger_count;

            Calculate_Net_Profit();
        }

        protected override void Calculate_Net_Profit()
        {
            net_profit = ticket_cost * passenger_count;
        }
    }
}

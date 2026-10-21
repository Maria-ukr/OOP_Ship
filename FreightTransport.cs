using System;

namespace Laba_8
{
    internal class FreightTransport : Transport
    {
        private double cost_per_km;
        private double distance;
        public FreightTransport(
            string model,
            double cost_per_km,
            double distance) : base ()
        {
            this.model = model;
            this.cost_per_km = cost_per_km;
            this.distance = distance;

            Calculate_Net_Profit();
        }

        protected override void Calculate_Net_Profit()
        {
            net_profit = this.cost_per_km * this.distance;
        }
    }
}

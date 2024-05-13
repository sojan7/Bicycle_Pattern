namespace Bicycle_Pattern
{
    internal class BicycleBuilder : IBicycleBuilder
    {
        private bool hasGears;
        private bool hasDoubleStand;
        private bool hasDoubleSeats;
        private bool hasCarrier;
        private bool built;

        public BicycleBuilder()
        {
            hasGears = false;
            hasDoubleStand = false;
            hasDoubleSeats = false;
            hasCarrier = false;
            built = false;
        }

        public IBicycleBuilder AddGears()
        {
            if (!built)
                hasGears = true;
            return this;
        }

        public IBicycleBuilder AddDoubleStand()
        {
            if (!built)
                hasDoubleStand = true;
            return this;
        }

        public IBicycleBuilder AddDoubleSeats()
        {
            if (!built)
                hasDoubleSeats = true;
            return this;
        }

        public IBicycleBuilder AddCarrier()
        {
            if (!built)
                hasCarrier = true;
            return this;
        }

        public Bicycle Build()
        {
            built = true;
            return new Bicycle(hasGears, hasDoubleStand, hasDoubleSeats, hasCarrier);
        }
    }
}
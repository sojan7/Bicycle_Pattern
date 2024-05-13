namespace Bicycle_Pattern
{
    internal class BicycleManufacturer
    {
        private readonly IBicycleBuilder builder;

        public BicycleManufacturer(IBicycleBuilder builder)
        {
            this.builder = builder;
        }

        public Bicycle ConstructBicycle()
        {
            return builder
                .AddGears()
                .AddDoubleStand()
                .AddDoubleSeats()
                .AddCarrier()
                .Build();
        }
    }
}
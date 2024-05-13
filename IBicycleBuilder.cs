namespace Bicycle_Pattern
{
    internal interface IBicycleBuilder
    {
        IBicycleBuilder AddGears();

        IBicycleBuilder AddDoubleStand();

        IBicycleBuilder AddDoubleSeats();

        IBicycleBuilder AddCarrier();

        Bicycle Build();
    }
}
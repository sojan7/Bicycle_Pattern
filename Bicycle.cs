namespace Bicycle_Pattern
{
    internal class Bicycle
    {
        public bool HasGears { get; }
        public bool HasDoubleStand { get; }
        public bool HasDoubleSeats { get; }
        public bool HasCarrier { get; }

        public Bicycle(bool hasGears, bool hasDoubleStand, bool hasDoubleSeats, bool hasCarrier)
        {
            HasGears = hasGears;
            HasDoubleStand = hasDoubleStand;
            HasDoubleSeats = hasDoubleSeats;
            HasCarrier = hasCarrier;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Bicycle Details:");
            Console.WriteLine($"Gears: {HasGears}");
            Console.WriteLine($"Double Stand: {HasDoubleStand}");
            Console.WriteLine($"Double Seats: {HasDoubleSeats}");
            Console.WriteLine($"Carrier: {HasCarrier}");
        }
    }
}
namespace Bicycle_Pattern
{
    public class Program
    {
        private static void Main()
        {
            IBicycleBuilder builder = new BicycleBuilder();
            BicycleManufacturer manufacturer = new(builder);
            Bicycle bicycle = manufacturer.ConstructBicycle();
            bicycle.DisplayDetails();
        }
    }
}
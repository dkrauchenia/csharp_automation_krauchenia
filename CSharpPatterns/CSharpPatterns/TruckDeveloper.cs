namespace CSharpPatterns
{
    public class TruckDeveloper : IDeveloper       //Class representing a TruckDeveloper, implementing the IDeveloper interface
    {
        public IVehicle Create()
        {
            return new Truck();
        }
    }
}

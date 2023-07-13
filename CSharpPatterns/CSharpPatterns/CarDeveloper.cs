namespace CSharpPatterns
{
    public class CarDeveloper : IDeveloper      //Class representing a CarDeveloper, implementing the IDeveloper interface
    {
        public IVehicle Create()
        {
            return new Car();
        }
    }
}

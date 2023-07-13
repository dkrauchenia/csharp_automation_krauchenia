namespace CSharpPatterns
{
    public class UnicycleDeveloper : IDeveloper     //Class representing a UnicycleDeveloper, implementing the IDeveloper interface
    {
        public IVehicle Create()
        {
            return new Unicycle();
        }
    }
}

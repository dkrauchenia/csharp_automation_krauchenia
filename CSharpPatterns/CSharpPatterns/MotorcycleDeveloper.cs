namespace CSharpPatterns
{
    public class MotorcycleDeveloper : IDeveloper   //Class representing a MotorcycleDeveloper, implementing the IDeveloper interface    
    {
        public IVehicle Create()
        {
            return new Motorcycle();
        }
    }
}

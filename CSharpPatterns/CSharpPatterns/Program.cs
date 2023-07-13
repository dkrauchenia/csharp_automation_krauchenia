using CSharpPatterns;

class Program
{
    static void Main()
    {
        #region Task 1. Decorator pattern
        
        Console.WriteLine("Task 1");
        
        //Create a Gigantosaurus
        IGigantosaurus gigantosaurus = new Gigantosaurus();

        //Create a LoudGigantosarusDecorator with Gigantosaurus as the inner object
        IGigantosaurus loudGigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);

        //Create an ExtraLoudGigantosaurusDecorator with Gigantosaurus as the inner object
        IGigantosaurus extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(gigantosaurus);

        //Call the Roar method on the extraLoudGigantosaurus object
        gigantosaurus.Roar();
        loudGigantosaurus.Roar();
        extraLoudGigantosaurus.Roar();

        Console.WriteLine();
        #endregion

        #region Task 2. Factory method pattern
        
        Console.WriteLine("Task 2");

        //Create a UnicycleDeveloper and create a Unicycle
        IDeveloper unicycleDeveloper = new UnicycleDeveloper();
        IVehicle unicycle = unicycleDeveloper.Create();
        unicycle.GetInfo();

        //Create a MotorcycleDeveloper and create a Motorcycle
        IDeveloper motorcycleDeveloper = new MotorcycleDeveloper();
        IVehicle motorcycle = motorcycleDeveloper.Create();
        motorcycle.GetInfo();

        //Create a CarDeveloper and create a Car
        IDeveloper carDeveloper = new CarDeveloper();
        IVehicle car = carDeveloper.Create();
        car.GetInfo();

        //Create a TruckDeveloper and create a Truck
        IDeveloper truckDeveloper = new TruckDeveloper();
        IVehicle truck = truckDeveloper.Create();
        truck.GetInfo();
        #endregion
    }
}

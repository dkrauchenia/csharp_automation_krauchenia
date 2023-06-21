using CSharpOOP2;

static class Program
{

    static void Main()
    {
        //Task 4. Creating the 1st object
        Scooter windSerfer = new Scooter();
        windSerfer.Model = "WindSerfer A";
        windSerfer.Year = 2022;
        windSerfer.Price = 5000.99;
        windSerfer.IsElectric = true;

        //Task 5. Creating the 2nd object
        Scooter swiftRider = new Scooter { Model = "SwiftRider S", Year = 2021, Price = 4999.99, IsElectric = false };

        //Task 9. Creating the 3rd object using a constructor which initializes all the fields
        Scooter turboGlide = new Scooter("TurboGlide A", 2022, 6000.99, true);

        //Task 10. Calling the created method for one of the objects
        swiftRider.IncreasePriceOrPrint();

        //Task 11. ERROR LINE
        //windSerfer.PrintScooter();

        //Task 11. Calling a method with internal modifier
        turboGlide.DisplayScooterInfo();

        //Task 12. Console output is as if IsElectric = false, because false is a default value for boolean type
        Scooter bladeRunner = new Scooter { Model = "BladeRunner S", Year = 2023, Price = 5000.99 };
        bladeRunner.IncreasePriceOrPrint();

        //Task 13. Console output corresponds to the value set as default - 2019
        Scooter speedyRocket = new Scooter { Model = "SpeedyRocket A", Price = 3000.99, IsElectric = false };
        Console.WriteLine(speedyRocket.Year);
    }

}

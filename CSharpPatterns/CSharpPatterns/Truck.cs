using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns
{
    public class Truck : IVehicle //Class representing a Truck, implementing the IVehicle interface
    {
        public void GetInfo()
        {
            Console.WriteLine("Truck: Multiple wheels.");
        }
    }
}

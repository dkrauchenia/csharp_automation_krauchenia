using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns
{
    public class Car : IVehicle //Class representing a Car, implementing the IVehicle interface
    {
        public void GetInfo()
        {
            Console.WriteLine("Car: Four wheels.");
        }
    }
}

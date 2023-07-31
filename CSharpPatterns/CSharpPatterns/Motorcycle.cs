using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns
{
    public class Motorcycle : IVehicle  //Class representing a Motorcycle, implementing the IVehicle interface
    {
        public void GetInfo()
        {
            Console.WriteLine("Motorcycle: Two wheels.");
        }
    }
}

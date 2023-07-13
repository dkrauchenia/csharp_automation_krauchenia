using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns
{
    public class Unicycle : IVehicle //Class representing a Unicycle, implementing the IVehicle interface
    {
        public void GetInfo()
        {
            Console.WriteLine("Unicycle: One wheel.");
        }
    }
}

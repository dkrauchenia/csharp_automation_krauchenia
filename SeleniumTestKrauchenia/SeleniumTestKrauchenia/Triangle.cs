using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestKrauchenia
{
    public class Triangle
    {
        public void CheckForExistence(double baseSide, double firstSide, double secondSide)
        {
            if (baseSide <= 0 || firstSide <= 0 || secondSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less or equal than 0.");
            }
            else if (baseSide + firstSide < secondSide || baseSide + secondSide < firstSide ||
                     secondSide + firstSide < baseSide)
            {
                throw new ArgumentOutOfRangeException("The sum of the two sides cannot be less than the third side.");
            }
        }
    }
}

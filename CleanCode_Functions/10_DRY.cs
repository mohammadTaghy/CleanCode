using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class DRY
    {
        // A function that calculates the area of a circle
        double areaOfCircle(double radius)
        {
            return 3.14 * radius * radius;
        }

        // A function that calculates the circumference of a circle
        double circumferenceOfCircle(double radius)
        {
            return 2 * 3.14 * radius;
        }
    }
    internal class DRY_Clean
    {
        // A constant variable that holds the value of pi
        const double PI = 3.14;

        // A function that calculates the area of a circle
        double areaOfCircle(double radius)
        {
            return PI * radius * radius;
        }

        // A function that calculates the circumference of a circle
        double circumferenceOfCircle(double radius)
        {
            return 2 * PI * radius;
        }
    }
}

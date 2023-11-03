using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Formatting
{
    public class Calculator
    {
        // A method that calculates the average of two numbers
        public double Average(int x, int y)
        {
            // Call the Add and Divide methods
            return Divide(Add(x, y), 2);
        }

        // A method that adds two numbers
        public int Add(int x, int y)
        {
            return x + y;
        }

        // A method that divides two numbers
        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }

}

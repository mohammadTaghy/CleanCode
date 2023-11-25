using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures
{
    // A class that represents a point on the Cartesian plane
    public class Point
    {
        // Public fields that store the coordinates of the point
        public double X;
        public double Y;

    }
    // A class that represents a point on the Cartesian plane
    public class Point_Clean
    {
        // Private fields that store the coordinates of the point
        private double x;
        private double y;

        // A public method that returns the x-coordinate of the point
        public double GetX()
        {
            return x;
        }

        // A public method that returns the y-coordinate of the point
        public double GetY()
        {
            return y;
        }

        // A public method that sets the x-coordinate of the point
        public void SetX(double x)
        {
            this.x = x;
        }

        // A public method that sets the y-coordinate of the point
        public void SetY(double y)
        {
            this.y = y;
        }
    }
}

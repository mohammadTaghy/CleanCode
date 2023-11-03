using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures.Clean
{

    public interface Shape
    {
        double Area();
    }
    public class Square : Shape
    {
        private Point topLeft;
        private double side;

        public double Area()
        {
            return side * side;
        }
    }
    public class Rectangle : Shape
    {
        private Point topLeft;
        private double height;
        private double width;
        public double Area()
        {
            return height * width;
        }
    }
    public class Circle : Shape
    {
        private Point center;
        private double radius;
        public double PI = 3.141592653589793;
        public double Area()
        {
            return PI * radius * radius;
        }
    }
    public class Geometry
    {
        public double CalcArea(Shape shape)
        {
            return shape.Area();
        }
    }
}

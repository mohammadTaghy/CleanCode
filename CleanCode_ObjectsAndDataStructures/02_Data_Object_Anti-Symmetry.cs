using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures
{
    public class Square
    {
        public Point topLeft;
        public double side;
    }
    public class Rectangle
    {
        public Point topLeft;
        public double height;
        public double width;
    }
    public class Circle
    {
        public Point center;
        public double radius;
    }
    public class Geometry
    {
        public double PI = 3.141592653589793;
        public double area(Object shape)
        {
            if (shape is Square)
            {
                Square s = (Square)shape;
                return s.side * s.side;
            }


            else if (shape is Rectangle) {
                Rectangle r = (Rectangle)shape;
                return r.height * r.width;
            }
            else if (shape is Circle) {
                Circle c = (Circle)shape;
                return PI * c.radius * c.radius;
            }
            throw new Exception();
        }
    }
}
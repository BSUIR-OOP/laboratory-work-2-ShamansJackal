using OOP_lab1.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Shapes
{
    public class Circle : Elipse
    {
        public Circle(int x, int y, int radius) : base(x,y,radius,radius) { }

        public Circle(Point point1, Point point2) :
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Min(Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y))
        ){ }
    }
}

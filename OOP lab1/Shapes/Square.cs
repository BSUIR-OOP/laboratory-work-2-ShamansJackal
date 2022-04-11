using OOP_lab1.Structs;
using System;

namespace OOP_lab1.Shapes
{
    public class Square : Rectangle 
    {
        public Square(int x, int y, int size) : base(x, y, size, size) { }

        public Square(Point point1, Point point2) :
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Min(Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y))
        ){ }
    }
}

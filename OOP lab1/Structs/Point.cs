using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Structs
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point ToInt() => new Point((int)X, (int)Y);

        public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);
        public static Point operator -(Point a, Point b) => new(a.X - b.X, a.Y - b.Y);
        public static Point operator *(double a, Point b) => new(a * b.X, a * b.Y);
        public static Point operator *(Point b, double a) => a*b;

        public static Point Zero => new (0, 0);
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}";
        }

    }
}

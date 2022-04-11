using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_lab1.Structs;

namespace OOP_lab1.Shapes
{
    public class Elipse : BaseShape
    {
        private const double _ratio = 1.27;
        public Elipse(int x, int y, int a, int b)
        {
            a /= 2;
            b /= 2;
            _curves = new List<BezierCurve>
            {
                new BezierCurve(new Point(x-a, y), new Point(x-a, y-b*_ratio), new Point(x+a,y-b*_ratio), new Point(x+a,y)),
                new BezierCurve(new Point(x-a, y), new Point(x-a, y+b*_ratio), new Point(x+a,y+b*_ratio), new Point(x+a,y))
            };
        }

        public Elipse(Point point1, Point point2) :
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Abs(point1.X - point2.X),
            (int)Math.Abs(point1.Y - point2.Y)
        ) {}
    }
}

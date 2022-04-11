using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_lab1.Structs;

namespace OOP_lab1.Shapes
{
    public class Rectangle : BaseShape
    {
        public Rectangle(int x, int y, int width, int height)
        {
            width /= 2;
            height /= 2;
            _curves = new List<BezierCurve>()
            {
                new BezierCurve(new Point(x-width, y-height), new Point(x+width, y-height)),
                new BezierCurve(new Point(x+width, y-height), new Point(x+width, y+height)),
                new BezierCurve(new Point(x+width, y+height), new Point(x-width, y+height)),
                new BezierCurve(new Point(x-width, y+height), new Point(x-width, y-height))
            };
        }

        public Rectangle(Point point1, Point point2) :
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Abs(point1.X - point2.X),
            (int)Math.Abs(point1.Y - point2.Y)
        ){ }
    }
}

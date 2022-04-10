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

        public Elipse() { }

        public BaseShape Build(Point point1, Point point2)
        {
            int x = (int)(point1.X - point2.X) / 2;
            int y = (int)(point1.Y - point2.Y) / 2;
            x = (int)point1.X + x;
            y = (int)point1.Y + y;
            Point p = new(x, y);
            return default;
        }
    }
}

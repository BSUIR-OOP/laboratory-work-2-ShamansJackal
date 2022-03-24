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
    }
}

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
    }
}

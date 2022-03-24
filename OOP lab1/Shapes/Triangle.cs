using OOP_lab1.Structs;
using System.Collections.Generic;

namespace OOP_lab1.Shapes
{
    public class Triangle : BaseShape 
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            _curves = new List<BezierCurve>()
            {
                new BezierCurve(new Point(x1, y1), new Point(x2, y2)),
                new BezierCurve(new Point(x2, y2), new Point(x3, y3)),
                new BezierCurve(new Point(x3, y3), new Point(x1, y1))
            };
        }
    }
}

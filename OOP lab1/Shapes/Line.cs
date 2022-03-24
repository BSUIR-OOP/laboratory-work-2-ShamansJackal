using System;
using System.Collections.Generic;
using OOP_lab1.Structs;

namespace OOP_lab1.Shapes
{
    public class Line : BaseShape 
    {
        public Line(int x1, int y1, int x2, int y2)
        {
            _curves = new List<BezierCurve>()
            {
                new BezierCurve(new Point(x1, y1), new Point(x2, y2))
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP_lab1.Structs;

namespace OOP_lab1.Shapes
{
    public class Heart : BaseShape
    {
        private const double h_ration = 0.87;
        public Heart(int x, int y, int size)
        {
            size /= 2;

            ColorOutline = PixelColors.Red;
            _curves = new List<BezierCurve>
            {
                new BezierCurve(new Point(x-size*h_ration,y), new Point(x,y+size)),
                new BezierCurve(new Point(x+size*h_ration,y), new Point(x,y+size)),
                new BezierCurve(new Point(x+size*h_ration,y), new Point(x+size*h_ration/2,y-size), new Point(x,y)),
                new BezierCurve(new Point(x-size*h_ration,y), new Point(x-size*h_ration/2,y-size), new Point(x,y))
            };
        }

        public Heart(Point point1, Point point2):
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Min(Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y))
        ){ }
    }
}

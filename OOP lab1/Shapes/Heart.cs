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
            ColorOutline = PixelColors.Red;
            _curves = new List<BezierCurve>
            {
                new BezierCurve(new Point(x-size*h_ration,y), new Point(x,y+size)),
                new BezierCurve(new Point(x+size*h_ration,y), new Point(x,y+size)),
                new BezierCurve(new Point(x+size*h_ration,y), new Point(x+size*h_ration/2,y-size), new Point(x,y)),
                new BezierCurve(new Point(x-size*h_ration,y), new Point(x-size*h_ration/2,y-size), new Point(x,y))
            };
        }
    }
}

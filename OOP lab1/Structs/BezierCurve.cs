using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Structs
{
    public class BezierCurve
    {
        private IReadOnlyList<Point> points;

        public BezierCurve(params Point[] points)
        {
            if (points.Length < 2) throw new Exception("Not enough points");
            this.points = points;
        }


        public Point Draw(double t)
        {
            Point result = Point.Zero;
            t = Math.Clamp(t, 0, 1);
            switch (points.Count)
            {
                case 2:
                    result = (1-t)*points[0]+t*points[1];
                    break;
                case 3:
                    result = ((1-t)*(1-t)*points[0]) + (2*t*(1-t)*points[1]) + (t*t*points[2]);
                    break;
                case 4:
                    result = ((1-t)*(1-t)*(1-t)*points[0]) + (3*t*(1-t)*(1-t)*points[1]) + (3*t*t*(1-t)*points[2]) + (t*t*t*points[3]);
                    break;
                default:
                    throw new NotImplementedException("Maybe later");
            }
            return result;

        }
    }
}

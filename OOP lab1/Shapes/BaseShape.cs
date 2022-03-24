using OOP_lab1.Structs;
using System.Collections.Generic;

namespace OOP_lab1.Shapes
{
    public abstract class BaseShape
    {
        private int _lineWidth = 1;
        public PixelColor Color = PixelColors.White;
        public int LineWidth
        {
            get => _lineWidth;
            set => _lineWidth = value > 0 ? value : 1;
        }
        protected IEnumerable<BezierCurve> _curves = new List<BezierCurve>();
        public IEnumerable<BezierCurve> Curves => _curves;
    }
}

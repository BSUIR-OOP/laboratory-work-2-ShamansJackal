using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Shapes
{
    public class Circle : Elipse
    {
        public Circle(int x, int y, int radius) : base(x,y,radius,radius) { }
    }
}

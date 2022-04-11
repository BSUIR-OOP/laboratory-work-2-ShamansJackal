using OOP_lab1.Enums;
using OOP_lab1.Shapes;
using OOP_lab1.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Factory
{
    public static class ShapeFactory
    {
        private static Dictionary<ShapesEnum, ConstructorInfo?> _shapesDict = new Dictionary<ShapesEnum, ConstructorInfo?>()
        {
            { ShapesEnum.Circle, typeof(Circle).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Rectangle, typeof(Rectangle).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Triangle, typeof(Triangle).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Squart, typeof(Square).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Elipse, typeof(Elipse).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Heart, typeof(Heart).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
            { ShapesEnum.Line, typeof(Line).GetConstructor(new[] { typeof(Point), typeof(Point) }) },
        };
        public static BaseShape Build(ShapesEnum shapeType, Point point1, Point point2)
        {         
            ConstructorInfo? ctor = _shapesDict[shapeType];
            
            if (ctor == null) throw new Exception($"No ctor with ({typeof(Point)}, {typeof(Point)}) in {shapeType}");

            return (BaseShape)ctor.Invoke(new object[] { point1, point2 });
        }
    }
}

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
        public static IReadOnlyDictionary<ShapesEnum, Type> ShapesDict => _shapesDict;

        private static Dictionary<ShapesEnum, Type> _shapesDict = new Dictionary<ShapesEnum, Type>()
        {
            { ShapesEnum.Circle, typeof(Circle) },
            { ShapesEnum.Rectangle, typeof(Rectangle) },
            { ShapesEnum.Triangle, typeof(Triangle) },
            { ShapesEnum.Squart, typeof(Square) },
            { ShapesEnum.Elipse, typeof(Elipse) },
            { ShapesEnum.Heart, typeof(Heart) },
            { ShapesEnum.Line, typeof(Line) },
        };
        public static BaseShape Build(ShapesEnum shapeType, Point point1, Point point2)
        {
            Type type = _shapesDict[shapeType];            
            ConstructorInfo? ctor = type.GetConstructor(new[] { typeof(Point), typeof(Point) });
            
            if (ctor == null) throw new Exception($"No ctor with ({typeof(Point)}, {typeof(Point)}) in {shapeType}");

            return (BaseShape)ctor.Invoke(new object[] { point1, point2 });
        }
    }
}

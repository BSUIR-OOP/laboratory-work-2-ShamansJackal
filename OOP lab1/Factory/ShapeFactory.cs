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
        private static Dictionary<Type, ConstructorInfo> _cache = new Dictionary<Type, ConstructorInfo>();
        public static BaseShape Build(Type shapeType, Point point1, Point point2)
        {
            if(_cache.TryGetValue(shapeType, out ConstructorInfo ctorCached)){
                return (BaseShape)ctorCached.Invoke(new object[] { point1, point2 });
            }

            if(!shapeType.IsAssignableTo(typeof(BaseShape))) throw new Exception($"{shapeType} is'n {typeof(BaseShape)}");
            ConstructorInfo? ctor = shapeType.GetConstructor(new[] { typeof(Point), typeof(Point) });

            if (ctor == null) throw new Exception($"No ctor with ({typeof(Point)}, {typeof(Point)}) in {shapeType}");
            _cache.Add(shapeType, ctor);

            return (BaseShape)ctor.Invoke(new object[] { point1, point2 });
        }
    }
}

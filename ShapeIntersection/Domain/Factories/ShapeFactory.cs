using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Shapes;

namespace ShapeIntersection.Domain.Factories
{
    public class ShapeFactory
    {
        public static IShape Create(IDimensions dimensions)
        {
            return dimensions switch
            {
                CubeDimensions cubeDimensions => new Cube(cubeDimensions),
                _ => null
            };
        }
    }
}
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Services;
using ShapeIntersection.Domain.Shapes;
using ShapeIntersection.Domain.Shapes.Primitives;

namespace ShapeIntersection.Domain.Factories
{
    public class ShapeFactory
    {
        public static IShape Create(IIntersectionService intersectionService, IDimensions dimensions)
        {
            return dimensions switch
            {
                CubeDimensions cubeDimensions => new Cube(intersectionService, cubeDimensions),
                SphereDimensions sphereDimensions => new Sphere(intersectionService, sphereDimensions),
                _ => null
            };
        }
    }
}
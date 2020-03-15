using ShapeIntersection.Domain.Shapes;

namespace ShapeIntersection.Domain.Services
{
    public class IntersectionService : IIntersectionService
    {
        public Shapes.ShapeIntersection Intersect(IShape shape1, IShape shape2)
        {
            //Simulating Intersection Mathematical Stuff with some descriptive string
            //(This service must calculate the intersection between 2 shapes of certain type)
            return new Shapes.ShapeIntersection($"Intersection result of {shape1} with {shape2}");
        }
    }
}
using ShapeIntersection.Domain.Shapes;

namespace ShapeIntersection.Domain.Services
{
    public interface IIntersectionService
    {
        public Shapes.ShapeIntersection Intersect(IShape shape1, IShape shape2);
    }
}
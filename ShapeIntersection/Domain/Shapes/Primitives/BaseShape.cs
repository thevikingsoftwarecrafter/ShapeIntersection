using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Services;

namespace ShapeIntersection.Domain.Shapes.Primitives
{
    public abstract class BaseShape<T> where T : IDimensions
    {
        protected IIntersectionService IntersectionService { get; }
        protected T Dimensions { get; }

        protected BaseShape(IIntersectionService intersectionService, T dimensions)
        {
            IntersectionService = intersectionService;
            Dimensions = dimensions;
        }
    }
}
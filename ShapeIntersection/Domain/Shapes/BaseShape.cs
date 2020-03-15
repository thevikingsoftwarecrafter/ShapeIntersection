using ShapeIntersection.Domain.Dimensions;

namespace ShapeIntersection.Domain.Shapes
{
    public abstract class BaseShape<T> where T : IDimensions
    {
        protected T Dimensions { get; }

        protected BaseShape(T dimensions)
        {
            Dimensions = dimensions;
        }
    }
}
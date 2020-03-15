using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Services;

namespace ShapeIntersection.Domain.Shapes.Primitives
{
    public class Sphere : BaseShape<SphereDimensions>, IShape
    {
        public X X => Dimensions.X;
        public Y Y => Dimensions.Y;
        public Radius Radius => Dimensions.Radius;

        public Sphere(IIntersectionService intersectionService, SphereDimensions sphereDimensions) : base(intersectionService, sphereDimensions)
        {
        }

        public ShapeIntersection IntersectWith(IShape otherShape)
        { 
            return IntersectionService.Intersect(this, otherShape);
        }

        public override string ToString()
        {
            return $"a Sphere (X = {X.Value}, Y = {Y.Value}, Radius = {Radius.Value})";
        }
    }
}
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Services;

namespace ShapeIntersection.Domain.Shapes.Primitives
{
    public class Cube : BaseShape<CubeDimensions>, IShape
    {
        public X X => Dimensions.X;
        public Y Y => Dimensions.Y;
        public Side Side => Dimensions.Side;

        public Cube(IIntersectionService intersectionService, CubeDimensions cubeDimensions) : base(intersectionService, cubeDimensions)
        {
        }

        public ShapeIntersection IntersectWith(IShape otherShape)
        { 
            return IntersectionService.Intersect(this, otherShape);
        }

        public override string ToString()
        {
            return $"a Cube (X = {X.Value}, Y = {Y.Value}, Side = {Side.Value})";
        }
    }
}
using ShapeIntersection.Domain.Dimensions;

namespace ShapeIntersection.Domain.Shapes
{
    public class Cube : BaseShape<CubeDimensions>, IShape
    {
        public X X => Dimensions.X;
        public Y Y => Dimensions.Y;
        public Side Side => Dimensions.Side;

        public Cube(CubeDimensions cubeDimensions) : base(cubeDimensions)
        {

        }
    }
}
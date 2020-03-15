using ShapeIntersection.Domain.Dimensions;

namespace ShapeIntersection.Domain.Shapes
{
    public class Cube : BaseShape<CubeDimensions>, IShape
    {
        public Cube(CubeDimensions cubeDimensions) : base(cubeDimensions)
        {

        }
    }
}
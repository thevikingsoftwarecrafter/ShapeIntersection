using ShapeIntersection.Domain.Dimensions;

namespace ShapeIntersection.Domain.Shapes
{
    public class Cube : IShape
    {
        public X X { get; }
        public Y Y { get; }
        public Side Side { get; }

        public Cube(CubeDimensions cubeDimensions)
        {
            X = cubeDimensions.X;
            Y = cubeDimensions.Y;
            Side = cubeDimensions.Side;
        }
    }
}
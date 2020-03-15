namespace ShapeIntersection.Domain.Dimensions
{
    public struct SphereDimensions : IDimensions
    {
        public X X { get; }
        public Y Y { get; }
        public Radius Radius { get; }

        public SphereDimensions(X x, Y y, Radius radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}

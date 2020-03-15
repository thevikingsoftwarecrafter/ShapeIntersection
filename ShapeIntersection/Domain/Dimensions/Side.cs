namespace ShapeIntersection.Domain.Dimensions
{
    public struct Side
    {
        public float Value { get; }

        public Side(float side)
        {
            Value = side;
        }

        public static implicit operator float(Side side) => side.Value;
    }
}
namespace ShapeIntersection.Domain.Dimensions
{
    public struct Y
    {
        public float Value { get; }

        public Y(float y)
        {
            Value = y;
        }

        public static implicit operator float(Y y) => y.Value;
    }
}
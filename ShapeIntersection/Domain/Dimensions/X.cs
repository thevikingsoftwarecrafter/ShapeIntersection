namespace ShapeIntersection.Domain.Dimensions
{
    public struct X
    {
        public float Value { get; }

        public X(float x)
        {
            Value = x;
        }

        public static implicit operator float(X x) => x.Value;
    }
}
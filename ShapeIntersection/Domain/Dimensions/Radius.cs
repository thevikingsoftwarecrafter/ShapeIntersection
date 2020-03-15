namespace ShapeIntersection.Domain.Dimensions
{
    public struct Radius
    {
        public float Value { get; }

        public Radius(float radius)
        {
            Value = radius;
        }

        public static implicit operator float(Radius radius) => radius.Value;
    }
}
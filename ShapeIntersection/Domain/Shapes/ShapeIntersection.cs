namespace ShapeIntersection.Domain.Shapes
{
    public struct ShapeIntersection
    {
        private readonly string _intersection;

        public ShapeIntersection(string intersection)
        {
            _intersection = intersection;
        }
        public override string ToString()
        {
            return _intersection;
        }
    }
}
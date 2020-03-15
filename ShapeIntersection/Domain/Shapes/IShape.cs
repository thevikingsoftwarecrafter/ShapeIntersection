namespace ShapeIntersection.Domain.Shapes
{
    public interface IShape
    {
        ShapeIntersection IntersectWith(IShape shape);
    }
}
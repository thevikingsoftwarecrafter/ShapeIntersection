using AutoFixture.Xunit2;
using FluentAssertions;
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Factories;
using ShapeIntersection.Domain.Services;
using Xunit;

namespace ShapeIntersection.Test.Domain.Shapes.Primitives
{
    public class CubeShould
    {
        [Theory, AutoData]
        public void Intersect_With_Another_Cube(float x1, float y1, float side1, float x2, float y2, float side2)
        {
            //Arrange
            var cubeDimensions1 = new CubeDimensions(new X(x1), new Y(y1), new Side(side1));
            var cubeDimensions2 = new CubeDimensions(new X(x2), new Y(y2), new Side(side2));
            var intersectionService = new IntersectionService();

            var cube1 = ShapeFactory.Create(intersectionService, cubeDimensions1);
            var cube2 = ShapeFactory.Create(intersectionService, cubeDimensions2);

            //Act
            var shapeIntersection = cube1.IntersectWith(cube2);

            //Assert
            shapeIntersection.ToString().Should().Be($"Intersection result of a Cube (X = {x1}, Y = {y1}, Side = {side1}) with a Cube (X = {x2}, Y = {y2}, Side = {side2})");
        }
    }
}
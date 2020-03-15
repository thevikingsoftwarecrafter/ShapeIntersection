using AutoFixture.Xunit2;
using FluentAssertions;
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Factories;
using ShapeIntersection.Domain.Shapes;
using Xunit;

namespace ShapeIntersection.Test
{
    public class ShapeFactoryShould
    {
        [Theory, AutoData]
        public void Create_A_New_Cube_When_Parameters_Are_Cube_Dimensions(float x, float y, float side)
        {
            //Assert
            var cubeDimensions = new CubeDimensions(new X(x), new Y(y), new Side(side));

            //Act
            var cube = ShapeFactory.Create(cubeDimensions);

            //Arrange
            cube.Should().BeOfType(typeof(Cube));
            ((Cube) cube).X.Value.Should().Be(x);
            ((Cube) cube).Y.Value.Should().Be(y);
            ((Cube) cube).Side.Value.Should().Be(side);
        }
    }
}

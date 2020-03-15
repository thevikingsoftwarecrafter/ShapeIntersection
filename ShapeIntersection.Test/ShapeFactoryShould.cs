using FluentAssertions;
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Factories;
using ShapeIntersection.Domain.Shapes;
using Xunit;

namespace ShapeIntersection.Test
{
    public class ShapeFactoryShould
    {
        [Fact]
        public void Create_A_New_Cube_When_Parameters_Are_Cube_Dimensions()
        {
            //Assert
            var x = new X(0);
            var y = new Y(0);
            var side = new Side(1);
            var cubeDimensions = new CubeDimensions(x, y, side);

            //Act
            var cube = ShapeFactory.Create(cubeDimensions);

            //Arrange
            cube.Should().BeOfType(typeof(Cube));
            ((Cube) cube).X.Should().Be(x);
            ((Cube) cube).Y.Should().Be(y);
            ((Cube) cube).Side.Should().Be(side);
        }
    }
}

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
            var cubeDimensions = new CubeDimensions(new X(0), new Y(0), new Side(1));

            //Act
            var cube = ShapeFactory.Create(cubeDimensions);

            //Arrange
            cube.Should().BeOfType(typeof(Cube));
        }
    }
}

using AutoFixture.Xunit2;
using FluentAssertions;
using NSubstitute;
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Factories;
using ShapeIntersection.Domain.Services;
using ShapeIntersection.Domain.Shapes.Primitives;
using Xunit;

namespace ShapeIntersection.Test.Domain.Factories
{
    public class ShapeFactoryShould
    {
        [Theory, AutoData]
        public void Create_A_New_Cube_When_Parameters_Are_Cube_Dimensions(float x, float y, float side)
        {
            //Arrange
            var cubeDimensions = new CubeDimensions(new X(x), new Y(y), new Side(side));
            var intersectionService = Substitute.For<IIntersectionService>();

            //Act
            var cube = ShapeFactory.Create(intersectionService, cubeDimensions);

            //Assert
            cube.Should().BeOfType(typeof(Cube));
            ((Cube) cube).X.Value.Should().Be(x);
            ((Cube) cube).Y.Value.Should().Be(y);
            ((Cube) cube).Side.Value.Should().Be(side);
        }

        [Theory, AutoData]
        public void Create_A_New_Sphere_When_Parameters_Are_Sphere_Dimensions(float x, float y, float radius)
        {
            //Arrange
            var sphereDimensions = new SphereDimensions(new X(x), new Y(y), new Radius(radius));
            var intersectionService = Substitute.For<IIntersectionService>();

            //Act
            var sphere = ShapeFactory.Create(intersectionService, sphereDimensions);

            //Assert
            sphere.Should().BeOfType(typeof(Sphere));
            ((Sphere)sphere).X.Value.Should().Be(x);
            ((Sphere)sphere).Y.Value.Should().Be(y);
            ((Sphere)sphere).Radius.Value.Should().Be(radius);
        }
    }
}

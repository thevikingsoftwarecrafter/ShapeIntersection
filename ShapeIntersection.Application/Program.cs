using System;
using ShapeIntersection.Domain.Dimensions;
using ShapeIntersection.Domain.Factories;
using ShapeIntersection.Domain.Services;
using ShapeIntersection.Domain.Shapes.Primitives;

namespace ShapeIntersection.Application
{
    public class Program
    {
        private static IIntersectionService _intersectionService;

        private static void Main(string[] args)
        {
            DependencyInyection();
            var cube1 = ShapeFactory.Create(_intersectionService, new CubeDimensions(new X(0), new Y(0), new Side(10)));
            var cube2 = ShapeFactory.Create(_intersectionService, new CubeDimensions(new X(5), new Y(5), new Side(7)));

            Console.WriteLine("Shape Intersection");
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Shape 1: {cube1}");
            Console.WriteLine($"Shape 2: {cube2}");
            Console.WriteLine();
            Console.WriteLine($"Intersection result: \n");
            Console.WriteLine($"\t{cube1.IntersectWith(cube2)}");
            Console.ReadKey();
        }

        private static void DependencyInyection()
        {
            _intersectionService = new IntersectionService();
        }
    }
}

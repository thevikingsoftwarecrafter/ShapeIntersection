﻿namespace ShapeIntersection.Domain.Dimensions
{
    public class CubeDimensions : IDimensions
    {
        public X X { get; }
        public Y Y { get; }
        public Side Side { get; }

        public CubeDimensions(X x, Y y, Side side)
        {
            X = x;
            Y = y;
            Side = side;
        }
    }
}

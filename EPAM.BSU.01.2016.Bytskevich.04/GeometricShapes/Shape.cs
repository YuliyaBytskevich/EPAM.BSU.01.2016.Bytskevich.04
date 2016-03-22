using System;

namespace GeometricShapes
{
    public abstract class Shape
    {
        public abstract double GetPerimeter();

        public double GetPerimeter(int precision)
        {
            return Math.Round(GetPerimeter(), precision);
        }

        public abstract double GetSquare();

        public double GetSquare(int precision)
        {
            return Math.Round(GetSquare(), precision);
        }

    }
}

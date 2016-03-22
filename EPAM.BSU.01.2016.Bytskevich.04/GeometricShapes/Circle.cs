using System;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be a positive value");
            this.radius = radius; 
        }

        public override double GetPerimeter()
        {
            return radius * Math.PI * 2;
        }

        public override double GetSquare()
        {
            return Math.PI*radius*radius;
        }

    }
}

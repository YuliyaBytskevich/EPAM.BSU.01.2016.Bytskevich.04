using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Square: Shape
    {
        readonly double edge;

        public Square(double edge)
        {
            if (edge <= 0)
                throw new ArgumentException("Value for square's edge must be positive");
            this.edge = edge;
        }

        public override double GetPerimeter(int? precision)
        {
            double perimeter = edge*4;
            if (precision == null)
                return perimeter;
            else
                return Math.Round(perimeter, precision.Value);
        }

        public override double GetSquare(int? precision)
        {
            double square = edge * edge;
            if (precision == null)
                return square;
            else
                return Math.Round(square, precision.Value);
        }
    }
}

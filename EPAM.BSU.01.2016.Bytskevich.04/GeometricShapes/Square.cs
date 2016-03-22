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

        public override double GetPerimeter()
        {
            return edge*4;
        }

        public override double GetSquare()
        {
            return edge * edge;
        }
    }
}

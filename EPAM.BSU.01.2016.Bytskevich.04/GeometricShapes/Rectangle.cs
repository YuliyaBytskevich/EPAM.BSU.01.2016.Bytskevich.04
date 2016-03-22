using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Rectangle: Shape
    {
        readonly double edgeA;
        readonly double edgeB;

        public Rectangle(double edgeA, double edgeB)
        {
            if (edgeA <= 0 || edgeB <= 0)
                throw new ArgumentException("Rectangle edges must be positive values");
            this.edgeA = edgeA;
            this.edgeB = edgeB;
        }

        public override double GetPerimeter()
        {
            return (edgeA + edgeB)*2;
        }

        public override double GetSquare()
        {
            return edgeA * edgeB;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeometricShapes
{
    public class Triangle: Shape
    {
        private readonly double edgeA;
        private readonly double edgeB;
        private readonly double edgeC;
        private readonly float? angleBetweenBAndA = null;

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0)
                throw new ArgumentException("Triangle edges must be positive values");
            if ( edgeA > edgeB + edgeC || edgeB > edgeA + edgeC || edgeC > edgeA + edgeB )
                throw new ArgumentException("Triangle with given edges cannot exist");
            this.edgeA = edgeA;
            this.edgeB = edgeB;
            this.edgeC = edgeC;
        }

        public Triangle(double edgeA, double edgeB, float angleBetweenEdgesInRadians)
        {
            if (edgeA <= 0 || edgeB <= 0 )
                throw new ArgumentException("Triangle edges must be positive values");
            this.edgeA = edgeA;
            this.edgeB = edgeB;
            this.angleBetweenBAndA = angleBetweenEdgesInRadians;
        }

        public override double GetPerimeter()
        {
            return edgeA + edgeB + edgeC;
        }

        public override double GetSquare()
        {
            if (angleBetweenBAndA != null)
                return edgeA*edgeB*Math.Sin((double)angleBetweenBAndA)/2;
            else
            {
                double halfPerimeter = (edgeA + edgeB + edgeC) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - edgeA) * (halfPerimeter - edgeB) * (halfPerimeter - edgeC));
            }          
        }

    }
}

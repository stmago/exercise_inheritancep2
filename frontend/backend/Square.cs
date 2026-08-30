using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        public double Side { get; }

        public Square(string name, double a) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side must be positive.");
            Side = a;
        }

        public override double GetArea() => Side * Side;
        public override double GetPerimeter() => 4 * Side;
    }
}
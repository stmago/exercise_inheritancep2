using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; }

        public Circle(string name, double r) : base(name)
        {
            if (r <= 0) throw new ArgumentException("Radius must be positive.");
            Radius = r;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : GeometricFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double Height { get; }

        public Parallelogram(string name, double a, double b, double h) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side A must be positive.");
            if (b <= 0) throw new ArgumentException("Side B must be positive.");
            if (h <= 0) throw new ArgumentException("Height must be positive.");
            SideA = a;
            SideB = b;
            Height = h;
        }

        public override double GetArea() => SideB * Height;
        public override double GetPerimeter() => 2 * (SideA + SideB);
    }
}
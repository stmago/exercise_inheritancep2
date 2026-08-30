using System;

namespace GeometricFigures.Backend
{
    public class Triangle : GeometricFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Height { get; }

        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side A must be positive.");
            if (b <= 0) throw new ArgumentException("Side B must be positive.");
            if (c <= 0) throw new ArgumentException("Side C must be positive.");
            if (h <= 0) throw new ArgumentException("Height must be positive.");
            SideA = a;
            SideB = b;
            SideC = c;
            Height = h;
        }

        // Usamos SideB como base (porque el programa principal pasa b como base)
        public override double GetArea() => (SideB * Height) / 2;
        public override double GetPerimeter() => SideA + SideB + SideC;
    }
}
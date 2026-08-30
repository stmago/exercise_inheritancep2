using System;

namespace GeometricFigures.Backend
{
    public class Kite : GeometricFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double Diagonal1 { get; }
        public double Diagonal2 { get; }

        public Kite(string name, double a, double b, double d1, double d2) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side A must be positive.");
            if (b <= 0) throw new ArgumentException("Side B must be positive.");
            if (d1 <= 0) throw new ArgumentException("Diagonal1 must be positive.");
            if (d2 <= 0) throw new ArgumentException("Diagonal2 must be positive.");
            SideA = a;
            SideB = b;
            Diagonal1 = d1;
            Diagonal2 = d2;
        }

        public override double GetArea() => (Diagonal1 * Diagonal2) / 2;
        public override double GetPerimeter() => 2 * (SideA + SideB);
    }
}
using System;

namespace GeometricFigures.Backend
{
    public class Rhombus : GeometricFigure
    {
        public double Side { get; }
        public double Diagonal1 { get; }
        public double Diagonal2 { get; }

        public Rhombus(string name, double a, double d1, double d2) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side must be positive.");
            if (d1 <= 0) throw new ArgumentException("Diagonal1 must be positive.");
            if (d2 <= 0) throw new ArgumentException("Diagonal2 must be positive.");
            Side = a;
            Diagonal1 = d1;
            Diagonal2 = d2;
        }

        public override double GetArea() => (Diagonal1 * Diagonal2) / 2;
        public override double GetPerimeter() => 4 * Side;
    }
}
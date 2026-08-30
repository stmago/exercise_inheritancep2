using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : GeometricFigure
    {
        public double SideA { get; }
        public double BaseB { get; }
        public double SideC { get; }
        public double BaseD { get; }
        public double Height { get; }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Side A must be positive.");
            if (b <= 0) throw new ArgumentException("Base B must be positive.");
            if (c <= 0) throw new ArgumentException("Side C must be positive.");
            if (d <= 0) throw new ArgumentException("Base D must be positive.");
            if (h <= 0) throw new ArgumentException("Height must be positive.");
            SideA = a;
            BaseB = b;
            SideC = c;
            BaseD = d;
            Height = h;
        }

        public override double GetArea() => ((BaseB + BaseD) * Height) / 2;
        public override double GetPerimeter() => SideA + BaseB + SideC + BaseD;
    }
}
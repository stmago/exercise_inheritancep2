using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d; // base D

        public double D
        {
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        // Trapeze tiene su propia altura (la hereda de Triangle) y sus propios lados
        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h) // llama a Triangle con a,b,c,h
        {
            D = d;
        }

        public void ValidateD(double value)
        {
            if (value <= 0) throw new ArgumentException("Base D must be positive.");
        }

        public override double GetArea() => ((B + D) * H) / 2; // B y H vienen de Triangle
        public override double GetPerimeter() => A + B + C + D;
    }
}
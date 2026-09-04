using System;

namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set
            {
                ValidateD1(value);
                _d1 = value;
            }
        }

        public double D2
        {
            get => _d2;
            set
            {
                ValidateD2(value);
                _d2 = value;
            }
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public void ValidateD1(double value)
        {
            if (value <= 0) throw new ArgumentException("Diagonal1 must be positive.");
        }

        public void ValidateD2(double value)
        {
            if (value <= 0) throw new ArgumentException("Diagonal2 must be positive.");
        }

        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;
    }
}
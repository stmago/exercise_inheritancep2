using System;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set
            {
                ValidateB(value);
                _b = value;
            }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public void ValidateB(double value)
        {
            if (value <= 0) throw new ArgumentException("Side B must be positive.");
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
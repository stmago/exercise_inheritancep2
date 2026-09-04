using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public void ValidateH(double value)
        {
            if (value <= 0) throw new ArgumentException("Height must be positive.");
        }

        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
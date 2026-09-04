using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        private double _d; 

        public double A
        {
            get => _a;
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        public double D
        {
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
            D = 0; // valor por defecto, no se usa
        }

        public void ValidateA(double value)
        {
            if (value <= 0) throw new ArgumentException("Side A must be positive.");
        }

        public void ValidateD(double value)
        {
            if (value < 0) throw new ArgumentException("D must be non-negative.");
        }

        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }
}
using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;
      
        public double R
        {
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;
            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public void ValidateR(double value)
        {
            if (value <= 0) throw new ArgumentException("Radius must be positive.");
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }
}
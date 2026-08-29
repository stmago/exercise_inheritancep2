using System;

namespace Figures.Core
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                ValidateRadius();
            }
        }

        private void ValidateRadius()
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.");
        }

        public override double GetArea() => Math.PI * radius * radius;
        public override double GetPerimeter() => 2 * Math.PI * radius;
    }
}
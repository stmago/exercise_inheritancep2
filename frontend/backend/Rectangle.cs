using System;

namespace GeometricFigures.Backend
{
    public class Rectangle : GeometricFigure
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(string name, double a, double b) : base(name)
        {
            if (a <= 0) throw new ArgumentException("Width must be positive.");
            if (b <= 0) throw new ArgumentException("Height must be positive.");
            Width = a;
            Height = b;
        }

        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
    }
}
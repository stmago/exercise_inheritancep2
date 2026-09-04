using System;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b;

        public double SideB
        {
            get => _b;
            set
            {
                if (value <= 0) throw new ArgumentException("Side B must be positive.");
                _b = value;
            }
        }

        public double SideA => A; // heredado de Square (a través de Rhombus)

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            SideB = b;
        }

        public override double GetArea() => (D1 * D2) / 2; // mismo cálculo que Rhombus
        public override double GetPerimeter() => 2 * (SideA + SideB);
    }
}
using System;

namespace Figures.Core
{
    public class Rhombus : Figure
    {
        private double diagonal1, diagonal2;

        public Rhombus(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public double Diagonal1
        {
            get => diagonal1;
            set
            {
                if (value <= 0) throw new ArgumentException("Diagonal 1 must be positive.");
                diagonal1 = value;
            }
        }

        public double Diagonal2
        {
            get => diagonal2;
            set
            {
                if (value <= 0) throw new ArgumentException("Diagonal 2 must be positive.");
                diagonal2 = value;
            }
        }

        public void ValidateD1()
        {
            if (diagonal1 <= 0)
                throw new ArgumentException("Diagonal 1 must be positive.");
        }

        public void ValidateD2()
        {
            if (diagonal2 <= 0)
                throw new ArgumentException("Diagonal 2 must be positive.");
        }

        public override double GetArea() => (diagonal1 * diagonal2) / 2;

        public override double GetPerimeter()
        {
            double halfD1 = diagonal1 / 2;
            double halfD2 = diagonal2 / 2;
            double side = Math.Sqrt(halfD1 * halfD1 + halfD2 * halfD2);
            return 4 * side;
        }
    }
}
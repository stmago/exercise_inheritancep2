using System;

namespace Figures.Core
{
    public class Kite : Figure
    {
        private double diagonal1, diagonal2;
        private double sideA, sideB;

        public Kite(double diagonal1, double diagonal2, double sideA, double sideB)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
            SideA = sideA;
            SideB = sideB;
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

        public double SideA
        {
            get => sideA;
            set
            {
                if (value <= 0) throw new ArgumentException("Side A must be positive.");
                sideA = value;
            }
        }

        public double SideB
        {
            get => sideB;
            set
            {
                if (value <= 0) throw new ArgumentException("Side B must be positive.");
                sideB = value;
            }
        }

        public override double GetArea() => (diagonal1 * diagonal2) / 2;
        public override double GetPerimeter() => 2 * (sideA + sideB);
    }
}
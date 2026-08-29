using System;

namespace Figures.Core
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC;
        private double baseLength, height;

        public Triangle(double sideA, double sideB, double sideC, double baseLength, double height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            BaseLength = baseLength;
            Height = height;
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

        public double SideC
        {
            get => sideC;
            set
            {
                if (value <= 0) throw new ArgumentException("Side C must be positive.");
                sideC = value;
            }
        }

        public double BaseLength
        {
            get => baseLength;
            set
            {
                if (value <= 0) throw new ArgumentException("Base must be positive.");
                baseLength = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0) throw new ArgumentException("Height must be positive.");
                height = value;
            }
        }

        public override double GetArea() => (baseLength * height) / 2;
        public override double GetPerimeter() => sideA + sideB + sideC;
    }
}
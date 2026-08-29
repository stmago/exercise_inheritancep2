using System;

namespace Figures.Core
{
    public class Trapezoid : Figure
    {
        private double sideA, baseB, sideC, baseD, height;

        public Trapezoid(double sideA, double baseB, double sideC, double baseD, double height)
        {
            SideA = sideA;
            BaseB = baseB;
            SideC = sideC;
            BaseD = baseD;
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

        public double BaseB
        {
            get => baseB;
            set
            {
                if (value <= 0) throw new ArgumentException("Base B must be positive.");
                baseB = value;
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

        public double BaseD
        {
            get => baseD;
            set
            {
                if (value <= 0) throw new ArgumentException("Base D must be positive.");
                baseD = value;
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

        public void ValidateD()
        {
            if (baseD <= 0)
                throw new ArgumentException("Base D must be positive.");
        }

        public override double GetArea() => ((baseB + baseD) * height) / 2;
        public override double GetPerimeter() => sideA + baseB + sideC + baseD;
    }
}
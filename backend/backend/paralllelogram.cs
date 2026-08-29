using System;

namespace Figures.Core
{
    public class Parallelogram : Figure
    {
        private double sideA;
        private double sideB; // base
        private double height;

        public Parallelogram(double sideA, double sideB, double height)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }

        public double SideA
        {
            get => sideA;
            set
            {
                sideA = value;
                ValidateA();
            }
        }

        public double SideB
        {
            get => sideB;
            set
            {
                sideB = value;
                ValidateB();
            }
        }

        public double Height
        {
            get => height;
            set
            {
                height = value;
                ValidateH();
            }
        }

        private void ValidateA()
        {
            if (sideA <= 0)
                throw new ArgumentException("Side A must be positive.");
        }

        private void ValidateB()
        {
            if (sideB <= 0)
                throw new ArgumentException("Side B must be positive.");
        }

        private void ValidateH()
        {
            if (height <= 0)
                throw new ArgumentException("Height must be positive.");
        }

        public override double GetArea() => sideB * height;
        public override double GetPerimeter() => 2 * (sideA + sideB);
    }

    public class Rectangle : Parallelogram
    {
        public Rectangle(double width, double height) : base(width, height, height) { }
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }
}
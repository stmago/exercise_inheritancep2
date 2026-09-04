using System.Globalization;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            CultureInfo us = CultureInfo.GetCultureInfo("en-US");

           
            string leftAligned = $"{Name}".PadRight(20);

     
            string areaAligned = GetArea().ToString("N5", us).PadLeft(12);
            string perimAligned = GetPerimeter().ToString("N5", us).PadLeft(12);

            return $"{leftAligned}=> Area......    {areaAligned}    Perimeter: {perimAligned}";
        }
    }
}

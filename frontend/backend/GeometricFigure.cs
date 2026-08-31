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
            // Exact format requested: "Name => Area...... 123.45678 Perimeter: 123.45678"
            // CultureInfo en-US is used so that a comma appears as the thousands separator where appropriate.
            CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            string areaStr = GetArea().ToString("N5", us);
            string perimStr = GetPerimeter().ToString("N5", us);
            return $"{Name} => Area...... {areaStr} Perimiter: {perimStr}";
        }
    }
}
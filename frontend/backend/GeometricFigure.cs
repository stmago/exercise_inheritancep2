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
            // Formato exacto pedido: "Nombre => Area...... 123.45678 Perimiter: 123.45678"
            // Se usa CultureInfo en-US para que aparezca coma como separador de miles cuando corresponda
            CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            string areaStr = GetArea().ToString("N5", us);
            string perimStr = GetPerimeter().ToString("N5", us);
            return $"{Name} => Area...... {areaStr} Perimiter: {perimStr}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometricas.Model
{
    class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double AreaRetangulo()
        {
            double area = Base * Altura;
            return area;
        }

        public double PerimetroRetangulo()
        {
            double perimetro = 2 * (Base + Altura);
            return perimetro;
        }

        public double DiagonalRetangulo()
        {
            double diagonal = Math.Sqrt(Base * Base + Altura * Altura);
            return diagonal;
        }
    }
}

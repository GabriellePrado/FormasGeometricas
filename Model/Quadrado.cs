using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometricas.Model
{
    class Quadrado
    {
        public double Lado { get; set; }

        public double AreaQuadrado()
        {
            double area = Math.Pow(Lado,2.0);
            return area;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt(2*(Math.Pow(Lado,2)));
            return diagonal;
        }
    }
}

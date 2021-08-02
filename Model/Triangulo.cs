using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometricas.Model
{
    class Triangulo
    {

        public double Altura { get; set; }
        public double Base { get; set; }

        public double AreaDoTriangulo()
        {
           double area = Base * Altura / 2;
            return area;
        }

    }
}

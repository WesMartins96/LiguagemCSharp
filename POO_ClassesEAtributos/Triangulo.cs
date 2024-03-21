using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClassesEAtributos
{
    class Triangulo
    {

        public double A;
        public double B;
        public double C;

        //calculo da area
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }

    }
}

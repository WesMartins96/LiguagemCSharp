﻿using System;
using System.Globalization;

namespace POO_ClassesEAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;

            //Criando variaveis compostas pela classe Triangulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), culture);
            x.B = double.Parse(Console.ReadLine(), culture);
            x.C = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), culture);
            y.B = double.Parse(Console.ReadLine(), culture); 
            y.C = double.Parse(Console.ReadLine(), culture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", culture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", culture)}");

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior área: X");
            }
            else
            {
                Console.WriteLine($"Maior área: Y");
            }
        }
    }
}

using System;
using System.Globalization;

namespace POO_ClassesEAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), culture);
            xB = double.Parse(Console.ReadLine(), culture);
            xC = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), culture);
            yB = double.Parse(Console.ReadLine(), culture); 
            yC = double.Parse(Console.ReadLine(), culture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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

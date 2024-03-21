using System;
using System.Globalization;

namespace EstruturaRepetitivaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), culture);

            while (x >= 0.0)
            {
                //Calcular raiz quadrada
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", culture));

                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), culture);
            }
            Console.WriteLine("Número Negativo!");


        }
    }
}

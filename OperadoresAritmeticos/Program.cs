using System;
using System.Globalization;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;

            //Regras de precedência aplicada
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            double n4 = 10.0 / 8;
            Console.WriteLine(n4.ToString("F2", culture));


            //Calculo de Baskara
            double a = 1.0, b = -3.0, c = -4.0;
            //Pow = Facilita expressões exponenciais
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            //Sqrt() = Raiz quadrada
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"Valor de delta: {delta}");
            Console.WriteLine($"Resultado da equação: {x1}");

        }
    }
}

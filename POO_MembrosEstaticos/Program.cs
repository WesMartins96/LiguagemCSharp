using System;
using System.Globalization;

namespace POO_MembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), culture);

            double circuferencia = Calculadora.Circuferencia(raio);

            Console.WriteLine($"Circuferência: {circuferencia.ToString("F2", culture)}");

            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Volume: {volume.ToString("F2", culture)}");

            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", culture)}");

        }    
    }
}

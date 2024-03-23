using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;
            //Vetores
            int n = int.Parse(Console.ReadLine());

            //Criar Vetor e instancia a partir dos numeros digitados pelo usuário n;
            double[] vect = new double[n];

            //para percorrer um vetor usa-se for
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), culture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double alturaMedia = soma / n;
            Console.WriteLine($"Altura média: {alturaMedia.ToString("F2", culture)}");

        }
    }
}

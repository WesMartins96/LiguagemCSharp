using System;
using System.Globalization;

namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;
            double preco = double.Parse(Console.ReadLine(), culture);

            double desconto;

            //usando operador ternário
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;


            //Sem usar operador ternário
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1; //10%
            //}
            //else
            //{
            //    desconto = preco * 0.05; //5%
            //}

            Console.WriteLine(desconto);
        }
    }
}

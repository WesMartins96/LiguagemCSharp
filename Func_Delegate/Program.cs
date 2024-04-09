using Func_Delegate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            //Gere uma nova lista contendo os nomes dos produtos em caixa alta.

            //usando função select do LINQ
            //modo 1 de fazer
            List<string> result = list.Select(NameUpper).ToList();

            //modo 2 de fazer
            Func<Product, string> func = NameUpper;
            List<string> result2 = list.Select(func).ToList();

            //modo 3 usando lambda
            Func<Product, string> funcLambda = p => p.Name.ToUpper();

            //modo 4 usando função lambda inLine
            List<string> resultInline = list.Select(p => p.Name.ToUpper()).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}

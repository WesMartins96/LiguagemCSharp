using Predicate_Delegate.Entities;
using System;
using System.Collections.Generic;

namespace Predicate_Delegate
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

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de produtos Atualizado!");
            //Remover da lista de produtos aqueles cujo preço minimo seja 100.00;
            //Temos estes dois exemplos de uso de predicate, fazem a mesma coisa.
            list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(RemoveProduct);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static bool RemoveProduct(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}

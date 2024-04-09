using Action_Delegate.Entities;
using System;
using System.Collections.Generic;

namespace Action_Delegate
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



            //Aumetar o preço dos produtos em 10%.
            //Modo 1 de fazer
            Action<Product> act = UpdatePrice;
            list.ForEach(act);

            //Modo 2 de fazer
            Action<Product> actLambda = p => { p.Price += p.Price * 0.1; };

            //Modo 3 de fazer
            list.ForEach(UpdatePrice);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}

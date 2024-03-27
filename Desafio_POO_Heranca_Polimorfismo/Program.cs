using Desafio_POO_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio_POO_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 
            /* Fazer um programa para ler os dados de N
            produtos (N fornecido pelo usuário). Ao final,
            mostrar a etiqueta de preço de cada produto na
            mesma ordem em que foram digitados.
            Todo produto possui nome e preço. Produtos
            importados possuem uma taxa de alfândega, e
            produtos usados possuem data de fabricação.
            Estes dados específicos devem ser
            acrescentados na etiqueta de preço conforme
            exemplo (próxima página). Para produtos
            importados, a taxa e alfândega deve ser
            acrescentada ao preço final do produto.
            */
            Console.WriteLine("--- Exercicio ---");
            Console.WriteLine();

            CultureInfo culture = CultureInfo.InvariantCulture;
            List<Product> list = new List<Product>();


            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), culture);
                

                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {                 
                    Console.Write($"Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactDate));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), culture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }            
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.PriceTag()}");
            }



            #endregion
        }
    }
}

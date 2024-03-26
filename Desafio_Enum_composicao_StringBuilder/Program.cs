using Desafio_Enum_composicao_StringBuilder.Entities;
using Desafio_Enum_composicao_StringBuilder.Entities.Enums;
using System;
using System.Globalization;

namespace Desafio_Enum_composicao_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio
            Console.WriteLine("--- Exercicio ---");
            Console.WriteLine();

            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);


            Console.WriteLine("Enter Order data:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(moment, status, client);

            Console.Write("How Many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine(), culture);
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem item = new OrderItem(prodQuantity, prodPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine(order);

            #endregion

        }
    }
}

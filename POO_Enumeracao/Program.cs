using POO_Enumeracao.Entities;
using POO_Enumeracao.Entities.Enums;
using System;

namespace POO_Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversão de enumeração para string 
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversão de string para enumeração 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}

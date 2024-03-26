using DeafioResolvido_Enum_Composicao_StringBuilder.Entities;
using System;

namespace DeafioResolvido_Enum_Composicao_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio Resolvido 2 

            Console.WriteLine("--- Exercício Resolvido 2 ---");
            Console.WriteLine();

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment co1 = new Comment("Good night");
            Comment co2 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComment(co1);
            p2.AddComment(co2);


            Console.WriteLine(p1);
            Console.WriteLine(p2);


            #endregion
        }
    }
}

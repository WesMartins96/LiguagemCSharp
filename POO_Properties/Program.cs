using System;
using System.Globalization;

namespace POO_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;

            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto.Nome);
            produto.Nome = "Playstation 5";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco.ToString("F2", culture));
            Console.WriteLine(produto.Estoque);
        }
    }
}

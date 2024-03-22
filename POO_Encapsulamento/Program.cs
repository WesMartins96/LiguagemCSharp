using System;
using System.Globalization;

namespace POO_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;
            
            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto.GetNome());
            produto.SetNome("Playstation 5");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco().ToString("F2", culture));
            Console.WriteLine(produto.GetEstoque());

        }
    }
}

using System;
using System.Globalization;

namespace POO_ClassesEAtributosII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var culture = CultureInfo.InvariantCulture;
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), culture);

            Console.Write("Quantidade no estoque: ");
            produto.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine()); 
            produto.RemoverProdutos(quantidade);

            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}

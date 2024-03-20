using System;
using System.Globalization;

namespace Desafio_EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 
            //EXERCÍCIO DE FIXAÇÃO
            /*
             * Fazer um programa para executar a seguinte interação com o
             * usuário, lendo os valores destacados em Upper, e depois mostrar na tela
             * 
             * Entre com seu nome completo:
             * ALEX GREEN
             * Quantos quartos tem na sua casa?
             * 3
             * Entre com o preço de um produto:
             * 500.50
             * Entre com seu último nome, idade e altura (na mesma linha)
             * 
             * SAÉDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS):
             * Alex Green
             * 3
             * 500.50
             * Green
             * 21
             * 1.73
            */
            #endregion

            var cultura = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quantosQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            decimal precoProduto = decimal.Parse(Console.ReadLine(), cultura);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] cadastro = Console.ReadLine().Split(' ');
            string ultimoNome = cadastro[0];
            int idade = int.Parse(cadastro[1]);
            float altura = float.Parse(cadastro[2], cultura);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantosQuartos);
            Console.WriteLine(precoProduto.ToString("F2", cultura));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", cultura));
        }
    }
}

using System;
using System.Globalization;

namespace Desafio_POO_ClassesEAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1 
            /*
             Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha
             */

            Console.WriteLine("--- Exercicio 1 ---");

            Pessoa pessoa, pessoa2;
            pessoa = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da Primeira pessoa:");

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }



            #endregion

            #region Exercicio 2
            /*
             * Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários
             */
            Console.WriteLine("--- Exercicio 2 ---");

            var culture = CultureInfo.InvariantCulture;

            Funcionario funcionario, funcionario1;
            funcionario = new Funcionario();
            funcionario1 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), culture);
           

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), culture);
            
            double salarioMedio = (funcionario.Salario + funcionario1.Salario) / 2.0;
            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", culture)}");
            #endregion
        }
    }
}

using System;
using System.Globalization;

namespace Desafio_POO_ClassesEAtributosII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
             * Fazer um programa para ler os valores da largura e altura de um retângulo.
             * Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 
             */
            Console.WriteLine("--- Exercício 1 ---");

            var culture = CultureInfo.InvariantCulture;

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), culture);
            retangulo.Altura = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine($"AREA = {retangulo.Area().ToString("F2", culture)}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro().ToString("F2", culture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2", culture)}");

            #endregion

            #region Exercicio 2 
            /*
             * Fazer um programa para ler os dados de um funcionário(nome, salário bruto e impostos).
             * Em seguida, mostrar os dados do funcionário (nome e salário liquido). Em seguida, aumentar o salário do funcionário
             * com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar
             * novamente os dados do funcionário. 
             */
            Console.WriteLine("--- Exercicio 2 ---");

            Funcionario funcionario = new Funcionario();
            
            Console.Write($"Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write($"Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), culture);
            Console.Write($"Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine();

            Console.WriteLine($"Funcionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido().ToString("F2", culture)}");
            
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), culture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine();

            Console.WriteLine(funcionario);


            #endregion

        }
    }
}

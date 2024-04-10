using Desafio_Linq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Desafio_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio
            /*Fazer um programa para ler os dados (nome, email e salário)
            de funcionários a partir de um arquivo em formato .csv.
            Em seguida mostrar, em ordem alfabética, o email dos
            funcionários cujo salário seja superior a um dado valor
            fornecido pelo usuário.
            Mostrar também a soma dos salários dos funcionários cujo
            nome começa com a letra 'M'.*/
            Console.WriteLine("--- Exercicio ---");
            Console.WriteLine();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine(); //C:\Teste_Aulas\desafio_linq\funcionarios_list.txt

            List<Funcionario> funcionarios = new List<Funcionario>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2], CultureInfo.InvariantCulture);

                    funcionarios.Add(new Funcionario(nome, email, salario));
                }
            }

            Console.Write("Enter salary: ");
            double salarioInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var emailFunc = funcionarios.Where(f => f.Salario > salarioInput).OrderBy(f => f.Nome).Select(f => f.Email);
            Console.WriteLine("Email of people whose salary is more than: " + salarioInput.ToString("F2", CultureInfo.InvariantCulture));
            foreach (var funcionario in emailFunc)
            {
                Console.WriteLine(funcionario);
            }

            var SalarySum = funcionarios.Where(f => f.Nome[0] == 'M').Sum(f => f.Salario);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + SalarySum.ToString("F2", CultureInfo.InvariantCulture));

            #endregion




        }
    }
}

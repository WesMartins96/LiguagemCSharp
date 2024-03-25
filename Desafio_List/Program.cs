using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace Desafio_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 1 
            /* 
             Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
             N funcionários. Não deve haver repetição de id.
             Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
             Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
             mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
             conforme exemplos.
             Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
             ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
             aumento por porcentagem dada.
             */
            Console.WriteLine("-- Exercício 1 ---");
            Console.WriteLine();
            var culture = CultureInfo.InvariantCulture;

            Console.Write("Quantos funcionarios serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Funcionario #{i}");

                Console.Write($"Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write($"Nome: ");
                string nome = Console.ReadLine();

                Console.Write($"Salário: ");
                double salario = double.Parse(Console.ReadLine(), culture);


                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID de quem terá o aumento de salário: ");
            int idAumento = int.Parse(Console.ReadLine());          

            Funcionario funcionario = funcionarios.Find(x => x.Id == idAumento);
            if (funcionario != null)
            {
                Console.Write("Entre com a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), culture);
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios atualizada!");
            foreach(var obj in funcionarios)
            {
                Console.WriteLine(obj);
            } 

            #endregion
        }
    }
}

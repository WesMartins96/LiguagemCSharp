using System;

namespace Desafio_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /* 
            A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelo números 0 a 9.

            Fazer um programa que inicie com todos os dez quartos vazios, e depois leia a quantidade N representando o número de estudantes 
            que vão alugar quartos (1 a 10). Em seguida, registre o aluguel dos N estudantes, Para cada registro de aluguel, informar o nome e email do estudante,
            bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de
            todas ocupações do pensionato, por ordem de quarto.
             */
            Console.WriteLine("--- Exercício 1 ---");

            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
  

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante(nome, email);
                
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }

            #endregion


        }
    }
}

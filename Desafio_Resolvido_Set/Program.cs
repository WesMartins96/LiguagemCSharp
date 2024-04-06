using Desafio_Resolvido_Set.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Desafio_Resolvido_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio Resolvido 
            /*
             Um site de internet registra um log de acessos dos usuários. 
             Um registro de log consiste no nome de usuário e o instante em que o
             usuário acessou o site no padrão ISO 8601, separados por espaço,
             Fazer um programa que leia o log de acessos apartir de um arquivo, 
             e daí informe quantos usuários distintosacessaram o site.*/

            Console.WriteLine("--- Exercicio Resolvido ---");
            Console.WriteLine();


            HashSet<LogRecord> set = new HashSet<LogRecord>();   
            
            Console.Write("Enter file full path: ");
            //C:\Teste_Aulas\myfolder\conjunto.txt
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


            #endregion





        }
    }
}

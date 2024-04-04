using Interface_IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            string path = @"C:\Teste_Aulas\myfolder\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (var emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

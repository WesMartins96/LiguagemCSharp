using System;
using System.IO;

namespace StreamWriter_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Teste_Aulas\File1.txt";
            string targetPath = @"C:\Teste_Aulas\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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

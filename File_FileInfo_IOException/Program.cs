using System;
using System.IO;

namespace File_FileInfo_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Teste_Aulas\file1.txt";
            string targetPath = @"C:\Teste_Aulas\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;

namespace TiposBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            char unicode = '\u0041';
            Console.WriteLine(unicode);
            Console.WriteLine(genero);

            sbyte x = 100;
            Console.WriteLine(x);

            byte n1 = 126;
            Console.WriteLine(n1);

            int n2 = 2147483647;
            Console.WriteLine(n2);

            long n3 = 2147483648L;
            Console.WriteLine(n3);

            float n5 = 4.5f;
            Console.WriteLine(n5);

            double n6 = 4.8;
            Console.WriteLine(n6);

            string nome = "Wesley Martins Desenvolvedor";
            Console.WriteLine(nome);

            object obj1 = "Gael Martins";
            Console.WriteLine(obj1);

            object obj2 = 5.5;
            Console.WriteLine(obj2);

            decimal n7 = decimal.MaxValue;
            Console.WriteLine(n7);

            Console.ReadKey();

        }
    }
}

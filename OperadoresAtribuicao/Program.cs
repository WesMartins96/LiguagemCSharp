using System;

namespace OperadoresAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3; 
            Console.WriteLine(a);

            string s = "abc";
            Console.WriteLine(s.ToUpper());
            s += "def";
            Console.WriteLine(s.ToUpper());


            //Operadores aritméticos / atribuição
            int num1 = 10;
            num1++;
            Console.WriteLine(num1);

            int num2 = 10;
            num2--;
            Console.WriteLine(num2);

            int x = 10;
            int y = ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}

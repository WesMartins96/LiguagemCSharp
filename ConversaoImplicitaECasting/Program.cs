using System;

namespace ConversaoImplicitaECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicíta
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);


            //Casting (Possível perda de informação)
            double a = 5.1;
            float b = (float)a;
            Console.WriteLine(b);


            //Perda de informação no casting de numero decimal para inteiro
            double dnum = 6.5;
            int inum = (int)dnum;
            Console.WriteLine(inum);


            //Casting no result para não perder informação
            int ex1 = 5;
            int ex2 = 2;
            double result = (double) ex1 / ex2;
            Console.WriteLine(result);

        }
    }
}

using System;

namespace EstruturaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom Dia!");
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("Boa Tarde!");
            }
            Console.WriteLine("Boa Noite!");


            //Verificar se o número é par ou impar
            Console.WriteLine("Entre com um número inteiro");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Este número é par");
            }
            else
            {
                Console.WriteLine("Este número é impar");
            }


            //Verifica que horas é e retorna uma mensagem
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else if(hora < 24)
            {
                Console.WriteLine("Boa Noite!");
            }
            else
            {
                Console.WriteLine("Hora Inválida");
            }

        }
    }
}

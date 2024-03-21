using System;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números e veja qual o maior entre eles:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //Criar uma função para verificar qual o número maior
            int resultado = Maior(n1, n2, n3);
            Console.WriteLine($"O maior número entre eles é o: {resultado}");
        }

        static int Maior(int n1, int n2, int n3)
        {
            int maior;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}

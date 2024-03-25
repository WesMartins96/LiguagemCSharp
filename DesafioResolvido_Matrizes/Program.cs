using System;

namespace DesafioResolvido_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio Resolvido 
            /*
            Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz.
            */
            Console.WriteLine("--- Exercício Resolvido");
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            int contagem = 0;
            //Estrutura básica para se percorrer uma matriz inteira
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.WriteLine($"Negative numbers: {contagem}");
            #endregion
        }
    }
}

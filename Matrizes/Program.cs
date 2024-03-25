using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar uma matrix, arranjo bi dimensional ((linhas →)  e (colunas ↓)) 
            double[,] mat = new double[2, 3];

            //Propriedades: Length, Rank e GetLength
            Console.WriteLine(mat.Length);

            //Rank: verifica quanto é a primeira dimensão da matriz (linhas) → 
            Console.WriteLine(mat.Rank);

            //GetLength(0) aponta para a primeira dimensão da matriz, quantidade de (linha) → 
            Console.WriteLine(mat.GetLength(0));

            //GetLength(1) aponta para a segunda dimensão da matriz, quantidade de (coluna) ↓ 
            Console.WriteLine(mat.GetLength(1));
        }
    }
}

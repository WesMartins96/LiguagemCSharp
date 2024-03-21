using System;

namespace Desafio_EstruturaRepetitivaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1 
            /*
             Escreva um prograna que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa
            a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002;
             */

            Console.WriteLine("--- Exercicio 1 ---");
            Console.WriteLine("Digite a senha de 4 digitos corretamente para ter acesso ao sistema: ");
            int senhaDigitada = int.Parse(Console.ReadLine());
            int senhaCorreta = 2002;
            

            while (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");

                Console.WriteLine("Digite novamente a senha: ");
                senhaDigitada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            #endregion

            #region Exercicio 2
            /*
             Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. 
            Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem 
            crescente ou decrescente.
             */

            Console.WriteLine("Digite dois valores e vamos dizer se foi escrito de forma crescente ou decrescente");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("DECRESCENTE");
                }
                else
                {
                    Console.WriteLine("CRESCENTE");
                }

                Console.WriteLine("Digite mais dois valores");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número iguais, Fim de Jogo");
            #endregion
        }
    }
}

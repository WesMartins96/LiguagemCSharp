using System;

namespace Desafio_EstruturaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1 
            /* 
             Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
             */

            Console.WriteLine("--- Exercicio 1 ---");
            Console.WriteLine("Digite um numero inteiro e programa dirá se é NEGATIVO ou NÃO NEGATIVO");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }else
            {
                Console.WriteLine("NEGATIVO");
            };
            #endregion

            #region Exercicio 2 
            /*
             * Fazer um programa para ler um número inteiro e dizer se este número é par ou impar.
             */

            Console.WriteLine("--- Exercicio 2 ---");
            Console.WriteLine("Digite um número inteiro para verificar se este é PAR ou IMPAR");
            int numero2 = int.Parse(Console.ReadLine());
            if(numero2 % 2 == 0)
            {
                Console.WriteLine("É PAR");
            }else
            {
                Console.WriteLine("É IMPAR");
            };
            #endregion

            #region Exercicio 3 
            /*
             Leia a hora inicial ea hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em
            um dia e terminar no outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
             */

            Console.WriteLine("--- Exercicio 3 ---");
            Console.WriteLine("Informe na mesma linha a hora de inicio do jogo e a hora final");
            string[] hora = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);

            int duracao;

            if (horaInicio < horaFinal)
            {
                duracao = horaFinal - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            #endregion
        }
    }
}

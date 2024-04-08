using Extension_Methods.Extensions;
using System;

namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 
            /*
            Vamos criar um extension method chamado "ElapsedTime()" no struct
            DateTime para apresentar um objeto DateTime na forma de tempo
            decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
            contrário. Por exemplo:
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            "4.5 hours"
            "3.2 days"*/
            Console.WriteLine("--- Exercicio Resolvido ---");
            Console.WriteLine();


            DateTime dt = new DateTime(2024, 04, 06, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());




            #endregion

            Console.WriteLine();

            #region Exercicio 2 
            /*
            Vamos criar um extension method chamado "Cut(int)" na classe String
            para receber um valor inteiro como parâmetro e gerar um recorte do
            string original daquele tamanho. Por exemplo:
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
            "Good morni..."*/
            Console.WriteLine("--- Exercicio resolvido 2 ---");
            Console.WriteLine();

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));


            #endregion 
        }
    }
}

using System;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mudar de ',' para '.' em numeros decimais
            var culture = CultureInfo.InvariantCulture;

            Console.Write("Bom Dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("--------------");

            char genero = 'F';
            int idade = 28;
            double saldo = 10.35784;
            string nome = "Wesley";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2", culture));
            Console.WriteLine(saldo.ToString("F4", culture));
            Console.WriteLine(nome);
            Console.WriteLine("--------------");


            //Placeholders, interpolação e concatenação de strings
            Console.WriteLine("{0} tem {1} anos e tem saldo atual de: R${2}", nome, idade, saldo.ToString("F2", culture));

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo atual de: {saldo:C}");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo atual de: R$" + saldo.ToString("F3", culture));

        }
    }
}

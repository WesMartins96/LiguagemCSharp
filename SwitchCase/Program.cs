using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Segunda";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 2:
                    dia = "Terça";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 3:
                    dia = "Quarta";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 4:
                    dia = "Quinta";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 5:
                    dia = "Sexta";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 6:
                    dia = "Sábado";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                case 7:
                    dia = "Domingo";
                    Console.WriteLine($"Dia da semana: {dia}");
                    break;
                default:
                    Console.WriteLine("Dia incorreto");
                    break;
            }
        }
    }
}

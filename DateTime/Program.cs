using System;
using System.Globalization;

namespace DateTime_Builders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //ticks é a representação interna do DateTime
            Console.WriteLine(d1.Ticks);

            Console.WriteLine();

            //ao total DateTime tem 12 sobrecargas
            //Abaixo as mais usadas:
            DateTime d2 = new DateTime(2023, 03, 25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2023, 03, 25, 01, 58, 03);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2023, 03, 25, 01, 58, 03, 500);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            //Horario de agora universal, Horário em Greenwich
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);


            //Usar o Parse para conversão
            //Podemos usar o formato ideal para cada banco de dados
            DateTime d7 = DateTime.Parse("2023-03-25");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2023-03-25 02:05:48");
            Console.WriteLine(d8);

            //DateTime com a formatação do Brasil
            DateTime d9 = DateTime.Parse("23/03/2024 02:07:58");
            Console.WriteLine(d9);

            //Formatar o DateTime da forms que eu determinar, usando ParseExact()
            DateTime d10 = DateTime.ParseExact("2023-03-25", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("25/03/2024 02:11:56", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

        }
    }
}

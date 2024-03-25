using System;

namespace DateTime_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2024, 3, 25, 13, 45, 38, 275);
            Console.WriteLine(d);

            //Date: Imprimir a data, desconsiderando o horario
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();

            Console.WriteLine("Formatação");
            //Formatação
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();

            //Usando mascara
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();

            Console.WriteLine("Operações com DateTime");
            DateTime dt = d.AddHours(2);
            DateTime dt2 = d.AddMinutes(3);
            DateTime dt3 = d.AddDays(7);

            Console.WriteLine(dt);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            Console.WriteLine();

            //Verificar a diferença entre datas
            DateTime data1 = new DateTime(200, 10, 18);
            DateTime data2 = new DateTime(200, 10, 15);

            TimeSpan ts = data1.Subtract(data2);
            Console.WriteLine(ts);
        }
    }
}

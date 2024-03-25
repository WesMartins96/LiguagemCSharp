using System;

namespace TimeSpan_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine();

            //Operações para pegar cada valor de um TimeSpan
            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t4);
            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Ticks: " + t4.Ticks);
            Console.WriteLine();
            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("TotalHours: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);

            Console.WriteLine();

            //Operações
            Console.WriteLine("Operações Matemáticas com TimeSpan");
            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan soma = ts1.Add(ts2);
            TimeSpan dif = ts1.Subtract(ts2);
            TimeSpan mult = ts2.Multiply(2.0);
            TimeSpan div = ts2.Divide(2.0);

            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


        }
    }
}

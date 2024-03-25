using System;

namespace TimeSpan_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                  //0 hora, 1 min, 30 seg
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); //nanosegundos

            Console.WriteLine();

            //Construtores TimeSpan
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

            Console.WriteLine();

            Console.WriteLine("TimeSpan: Métodos From");
            //Instanciar TimeSpan utilizando metodos From
                                    //1 dia e meio
            TimeSpan ts1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(ts1);

            TimeSpan ts2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(ts2);

            TimeSpan ts3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(ts3);

            TimeSpan ts4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(ts4);

            TimeSpan ts5 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(ts5);

            //Ticks só aceita Long
            TimeSpan ts6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(ts6);



        }
    }
}

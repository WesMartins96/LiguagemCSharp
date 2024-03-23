using System;

namespace POO_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usando Nullable
            Nullable<double> x = null;
            //ou
            //double? y = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Lança uma exceção se a variavel for nula, temos que usar um if
            //Console.WriteLine(x.Value);
            
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            //Operador de coalescência Nula
            double? a = null;
            double? b = 10;

            //se a variavel não tiver valor ele atribui o 5.0
            double aa = a ?? 5.0;
            double bb = b ?? 5.0;

            Console.WriteLine("Operador de coalescência Nula");
            Console.WriteLine(aa);
            Console.WriteLine(bb);


        }
    }
}

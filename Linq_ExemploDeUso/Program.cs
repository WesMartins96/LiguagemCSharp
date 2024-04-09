using System;
using System.Linq;

namespace Linq_ExemploDeUso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //expecificar o datasouce (fonte de dados)
            int[] numbers = new int[] { 1, 2, 3, 4, 5, };

            //definir a query(consulta)
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //executa a query(consulta)
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}

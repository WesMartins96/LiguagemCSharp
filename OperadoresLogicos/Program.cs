using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //&& -> As duas devem ser verdadeiras
            bool c1 = 2 > 3 && 4 != 5; // False
            Console.WriteLine(c1);


            //|| -> uma deve ser verdadeira
            bool c2 = 2 > 3 || 4 != 5; // True
            Console.WriteLine(c2);


            //! -> Nega qualquer operação de comparação
            bool c3 = !(2 > 3) && 4 != 5; // True
            Console.WriteLine(c3);


            //Regra de precedênica dos operadores lógicos
            // ! > && > ||
            bool c4 = 10 < 5; // False
            Console.WriteLine(c4);
            bool c5 = c1 || c2 && c3; 
            Console.WriteLine(c5); 
        }
    }
}

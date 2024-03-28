using System;

namespace Estrutura_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
			catch (DivideByZeroException /*e*/)
			{
                //Console.WriteLine("error!: " + e.Message);
                Console.WriteLine("Não é permitido divisão por zero!");
            }
            catch (FormatException /*e*/)
            {
                //Console.WriteLine("Fromat error!: " + e.Message);
                Console.WriteLine("Não é permitido letras nem caracteres especiais, apenas numeros!");
            }

        }
    }
}

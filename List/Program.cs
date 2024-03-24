using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listas:
            //Modos de instanciar e usar listas

            List<string> nome = new List<string>();
            nome.Add("Wesley");
            nome.Add("Gael");
            nome.Add("Beatriz");

            foreach (var item in nome)
            {
                Console.WriteLine(item);
            }

            //Intanciando uma lista já com valores atribuidos
            List<int> numeros = new List<int> { 96, 97, 3, 101 };

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}

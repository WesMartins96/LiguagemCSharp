using System;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Wesley", "Beatriz", "Gael", "Olivia" };

            //"Para cada objeto 'obj' contido em vect, faça"
            foreach (var obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

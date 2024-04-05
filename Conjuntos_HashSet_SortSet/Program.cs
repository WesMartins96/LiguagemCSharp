using System;
using System.Collections.Generic;
using System.IO;

namespace Conjuntos_HashSet_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine();

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Conjuntos_HashSet_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet
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

            Console.WriteLine();

            //SortedSet
            SortedSet<int> a = new SortedSet<int>();
            a.Add(0);
            a.Add(2);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            a.Add(8);
            a.Add(10);
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);

            //union - unir coleções sem repetição
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //intersection - elementos que existem nos conjuntos comparados
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            //difference - elementos excluidos de um dos conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

using Hash_CompararIgualdade.Entities;
using System;
using System.Collections.Generic;

namespace Hash_CompararIgualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetHashCode e Equals implementados
            HashSet<string> set = new HashSet<string>();

            set.Add("Wesley");
            set.Add("Beatriz");
            set.Add("Gael");

            Console.WriteLine(set.Contains("Beatriz"));

            Console.WriteLine();


            //GetHashCode e Equals NÃO implementados
            HashSet<Product> productA = new HashSet<Product>();
            productA.Add(new Product("Playstation 5", 3799.9));
            productA.Add(new Product("MacBook M5", 15000.9));

            HashSet<Point> point = new HashSet<Point>();
            point.Add(new Point(3, 4));
            point.Add(new Point(5, 10));


            //Criado outro objeto na memoria apontando para outro endereço na memoria
                //usando GetHashCode e Equals na classe Product ele retorna true;
            Product prod = new Product("MacBook M5", 15000.9);

            //embora os dados sejam iguais na comparação ele considera as referencias do objeto.
            Console.WriteLine(productA.Contains(prod));

            //quando o tipo é struct ele comprara pelo conteudo e não por referencia
            Point p = new Point(5, 10);
            Console.WriteLine(point.Contains(p));
        }
    }
}

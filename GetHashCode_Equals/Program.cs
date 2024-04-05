using GetHashCode_Equals.Entities;
using System;

namespace GetHashCode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equals
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));

            //GetHashCode
            string c = "Maria";
            string d = "Alex";
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());


            //comparando usuários por email
            Client clientA = new Client
            {
                Name = "Maria",
                Email = "Maria22@gmail.com"
            };

            Client clientB = new Client
            {
                Name = "Alex",
                Email = "Lele2022@yahoo.com"
            };

            Console.WriteLine(clientA.Equals(clientB));
            Console.WriteLine(clientA.GetHashCode());
            Console.WriteLine(clientB.GetHashCode());
        }
    }
}

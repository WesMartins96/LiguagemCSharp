using Exemplo_Linq_Lambda.Entities;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Exemplo_Linq_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            Console.WriteLine("TIER 1 AND PRICE < 900.0");
            //usando LINQ, consulta usando where para filtrar
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            foreach (var item in r1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("NAME OF PRODUCTS FROM TOOLS");
            //listar somente com o Name usando Select
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            foreach (var item in r2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("PRODUTOS QUE INICIAM COM A LETRA 'C'");
            //listar somente produtos que começam com a letra c
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //podemos usar um alias para dar um apelido
            foreach (var item in r3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("PRODUTOS QUE TIER SEJA 1");
            //listar somente produtos que em tier = 1, ordenando por preço e usando thenBy para ordenar por nome também.
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            foreach (var item in r4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("PRODUTOS QUE TIER SEJA 1 com SKIP 2 TAKE 4");
            //listar pulando 2 e pegando 4, usado para paginação
            var r5 = r4.Skip(2).Take(4);
            foreach (var item in r5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("FIRST OR DEFAULT");
            //listar cuidando para nao estourar um erro por valor ser nulo
            var r6 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("first of default: " + r6); // nao existe produto conforme predicado, sendo assim nao da erro e sim volta nulo.

            var r7 = products.FirstOrDefault();
            Console.WriteLine("first of default: " + r7); // pega o primeiro elemento ou o elemento default, caso tenha.

            Console.WriteLine();

            Console.WriteLine("SINGLE OR DEFAULT");
            //listar Id, como retorna apenas um valor ou nenhum é legal usar o SingleOrDefault, lembrando que só funciona se predicado retornar apenas um valor
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("single or default: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("single or default: " + r9); //usando um id que não existe no sistema, retornando nulo (vazio)

            Console.WriteLine();

            var r10 = products.Max(p => p.Price); //pega o maior valor, no caso o maior preço
            Console.WriteLine("Max: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min: " + r11);  //pega o menor valor, no caso o menor preço

            //pegar a soma dos produtos de category 1 (tools)
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("sum: " + r12);

            //pegar a media dos preços do produtos de category 1 (tools)
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average(Média): " + r13);


            Console.WriteLine();

            Console.WriteLine("AGRUPAMENTO GROUPBY");
            //agrupar os produtos por categorias.
            var r14 = products.GroupBy(p => p.Category);
            //para visualizar precisamos de um foreach especial.
            foreach (IGrouping<Category, Product> group in r14)
            {
                Console.WriteLine("GroupBy: " + group.Key.Name);
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}

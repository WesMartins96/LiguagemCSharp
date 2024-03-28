using DesafioResolvido_POO_Classes_Abstratas.Entities;
using DesafioResolvido_POO_Classes_Abstratas.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesafioResolvido_POO_Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio Resolvido 
            /*Fazer um programa para ler os dados de N figuras (N fornecido
            pelo usuário), e depois mostrar as áreas destas figuras na
            mesma ordem em que foram digitadas.*/
            Console.WriteLine("--- Exercicío Resolvido ---");
            Console.WriteLine();

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (var shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


            #endregion
        }
    }
}

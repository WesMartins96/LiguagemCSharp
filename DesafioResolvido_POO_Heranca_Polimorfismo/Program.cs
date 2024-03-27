using DesafioResolvido_POO_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesafioResolvido_POO_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicío Resolvido
            /*
            Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja-se registrar nome, horas
            trabalhadas e valor por hora. Funcionários terceirizados
            possuem ainda uma despesa adicional.
            O pagamento dos funcionários corresponde ao valor da hora
            multiplicado pelas horas trabalhadas, sendo que os
            funcionários terceirizados ainda recebem um bônus
            correspondente a 110% de sua despesa adicional.
            Fazer um programa para ler os dados de N funcionários (N
            fornecido pelo usuário) e armazená-los em uma lista. Depois
            de ler todos os dados, mostrar nome e pagamento de cada
            funcionário na mesma ordem em que foram digitados.            
             */
            Console.WriteLine("--- Exercicío Resolvido ---");
            Console.WriteLine();

            CultureInfo culture = CultureInfo.InvariantCulture;
            List<Employee> list = new List<Employee>();  

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), culture);
 
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), culture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (var emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", culture)}");
            }


            #endregion
        }
    }
}

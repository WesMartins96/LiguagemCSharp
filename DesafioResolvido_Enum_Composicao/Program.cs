using DesafioResolvido_Enum_Composicao.Entities;
using DesafioResolvido_Enum_Composicao.Entities.Enums;
using System;
using System.Globalization;

namespace DesafioResolvido_Enum_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio Resolvido 1 
            /*
             Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
             do usuário um mês e mostrar qual foi o salário do funcionário nesse mês,
             */
            Console.WriteLine("--- Exercício Resolvido 1 ---");
            Console.WriteLine();

            var culture = CultureInfo.InvariantCulture;

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), culture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime time = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), culture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(time, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", culture)}");

            #endregion
        }
    }
}

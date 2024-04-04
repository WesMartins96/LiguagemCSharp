using Desafio_Resolvido_ComInterface.Entities;
using Desafio_Resolvido_ComInterface.Services;
using System;
using System.Globalization;

namespace Desafio_Resolvido_ComInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", culture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", culture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), culture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), culture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}

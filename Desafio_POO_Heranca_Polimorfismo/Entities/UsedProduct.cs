using System;
using System.Globalization;
using System.Text;

namespace Desafio_POO_Heranca_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufectureDate) : base(name, price)
        {
            ManufactureDate = manufectureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");

            return sb.ToString();
        }

    }
}

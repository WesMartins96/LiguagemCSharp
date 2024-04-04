using System.Globalization;
using System.Text;

namespace Desafio_Resolvido_SemInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        CultureInfo culture = CultureInfo.InvariantCulture;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Basic Payment: {BasicPayment.ToString("F2", culture)}");
            sb.AppendLine($"Tax: {Tax.ToString("F2", culture)}");
            sb.AppendLine($"Total Payment: {TotalPayment.ToString("F2", culture)}");

            return sb.ToString();
                
        }

    }
}

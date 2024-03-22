using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_ClassesEAtributosII
{
    class Funcionario
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return string.Format($"Dados atualizados: {Nome}, $ {SalarioLiquido().ToString("F2", culture)}");
        }


    }
}

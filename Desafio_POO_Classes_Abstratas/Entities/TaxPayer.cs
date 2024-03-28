using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_Classes_Abstratas.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnuallIncome { get; set; }

        public TaxPayer()
        {
            
        }

        public TaxPayer(string name, double anuallIncome)
        {
            Name = name;
            AnuallIncome = anuallIncome;
        }

        public abstract double Tax();
    }
}

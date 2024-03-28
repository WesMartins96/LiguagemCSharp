using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_Classes_Abstratas.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
            
        }

        public Company(string name, double anuallIncome, int numberOfEmployees) : base(name, anuallIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnuallIncome * 0.14;
            }
            else
            {
                return AnuallIncome * 0.16;
            }
        }
    }
}

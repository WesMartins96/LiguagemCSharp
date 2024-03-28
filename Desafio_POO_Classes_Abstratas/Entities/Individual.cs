using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_Classes_Abstratas.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
            
        }

        public Individual(string name, double anuallIncome, double healthExpenditures) : base(name, anuallIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnuallIncome < 20000.0)
            {
                return AnuallIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnuallIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}

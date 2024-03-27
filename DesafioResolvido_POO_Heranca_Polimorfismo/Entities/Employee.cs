using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioResolvido_POO_Heranca_Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
            
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }


        //virtual: para liberar a operação Payment para que ela possa ser sobrescrita
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}

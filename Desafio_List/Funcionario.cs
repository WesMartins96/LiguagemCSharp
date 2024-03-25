using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_List
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }



        public Funcionario(int id, string nome, double salario) 
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }


        CultureInfo culture = CultureInfo.InvariantCulture;
        public override string ToString()
        {
            return string.Format($"{Id}, {Nome}, {Salario.ToString("F2", culture)}");
        }
    }
}

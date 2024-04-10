using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Linq.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}

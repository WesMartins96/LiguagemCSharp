using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_Properties
{
    class Conta
    {
        public string NumeroConta { private get; set; }
        public string Titular { private get; set; }
        public double Saldo { get; private set; }


        public Conta() { }

        public Conta(string numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public Conta(string numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }




        public double Deposito(double valor)
        {
            return Saldo += valor;      
        }

        public double Saque(double valor, double taxa = -5.00)
        {
            return Saldo -= valor - taxa;
        }

        CultureInfo culture = CultureInfo.InvariantCulture;
        public override string ToString()
        {
            return string.Format($"Conta {NumeroConta}, Titular {Titular}, Saldo: $ {Saldo.ToString("F2", culture)}");
        }

    }
}

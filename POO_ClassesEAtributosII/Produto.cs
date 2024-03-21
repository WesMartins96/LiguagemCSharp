using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace POO_ClassesEAtributosII
{ 

    class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        CultureInfo culture = CultureInfo.InvariantCulture;
        //Converter objeto em string
        public override string ToString()
        {
            return string.Format($"Dados do produto: {Nome}, $ {Preco.ToString("F2", culture)}, {Estoque} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", culture)}");
        }


    }
}

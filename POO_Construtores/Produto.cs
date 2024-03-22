using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Construtores
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Estoque;

        //Construtores
        public Produto()
        {
            Estoque = 10;
        }

        //Sobrecarga
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }    

        public Produto(string nome, double preco, int estoque) : this(nome, preco)
        {
            Estoque = estoque;
        }


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

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

        //Construtor
        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }


        //Sobrecarga
        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
            //poderiamos retirar a linha abaixo, pois por padrao os atributos numericos recebem o valor zero.
            Estoque = 0;
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

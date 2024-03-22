using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Encapsulamento
{
    class Produto
    {

        //quando usamos private o nome muda para _ no inicio exemplos abaixo:
        //para disponibilizarmos no programa usamos get e set para os atributos
        private string _nome;
        private double _preco;
        private int _estoque;

        //Get para disponibilizar o atributo private (_nome)
        public string GetNome()
        {
            return _nome;
        }

        //Set para ter acesso a alteração do atributo e colocando lógica encapsulando
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetEstoque()
        {
            return _estoque;
        }


        public Produto()
        {

        }

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            _preco = preco;
            _estoque = estoque;
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _estoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _estoque -= quantidade;
        }

        CultureInfo culture = CultureInfo.InvariantCulture;
        public override string ToString()
        {
            return string.Format($"Dados do produto: {_nome}, $ {_preco.ToString("F2", culture)}, {_estoque} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", culture)}");
        }


    }
}

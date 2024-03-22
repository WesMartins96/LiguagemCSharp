using System.Globalization;

namespace POO_Properties
{
    class Produto
    {
        //Ordem sugerida para implementação de membros    
        //1) Atributos privados
        private string _nome;

        //2) Propriedades auto-implementadas
        //Auto properties
        public double Preco { get; private set; }
        public int Estoque { get; private set; }

        //3) Construtores
        public Produto() { }

        public Produto(string nome, double preco, int estoque)
        {
            _nome = nome;
            Preco = preco;
            Estoque = estoque;
        }


        //4) Propriedades customizada
        //Properties
        public string Nome
        {
            //Get e Set usando properties, não usaremos o auto properties pois no set contem uma regra na lógica.
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //5) Outros métodos da classe
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
        public override string ToString()
        {
            return string.Format($"Dados do produto: {_nome}, $ {Preco.ToString("F2", culture)}, {Estoque} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", culture)}");
        }




    }
}

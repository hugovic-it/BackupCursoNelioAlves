using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console51
{
    class Produto
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get;}


        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;

        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome{
            get { return _nome; }
            set {
                if (value != null && value.Length > 1){
                    _nome = value;
                }
            }
        }


        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

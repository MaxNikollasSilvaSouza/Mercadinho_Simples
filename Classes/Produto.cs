using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Classes
{
    internal class Produto
    {
       public string Nome { get; set; }
       public string Validade { get; set; }
       public double Preco { get; set; }
       public int Codigo { get; set; }

        public Produto() { }    

        public Produto(string nome, string validade, double preco, int codigo)
        {
            this.Nome = nome;
            this.Validade = validade;
            this.Preco = preco;
            this.Codigo = codigo;
        }



    }
}

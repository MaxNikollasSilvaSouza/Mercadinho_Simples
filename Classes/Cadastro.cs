using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace Mercadinho.Classes
{
    internal class Cadastro 
    {
        static List<Produto> produtos;
       
        private string queryString = "";

        //objetos MySQL
        MySqlCommand command;        
        Connection con;

        //Objeto usado para pegar a conexao na outra classe, para eu poder fazer o cadastro nessa
        //consequentemente, se precisar mudar a conexao, eu so mexo em 1 classe inves de todas
        MySqlConnection conexao = null;

        public Cadastro() {

            con = new Connection();
            produtos= new List<Produto>();
        }
      
        public string adicionar_produto(string nome, string validade, double preco, int codigo)
        {  
            produtos.Add(new Produto(nome,validade, preco, codigo));
            string retorno = codigo.ToString() + " " + nome + " " + preco.ToString() + " " + validade;
            return retorno;
        }

        public void remover_produto(int index)
        {
            produtos.RemoveAt(index);            
        }

        public string cadastrar()
        {            
            string resp = "No";
            try
            {
                foreach (Produto p in produtos)
                {                   
                    string[] validade_format = new string[3];                        
                    validade_format  = p.Validade.Split('-');
                 
                    string data = validade_format[2].ToString() + "-" + validade_format[1].ToString() + "-" + validade_format[0].ToString();
                    queryString = con.get_insert();

                    conexao = con.get_connection();
                    con.open_conection();
                    command = new MySqlCommand(queryString, conexao);
                    command.Parameters.AddWithValue("@codigo", p.Codigo);
                    command.Parameters.AddWithValue("@nome", p.Nome) ;
                    command.Parameters.AddWithValue("@preco", p.Preco);
                    command.Parameters.AddWithValue("@validade", data);
                    command.ExecuteNonQuery();
                    con.close_conection();
                    resp = "Ok";
                }
                produtos.Clear();
            }
            catch (Exception e) { resp = e.ToString(); con.close_conection(); }
            return resp;
        }    

    }
}

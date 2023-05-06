using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mercadinho.Classes
{
    internal class update_prod
    {
        
        private string queryString = "";

        //objetos MySQL
        MySqlCommand command;
        Connection con;
        //Objeto usado para pegar a conexao na outra classe, para eu poder fazer o cadastro nessa
        //consequentemente, se precisar mudar a conexao, eu so mexo em 1 classe inves de todas
        MySqlConnection conexao = null;
        public update_prod() 
        {
            con = new Connection();
        }

        public string atualizar(int codigo, string prod_nome,double prod_preco,string validade)
        {
            string resp = "No";
            try
            {
                string[] validade_format = new string[3];
                validade_format = validade.Split('/');

                string data = validade_format[2].ToString() + "-" + validade_format[1].ToString() + "-" + validade_format[0].ToString();

                queryString = con.get_update(codigo,prod_nome, prod_preco, data);

                conexao = con.get_connection();
                con.open_conection();
                command = new MySqlCommand(queryString, conexao);              
                command.ExecuteNonQuery();
                con.close_conection();
                resp = "Ok";
            }
            catch (Exception e) { resp = e.ToString(); con.close_conection(); }
            return resp;

        }

    }
}

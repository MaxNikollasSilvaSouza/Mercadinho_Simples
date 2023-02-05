using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mercadinho.Classes
{
    internal class delete
    {
        int codigo = 0;

        private string queryString = "";

        //objetos MySQL
        MySqlCommand command;
        Connection con;
        //Objeto usado para pegar a conexao na outra classe, para eu poder fazer o cadastro nessa
        //consequentemente, se precisar mudar a conexao, eu so mexo em 1 classe inves de todas
        MySqlConnection conexao = null;

        public delete() { con = new Connection(); }

        public void set_codigo_prod(int prodd_codigo) { this.codigo = prodd_codigo; }

        public string deletar()
        {
            string resp = "No";
            try
            {
                queryString = con.get_delete(this.codigo);

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

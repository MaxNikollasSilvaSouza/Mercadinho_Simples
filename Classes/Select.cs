using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.Classes
{
    internal class Select
    {

        private string queryString = "";

        //objetos MySQL
        MySqlDataAdapter adapter;
        MySqlCommand command;
        Connection con;
        //Objeto usado para pegar a conexao na outra classe, para eu poder fazer o cadastro nessa
        //consequentemente, se precisar mudar a conexao, eu so mexo em 1 classe inves de todas
        MySqlConnection conexao = null;

        public Select() { con = new Connection(); }

        public DataTable selectDB(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
               
                if (codigo > 0)
                {
                    queryString = con.get_select(codigo);
                    
                    
                   
                    conexao = con.get_connection();
                    con.open_conection();
                    command = new MySqlCommand(queryString, conexao);
                    con.close_conection();
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                    
                    
                }

                else
                {
                    queryString = con.get_select(0);

                    conexao = con.get_connection();
                    con.open_conection();
                    command = new MySqlCommand(queryString, conexao);
                    con.close_conection();
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                
            }
            catch (Exception e) { e.ToString(); con.close_conection(); }
            return dt;
        }
    }
}

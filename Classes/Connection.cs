using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using MySql.Data;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mercadinho.Classes
{
    internal class Connection
    {
        MySqlConnection connection;
        
        //CAMINHO DA CONEXAO
        private string Connection_path = "server=localhost;database=mercadinho;Uid=root;Pwd=admin;";
        
        public Connection() { 
            connection = new MySqlConnection(Connection_path);             
        }

        //PEGA A CONEXAO PARA SER USADA NA EXECUÇÃO DO COMANDO EM CADA CLASSE, PRA NÃO PRECISAR MUDAR O CAMINHO E ETC EM CADA UMA DELAS
        public MySqlConnection get_connection() { return connection; }
        
        //ABRE A CONEXAO COM O BANCO
        public bool open_conection()
        {
            try { connection.Open(); return true; }
            catch (Exception e){ return false ; MessageBox.Show(e.ToString()); } 
        }

        //FECHA A CONEXAO COM O BANCO
        public bool close_conection()
        {
            try { connection.Close(); return true; }
            catch (Exception e) { return false ; MessageBox.Show(e.ToString()); }
        }       
        
        //AQUI EMBAIXO É SOMENTE COMANDOS SQL PARA AS CLASSES REALIZAREM OS CRUDs. SE PRECISAR MUDAR COMANDO, SÓ MEXE AQUI

        public string get_insert() 
        { 
            return @"INSERT INTO produtos 
                        (codigo, 
                         nome, 
                         preco,
                         validade) 
                    VALUES 
                        (@codigo, 
                         @nome, 
                         @preco, 
                         @validade)"; 
        }

        public string get_update(int codigo, string nome, double preco, string validade)
        {
            string query = string.Empty;

            query += "\n update                             ";
            query += "\n    produtos                        ";
            query += "\n set                                ";
            query += "\n    nome = '" + nome + "',          ";
            query += "\n    preco = " + preco + ",          ";
            query += "\n    validade = '" + validade +"'    ";
            query += "\n where                              ";
            query += "\n    codigo = " + codigo +"          ";

            return query;

        }

        public string get_delete(int codigo)
        {
            return "delete from produtos where codigo = " + codigo;
        }



    }
}

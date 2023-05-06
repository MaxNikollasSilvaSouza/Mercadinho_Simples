using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercadinho.Classes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mercadinho.Interfaces
{
    public partial class AtualizarProdutos : Form
    {
        delete Del;
        update_prod update_Prod;
        Select sel { get; set; }
        DataTable dt;
        public AtualizarProdutos()
        {
            InitializeComponent();
            timer1.Enabled= true;
            sel= new Select();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizarDataGrid();
            
        }

        private void atualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dt = new DataTable();
            if (TBCodigoProd != null && TBCodigoProd.Text.Length > 0)
            {
                try
                {
                    dt = sel.selectDB(Convert.ToInt16(TBCodigoProd.Text));
                }
                catch
                {
                    dt = sel.selectDB(0);
                }
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = sel.selectDB(0);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Refresh();
        }

       

        private void BTAtualizar_Click(object sender, EventArgs e)
        {
            update_Prod = new update_prod();

            if (TBCodigoProd.Text.Length > 0 && TBNomeProd.Text.Length > 0 && TBPrecoProd.Text.Length > 0 && DTPValidade.Value >= DateTime.Today)
            {
                update_Prod.atualizar(Convert.ToInt16(TBCodigoProd.Text), TBNomeProd.Text, Convert.ToDouble(TBPrecoProd.Text), DTPValidade.Text);

                TBNomeProd.Clear();
                TBPrecoProd.Text = "0.00";
                TBCodigoProd.Clear();
                DTPValidade.Text = DateTime.Now.ToString();
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente antes de adicionar!");
            }

           
        }

        private void BTDeletar_Click(object sender, EventArgs e)
        {
            Del = new delete();
            if(TBCodigoProd.Text.Length > 0)
            {
                try
                {
                    Del.deletar(Convert.ToInt16(TBCodigoProd.Text));
                }
                catch 
                { 
                    MessageBox.Show("Preencha todos os campos corretamente antes de adicionar!"); 
                }
            }

            atualizarDataGrid();
        }

      

        private void TBPrecoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                TBPrecoProd.Text.Replace(',', '.');
                if (char.IsLetter(e.KeyChar) == true && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }
    }
}

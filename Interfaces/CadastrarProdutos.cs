using Mercadinho.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.Interfaces
{
    public partial class CadastrarProdutos : Form
    {
        private Cadastro cad { get; set; }
      
        public CadastrarProdutos()
        {
            InitializeComponent();
            cad = new Cadastro();
            TBPrecoProd.AppendText("0.00");         
        }

        private void BTCadastrar_Click(object sender, EventArgs e)
        {
            if (LBCadastrar.Items.Count > 0)
            {
                string resposta = cad.cadastrar();
                LBCadastrar.Items.Clear();
                if (resposta == "Ok")
                {
                    MessageBox.Show("Produtos cadastrados com sucesso!");
                }
            }
            else
            { 
                MessageBox.Show("Você precisa Adicionar algum item para cadastrar"); 
            }
            
        }
       
        private void LBadicionar()
        {
           
                if (TBCodProd.Text.Length > 0 && TBNomeProd.Text.Length > 0 && TBPrecoProd.Text.Length > 0 && DTPValidade.Value >= DateTime.Today)
                {
                    string data_formato = DTPValidade.Text.Replace('/', '-');
                    string LBAdd = cad.adicionar_produto(TBNomeProd.Text, data_formato, Convert.ToDouble(TBPrecoProd.Text), Convert.ToInt16(TBCodProd.Text));
                    LBCadastrar.Items.Add(LBAdd);
                    TBNomeProd.Clear();
                    TBPrecoProd.Text ="0.00";
                    TBCodProd.Clear();
                    DTPValidade.Text = DateTime.Now.ToString();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente antes de adicionar!");
                }
           

        }

       
        private void LBremover()
        {
            cad.remover_produto(LBCadastrar.SelectedIndex);
            LBCadastrar.Items.RemoveAt(LBCadastrar.SelectedIndex);
            LBCadastrar.Refresh();
        }


        private void BTAdicionar_Click(object sender, EventArgs e)
        {
            LBadicionar();
        }

        private void LBCadastrar_DoubleClick(object sender, EventArgs e)
        {
            LBremover();
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

using Mercadinho.Classes;
using Mercadinho.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class Form1 : Form
    {
        
        private AtualizarProdutos update { get; set; }
        private delete del { get; set; }
        CadastrarProdutos CadProd { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void cad_produtos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadProd = new CadastrarProdutos();

            this.Hide();            
            CadProd.ShowDialog();
            this.Show();
        }

        private void upg_produtos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            update= new AtualizarProdutos();

            this.Hide();
            update.ShowDialog();
            this.Show();
        }

   
    }
}

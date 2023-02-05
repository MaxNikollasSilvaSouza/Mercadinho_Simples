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

namespace Mercadinho
{
    public partial class Form1 : Form
    {
        private Cadastro cad { get; set; }
        private update_prod update { get; set; }
        private delete del { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cad_produtos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cad = new Cadastro();

            cad.set_nome_prod("Macarrao");
            cad.set_preco_prod(8.00);
            cad.set_codigo_prod(289);
            cad.set_validade_prod("2010-02-12");
            string resposta = cad.cadastrar();
            MessageBox.Show(resposta);
        }

        private void upg_produtos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            update= new update_prod();

            update.set_nome_prod("Maionese");
            update.set_preco_prod(6.00);
            update.set_codigo_prod(289);
            update.set_validade_prod("2023-07-28");
            string resposta = update.atualizar();
            MessageBox.Show(resposta);
        }

        private void del_produtos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            del = new delete();

            del.set_codigo_prod(289);
            string resposta = del.deletar();
            MessageBox.Show(resposta);
        }
    }
}

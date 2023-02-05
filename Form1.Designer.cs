namespace Mercadinho
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ver_produtos = new System.Windows.Forms.LinkLabel();
            this.cad_produtos = new System.Windows.Forms.LinkLabel();
            this.del_produtos = new System.Windows.Forms.LinkLabel();
            this.upg_produtos = new System.Windows.Forms.LinkLabel();
            this.Game = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to MYMarket";
            // 
            // ver_produtos
            // 
            this.ver_produtos.AutoSize = true;
            this.ver_produtos.Location = new System.Drawing.Point(79, 61);
            this.ver_produtos.Name = "ver_produtos";
            this.ver_produtos.Size = new System.Drawing.Size(68, 13);
            this.ver_produtos.TabIndex = 5;
            this.ver_produtos.TabStop = true;
            this.ver_produtos.Text = "Ver Produtos";
            // 
            // cad_produtos
            // 
            this.cad_produtos.AutoSize = true;
            this.cad_produtos.Location = new System.Drawing.Point(65, 94);
            this.cad_produtos.Name = "cad_produtos";
            this.cad_produtos.Size = new System.Drawing.Size(97, 13);
            this.cad_produtos.TabIndex = 6;
            this.cad_produtos.TabStop = true;
            this.cad_produtos.Text = "Cadastrar Produtos";
            this.cad_produtos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cad_produtos_LinkClicked);
            // 
            // del_produtos
            // 
            this.del_produtos.AutoSize = true;
            this.del_produtos.Location = new System.Drawing.Point(79, 133);
            this.del_produtos.Name = "del_produtos";
            this.del_produtos.Size = new System.Drawing.Size(83, 13);
            this.del_produtos.TabIndex = 7;
            this.del_produtos.TabStop = true;
            this.del_produtos.Text = "Excluir Produtos";
            this.del_produtos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.del_produtos_LinkClicked);
            // 
            // upg_produtos
            // 
            this.upg_produtos.AutoSize = true;
            this.upg_produtos.Location = new System.Drawing.Point(70, 175);
            this.upg_produtos.Name = "upg_produtos";
            this.upg_produtos.Size = new System.Drawing.Size(92, 13);
            this.upg_produtos.TabIndex = 8;
            this.upg_produtos.TabStop = true;
            this.upg_produtos.Text = "Atualizar Produtos";
            this.upg_produtos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.upg_produtos_LinkClicked);
            // 
            // Game
            // 
            this.Game.AutoSize = true;
            this.Game.Location = new System.Drawing.Point(79, 209);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(75, 13);
            this.Game.TabIndex = 9;
            this.Game.TabStop = true;
            this.Game.Text = "Jogo da Velha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 255);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.upg_produtos);
            this.Controls.Add(this.del_produtos);
            this.Controls.Add(this.cad_produtos);
            this.Controls.Add(this.ver_produtos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ver_produtos;
        private System.Windows.Forms.LinkLabel cad_produtos;
        private System.Windows.Forms.LinkLabel del_produtos;
        private System.Windows.Forms.LinkLabel upg_produtos;
        private System.Windows.Forms.LinkLabel Game;
    }
}


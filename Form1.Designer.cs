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
            this.cad_produtos = new System.Windows.Forms.LinkLabel();
            this.upg_produtos = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            // cad_produtos
            // 
            this.cad_produtos.AutoSize = true;
            this.cad_produtos.Location = new System.Drawing.Point(52, 74);
            this.cad_produtos.Name = "cad_produtos";
            this.cad_produtos.Size = new System.Drawing.Size(131, 13);
            this.cad_produtos.TabIndex = 6;
            this.cad_produtos.TabStop = true;
            this.cad_produtos.Text = "Cadastrar Novos Produtos";
            this.cad_produtos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cad_produtos_LinkClicked);
            // 
            // upg_produtos
            // 
            this.upg_produtos.AutoSize = true;
            this.upg_produtos.Location = new System.Drawing.Point(70, 111);
            this.upg_produtos.Name = "upg_produtos";
            this.upg_produtos.Size = new System.Drawing.Size(81, 13);
            this.upg_produtos.TabIndex = 8;
            this.upg_produtos.TabStop = true;
            this.upg_produtos.Text = "Atualizar Dados";
            this.upg_produtos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.upg_produtos_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(34, 150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://freedomtech.netlify.app";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 255);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.upg_produtos);
            this.Controls.Add(this.cad_produtos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel cad_produtos;
        private System.Windows.Forms.LinkLabel upg_produtos;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


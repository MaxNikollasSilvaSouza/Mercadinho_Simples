namespace Mercadinho.Interfaces
{
    partial class CadastrarProdutos
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
            this.BTCadastrar = new System.Windows.Forms.Button();
            this.TBCodProd = new System.Windows.Forms.TextBox();
            this.TBNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrecoProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBCadastrar = new System.Windows.Forms.ListBox();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.DTPValidade = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Produto";
            // 
            // BTCadastrar
            // 
            this.BTCadastrar.Location = new System.Drawing.Point(28, 290);
            this.BTCadastrar.Name = "BTCadastrar";
            this.BTCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BTCadastrar.TabIndex = 1;
            this.BTCadastrar.Text = "Cadastrar";
            this.BTCadastrar.UseVisualStyleBackColor = true;
            this.BTCadastrar.Click += new System.EventHandler(this.BTCadastrar_Click);
            // 
            // TBCodProd
            // 
            this.TBCodProd.Location = new System.Drawing.Point(12, 34);
            this.TBCodProd.Name = "TBCodProd";
            this.TBCodProd.Size = new System.Drawing.Size(100, 20);
            this.TBCodProd.TabIndex = 2;
             // 
            // TBNomeProd
            // 
            this.TBNomeProd.Location = new System.Drawing.Point(12, 99);
            this.TBNomeProd.Name = "TBNomeProd";
            this.TBNomeProd.Size = new System.Drawing.Size(100, 20);
            this.TBNomeProd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Produto";
            // 
            // TBPrecoProd
            // 
            this.TBPrecoProd.Location = new System.Drawing.Point(12, 162);
            this.TBPrecoProd.Name = "TBPrecoProd";
            this.TBPrecoProd.Size = new System.Drawing.Size(100, 20);
            this.TBPrecoProd.TabIndex = 7;
            this.TBPrecoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecoProd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Validade Produto";
            // 
            // LBCadastrar
            // 
            this.LBCadastrar.FormattingEnabled = true;
            this.LBCadastrar.Location = new System.Drawing.Point(153, 9);
            this.LBCadastrar.Name = "LBCadastrar";
            this.LBCadastrar.Size = new System.Drawing.Size(244, 329);
            this.LBCadastrar.TabIndex = 10;
            this.LBCadastrar.DoubleClick += new System.EventHandler(this.LBCadastrar_DoubleClick);
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Location = new System.Drawing.Point(28, 261);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BTAdicionar.TabIndex = 11;
            this.BTAdicionar.Text = "Adicionar";
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // DTPValidade
            // 
            this.DTPValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPValidade.Location = new System.Drawing.Point(14, 220);
            this.DTPValidade.Name = "DTPValidade";
            this.DTPValidade.Size = new System.Drawing.Size(98, 20);
            this.DTPValidade.TabIndex = 12;
            // 
            // CadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 356);
            this.Controls.Add(this.DTPValidade);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.LBCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPrecoProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNomeProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCodProd);
            this.Controls.Add(this.BTCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarProdutos";
            this.Text = "CadastrarProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTCadastrar;
        private System.Windows.Forms.TextBox TBCodProd;
        private System.Windows.Forms.TextBox TBNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPrecoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LBCadastrar;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.DateTimePicker DTPValidade;
    }
}
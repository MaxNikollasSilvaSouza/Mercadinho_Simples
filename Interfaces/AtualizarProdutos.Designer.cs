namespace Mercadinho.Interfaces
{
    partial class AtualizarProdutos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBCodigoProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTAtualizar = new System.Windows.Forms.Button();
            this.DTPValidade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPrecoProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 610);
            this.dataGridView1.TabIndex = 0;
            // 
            // TBCodigoProd
            // 
            this.TBCodigoProd.Location = new System.Drawing.Point(14, 25);
            this.TBCodigoProd.Name = "TBCodigoProd";
            this.TBCodigoProd.Size = new System.Drawing.Size(100, 20);
            this.TBCodigoProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Código";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTAtualizar
            // 
            this.BTAtualizar.Location = new System.Drawing.Point(16, 251);
            this.BTAtualizar.Name = "BTAtualizar";
            this.BTAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BTAtualizar.TabIndex = 3;
            this.BTAtualizar.Text = "Atualizar";
            this.BTAtualizar.UseVisualStyleBackColor = true;
            this.BTAtualizar.Click += new System.EventHandler(this.BTAtualizar_Click);
            // 
            // DTPValidade
            // 
            this.DTPValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPValidade.Location = new System.Drawing.Point(16, 206);
            this.DTPValidade.Name = "DTPValidade";
            this.DTPValidade.Size = new System.Drawing.Size(98, 20);
            this.DTPValidade.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Validade Produto";
            // 
            // TBPrecoProd
            // 
            this.TBPrecoProd.Location = new System.Drawing.Point(14, 148);
            this.TBPrecoProd.Name = "TBPrecoProd";
            this.TBPrecoProd.Size = new System.Drawing.Size(100, 20);
            this.TBPrecoProd.TabIndex = 16;
            this.TBPrecoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecoProd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preço Produto";
            // 
            // TBNomeProd
            // 
            this.TBNomeProd.Location = new System.Drawing.Point(14, 85);
            this.TBNomeProd.Name = "TBNomeProd";
            this.TBNomeProd.Size = new System.Drawing.Size(100, 20);
            this.TBNomeProd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Produto";
            // 
            // BTDeletar
            // 
            this.BTDeletar.Location = new System.Drawing.Point(16, 290);
            this.BTDeletar.Name = "BTDeletar";
            this.BTDeletar.Size = new System.Drawing.Size(75, 23);
            this.BTDeletar.TabIndex = 19;
            this.BTDeletar.Text = "Deletar";
            this.BTDeletar.UseVisualStyleBackColor = true;
            this.BTDeletar.Click += new System.EventHandler(this.BTDeletar_Click);
            // 
            // AtualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 634);
            this.Controls.Add(this.BTDeletar);
            this.Controls.Add(this.DTPValidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPrecoProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNomeProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCodigoProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AtualizarProdutos";
            this.Text = "AtualizarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBCodigoProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTAtualizar;
        private System.Windows.Forms.DateTimePicker DTPValidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPrecoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTDeletar;
    }
}

namespace Vendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produto = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Qtd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(40, 27);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(64, 13);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "PRODUTO:";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(196, 27);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(81, 13);
            this.Quantidade.TabIndex = 1;
            this.Quantidade.Text = "QUANTIDADE:";
            this.Quantidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(325, 46);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 2;
            this.Adicionar.Text = "ADICIONAR:";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Qtd
            // 
            this.Qtd.Location = new System.Drawing.Point(199, 49);
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(100, 20);
            this.Qtd.TabIndex = 4;
            this.Qtd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 215);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(40, 358);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(45, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "TOTAL:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Notebook",
            "Mouse",
            "Monitor",
            "Teclado",
            "Memoria",
            "Computador"});
            this.comboBox1.Location = new System.Drawing.Point(43, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Produto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox Qtd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}


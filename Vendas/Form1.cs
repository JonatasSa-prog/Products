using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Entities;

namespace Vendas
{
    public partial class Form1 : Form
    {
        Products products = new Products();
        Products auxProducts = new Products(1);
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = auxProducts.Lista();
            dataGridView1.Refresh();

            label1.Text = "0";

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                
                auxProducts.AddProduct(products.GetByName(comboBox1.SelectedItem.ToString()),int.Parse(Qtd.Text));
                label1.Text = products.GetTotalPrice().ToString();
                
                this.Resetar();
            }
            catch{

            }
        }

        public void Resetar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = auxProducts.Lista();
            dataGridView1.Refresh();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

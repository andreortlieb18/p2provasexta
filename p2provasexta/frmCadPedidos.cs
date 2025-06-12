using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2provasexta
{
    public partial class frmCadPedidos : Form
    {
        public frmCadPedidos()
        {
            InitializeComponent();
        }

        private void frmCadPedidos_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("produto A");
            comboBox1.Items.Add("produto B");
            comboBox1.Items.Add("produto C");
            comboBox1.Items.Add("produto D");

            dataGridView1.Columns.Add("Produto", "Produto");
            dataGridView1.Columns.Add("Quantidade", "Quantidade");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não fui programado :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Selecione um produto e digite uma quantidade.");
                return;
            }

            string produto = comboBox1.SelectedItem.ToString();
            string quantidade = textBox1.Text;

            dataGridView1.Rows.Add(produto, quantidade);

            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu pedido foi salvo!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}

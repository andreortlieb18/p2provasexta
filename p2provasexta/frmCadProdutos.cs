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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome do Produto";
            dataGridView1.Columns[1].Name = "Preço";
            dataGridView1.Columns[2].Name = "Descrição";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string preco = textBox2.Text.Trim();
            string descricao = textBox3.Text.Trim();

            string[] row = new string[] { nome, preco, descricao };
            dataGridView1.Rows.Add(row);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}

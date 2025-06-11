using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2provasexta
{
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "CPF";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "CEP";
            dataGridView1.Columns[4].Name = "Logradouro";
            dataGridView1.Columns[5].Name = "Numero";
            dataGridView1.Columns[6].Name = "Bairro";
            dataGridView1.Columns[7].Name = "Cidade";
            dataGridView1.Columns[8].Name = "Estado";
            dataGridView1.Columns[9].Name = "Telefone";
            dataGridView1.Columns[10].Name = "Whatssap";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string CPF = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string CEP = textBox4.Text.Trim();
            string logradouro = textBox5.Text.Trim();
            string numero = textBox6.Text.Trim();
            string bairro = textBox7.Text.Trim();
            string cidade = textBox8.Text.Trim();
            string estado = textBox9.Text.Trim();
            string telefone = textBox10.Text.Trim();
            string whatsapp = textBox11.Text.Trim();

            string[] row = new string[] { nome, CPF, email, CEP, logradouro, numero, bairro, cidade, estado, telefone, whatsapp };
            dataGridView1.Rows.Add(row);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}

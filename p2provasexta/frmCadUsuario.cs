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
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            var linhas = File.ReadAllLines("usuario.csv").Skip(1);
            foreach (var line in linhas)
            {
                var partes = line.Split(',');
                listBox1.Items.Add(partes[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senha = textBox2.Text.Trim();

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha os campos.");
                return;
            }

            var linhas = File.ReadAllLines("usuarios.csv").ToList();
            if (linhas.Any(l => l.Split(',')[0] == usuario))
            {
                MessageBox.Show("usuario já existe.");
                return;
            }

            linhas.Add($"{usuario},{senha}");
            File.WriteAllLines("usuarios.csv", linhas);
            MessageBox.Show("Usuário adicionado!");
            AtualizarLista();
        }
    }
}

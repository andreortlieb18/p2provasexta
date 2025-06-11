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
    }
}

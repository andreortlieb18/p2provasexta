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
    public partial class frmPrinc : Form
    {
        public frmPrinc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadClientes frm = new frmCadClientes();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadProdutos frm = new frmCadProdutos();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadPedidos frm = new frmCadPedidos();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmConsultPedidos frm = new frmConsultPedidos();
            frm.ShowDialog();
        }
    }
}

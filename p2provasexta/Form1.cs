using System;
using System.IO;
using System.Windows.Forms;

namespace p2provasexta
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senha = textBox2.Text.Trim();

            if (usuario == "ADMIN" && senha == "123")
            {
                frmPrinc frmPrinc = new frmPrinc();
                frmPrinc.ShowDialog();
                return;
            }
        }
    }
}

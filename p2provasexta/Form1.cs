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
            string caminhoCSV = "usuario.csv";

            if (File.Exists(caminhoCSV))
            {
                bool credencialValida = false;

                using (StreamReader sr = new StreamReader(caminhoCSV))
                {
                    while (sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        string[] dados = linha.Split(',');

                        if (dados.Length == 2)
                        {
                            if (dados[0] == usuario && dados[1] == senha)
                            {
                                credencialValida = true;
                                break;
                            }
                        }
                    }
                }
                if (credencialValida)
                {
                    frmPrinc FrmPrinc = new frmPrinc();
                    FrmPrinc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}


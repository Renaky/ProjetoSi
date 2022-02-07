using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroSistemaApp
{
    public partial class btnLogin : Form
    {
        public btnLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPass.Text;
            if (usuario == "Emerson" & senha == "ifsuldeminas")
            {
                MessageBox.Show("Seja bem vindo " + usuario + "!");
                FrmSistema s = new FrmSistema();
                s.Show();
            }// fim if
            else
                MessageBox.Show("Acesso negado! Tente novamente.");
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

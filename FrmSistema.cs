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
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            
            CadClienteForm frm = new CadClienteForm();

            frm.MdiParent = this;
            frm.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            FrmConsulta frm = new FrmConsulta();

            frm.MdiParent = this;
            frm.Show();

        }

        private void FrmSistema_Load(object sender, EventArgs e)
        {
            
        }
    }
}

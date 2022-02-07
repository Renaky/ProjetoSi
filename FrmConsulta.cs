using MySql.Data.MySqlClient;
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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    String SQL = "Select * from clientes";
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, cn);

                    DataSet DS = new DataSet();

                    adapter.Fill(DS, "clientes");
                    dataGrid.DataSource = DS.Tables["clientes"];
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CadClienteForm frm = new CadClienteForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.Text = "";
            frm.lblTitulo.Text = "Alterar Cadastro";



            frm.Codigo = dataGrid.SelectedCells[0].Value.ToString();
            frm.txtName.Text = dataGrid.SelectedCells[1].Value.ToString();
            frm.maskedNasc.Text = dataGrid.SelectedCells[2].Value.ToString();
            frm.maskedTelefone.Text = dataGrid.SelectedCells[3].Value.ToString();
            frm.txtEmail.Text = dataGrid.SelectedCells[4].Value.ToString();
            frm.txtEndereco.Text = dataGrid.SelectedCells[5].Value.ToString();
            frm.maskedCpf.Text = dataGrid.SelectedCells[6].Value.ToString();

            frm.btnCadastro.Visible = false;
            frm.btnalterar.Visible = true;
            frm.ShowDialog();


        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    CadClienteForm frm = new CadClienteForm();

                    String Cod = dataGrid.SelectedCells[0].Value.ToString();
                    String SQL = "delete from clientes where Codigo =" + Cod;

                    MySqlCommand cmd = new MySqlCommand(SQL, cn);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Dados Excluídos com Sucesso!");

                    button1_Click(sender, e);
                }

                }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome like '%{0}%'", txtBusca.Text);
        }
    }
}

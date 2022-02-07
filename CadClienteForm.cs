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
    public partial class CadClienteForm : Form
    {
        public CadClienteForm()
        {
            InitializeComponent();
        }

        public String Codigo;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();


                    String SQL;
                    SQL = "Insert Into clientes(Nome,DataNasc,Telefone,Email,Endereco,Cpf) Values";
                    SQL += "('" + txtName.Text + "','" + maskedNasc.Text + "','" + maskedTelefone.Text + "','" + txtEmail.Text + "','" + txtEndereco.Text + "','" + maskedCpf.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(SQL, cn);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados com Sucesso!");
                    cn.Close();
                    txtName.Clear();
                    txtEndereco.Clear();
                    txtEmail.Clear();
                    maskedCpf.Clear();
                    maskedNasc.Clear();
                    maskedTelefone.Clear();
                 
                }
            }

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();


                    string SQL;

                    SQL = "update clientes set Nome = '"+ txtName.Text+"',";
                    SQL += "DataNasc ='" + maskedNasc.Text + "',";
                    SQL += "Telefone ='" + maskedTelefone.Text + "',";
                    SQL += "Email ='" + maskedTelefone.Text + "',";
                    SQL += "Endereco ='" + txtEndereco.Text + "',";
                    SQL += "Cpf ='" + maskedCpf.Text + "' ";
                    SQL += "Where Codigo = " + Codigo;

 

                   
                    MySqlCommand cmd = new MySqlCommand(SQL, cn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com Sucesso!");
                    
                    txtName.Clear();
                    txtEndereco.Clear();
                    txtEmail.Clear();
                    maskedCpf.Clear();
                    maskedNasc.Clear();
                    maskedTelefone.Clear();
                    cn.Close();
                }
            }

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}

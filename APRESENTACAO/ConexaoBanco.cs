using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APRESENTACAO
{
    public partial class ConexaoBanco : Form
    {
        public ConexaoBanco()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (
                string.IsNullOrEmpty(txtInstancia.Text) ||
                string.IsNullOrEmpty(txtNomeBanco.Text) ||
                string.IsNullOrEmpty(txtSenha.Text) ||
                string.IsNullOrEmpty(txtUsuario.Text)
                )
            {
                MessageBox.Show("Falta preencher um campo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Properties.Settings.Default.stringConexao = 
                    @"Server="+txtInstancia.Text+
                    ";Database="+txtNomeBanco.Text+
                    ";User Id="+txtUsuario.Text+
                    ";Password="+txtSenha.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Dados de conexão salvos com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void ConexaoBanco_Load(object sender, EventArgs e)
        {
            CarregarParametrosConexao();
        }

        private void CarregarParametrosConexao()
        {

            string strStringCompleta = Properties.Settings.Default.stringConexao;

            if (!string.IsNullOrEmpty(strStringCompleta))
            {
                string[] strStringConexao = strStringCompleta.Split(';');
                
                txtInstancia.Text = strStringConexao[0].Split('=')[1];
                txtNomeBanco.Text = strStringConexao[1].Split('=')[1];
                txtUsuario.Text = strStringConexao[2].Split('=')[1];
                txtSenha.Text = strStringConexao[3].Split('=')[1];

                txtInstancia.Enabled = false;
                txtNomeBanco.Enabled = false;
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
            }
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtInstancia.Enabled = true;
            txtNomeBanco.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
            btnSalvar.Enabled = true;
        }
    }
}

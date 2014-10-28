using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class TelaPrincipal : Form
    {
        string strHost = "localhost";
        string strPathEntrada = @"C:\ACBrNFeMonitor\ENT.TXT";
        string strPathSaida = @"C:\ACBrNFeMonitor\SAI.TXT";
        NegAcbr NegociosAcbr = new NegAcbr();

        public TelaPrincipal()
        {
            InitializeComponent();
            NegociosAcbr.strPathArquivEntradaAcbr = strPathEntrada;
            NegociosAcbr.strPathArquivSaidaAcbr = strPathSaida;
        }


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNfeAtivo_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_Ativo();
        }


        private void btnSetCertificado_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_SetCertificado(Convert.ToInt32(txtCertificadoSerie.Text));

        }

        private void btnSetAmbienteHomologacao_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_SetAmbiente(2);
        }

        private void btnSetAmbienteProducao_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_SetAmbiente(1);

        }

        private void btnLerConfiguracoes_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_LerIni();
        }

        private void btnStatusServicoNfe_Click(object sender, EventArgs e)
        {
            txtResposta.Text = NegociosAcbr.CTe_StatusServico();
        }

    }
}

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
using OBJTRANSFERENCIA;

namespace APRESENTACAO
{
    public partial class TelaTeste : Form
    {
        string strHost = "localhost";
        string strPathEntrada = @"C:\ACBrNFeMonitor\ENT.TXT";
        string strPathSaida = @"C:\ACBrNFeMonitor\SAI.TXT";
        NegAcbr NegociosAcbr = new NegAcbr();
        NegNfe NegociosNfe = new NegNfe();
        public TelaTeste()
        {
            InitializeComponent();
            NegociosAcbr.strPathArquivEntradaAcbr = strPathEntrada;
            NegociosAcbr.strPathArquivSaidaAcbr = strPathSaida;
        }

        private void btnProcXml_Click(object sender, EventArgs e)
        {

            ofdAbrirArquivo.Filter = "Arquivos XML|*.xml";
            ofdAbrirArquivo.CheckFileExists = true;
            ofdAbrirArquivo.ShowDialog();

            Veiculo objVeiculo = new Veiculo();

            objVeiculo = NegociosNfe.BuscaVeiculoNFEXml(ofdAbrirArquivo.FileName);

            txtResposta.Text =
                "Placa: " + objVeiculo.strPlaca + Environment.NewLine +
                "UF: " + objVeiculo.strUf + Environment.NewLine +
                "RNTC: " + objVeiculo.strRntc;

        }




    }
}

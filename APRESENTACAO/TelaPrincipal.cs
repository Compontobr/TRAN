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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            CarregarDiretorioMonitorado();
            IniciarMonitoramento();
        }

        private void TelaPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                icoNotificacao.Visible = true;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void icoNotificacao_Click(object sender, EventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;
            icoNotificacao.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(Location.X, Location.Y);
        }

        private void btnDiretorioMonitorado_Click(object sender, EventArgs e)
        {
            fbdDiretorio.ShowDialog();
            txtDiretorioMonitorado.Text = fbdDiretorio.SelectedPath;
            Properties.Settings.Default.DiretorioMonitoradoNFE = txtDiretorioMonitorado.Text;
            Properties.Settings.Default.Save();
            fswMonitorNfe.EnableRaisingEvents = false;
            fswMonitorNfe.Path = txtDiretorioMonitorado.Text;
            fswMonitorNfe.EnableRaisingEvents = true;
        }

        private void CarregarDiretorioMonitorado()
        {
            txtDiretorioMonitorado.Text = Properties.Settings.Default.DiretorioMonitoradoNFE;
        }
        private void IniciarMonitoramento()
        {
            if (string.IsNullOrEmpty(txtDiretorioMonitorado.Text))
                return;
            //seta o diretório monitorado para o monitor
            fswMonitorNfe.Path = @"" + txtDiretorioMonitorado.Text;
            //habilita o inicio do monitoramento
            fswMonitorNfe.EnableRaisingEvents = true;
            fswMonitorNfe.Filter = "*.xml";

            fswMonitorNfe.WaitForChanged(System.IO.WatcherChangeTypes.Created, 10000);
        }

        private void fswMonitorNfe_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            icoNotificacao.BalloonTipText = "Arquivo xml recebido!";
            icoNotificacao.BalloonTipTitle = "Mensagem";
            icoNotificacao.BalloonTipIcon = ToolTipIcon.Info;
            icoNotificacao.ShowBalloonTip(3000);
        }

    }
}

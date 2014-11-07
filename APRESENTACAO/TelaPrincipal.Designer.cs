namespace APRESENTACAO
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.icoNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiretorioMonitorado = new System.Windows.Forms.TextBox();
            this.fbdDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDiretorioMonitorado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventosMonitor = new System.Windows.Forms.TextBox();
            this.fswMonitorNfe = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fswMonitorNfe)).BeginInit();
            this.SuspendLayout();
            // 
            // icoNotificacao
            // 
            this.icoNotificacao.Icon = ((System.Drawing.Icon)(resources.GetObject("icoNotificacao.Icon")));
            this.icoNotificacao.Text = "IconeNotificacao";
            this.icoNotificacao.Visible = true;
            this.icoNotificacao.Click += new System.EventHandler(this.icoNotificacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório Monitorado";
            // 
            // txtDiretorioMonitorado
            // 
            this.txtDiretorioMonitorado.Enabled = false;
            this.txtDiretorioMonitorado.Location = new System.Drawing.Point(4, 236);
            this.txtDiretorioMonitorado.Name = "txtDiretorioMonitorado";
            this.txtDiretorioMonitorado.ReadOnly = true;
            this.txtDiretorioMonitorado.Size = new System.Drawing.Size(242, 20);
            this.txtDiretorioMonitorado.TabIndex = 2;
            // 
            // btnDiretorioMonitorado
            // 
            this.btnDiretorioMonitorado.Location = new System.Drawing.Point(252, 234);
            this.btnDiretorioMonitorado.Name = "btnDiretorioMonitorado";
            this.btnDiretorioMonitorado.Size = new System.Drawing.Size(26, 23);
            this.btnDiretorioMonitorado.TabIndex = 3;
            this.btnDiretorioMonitorado.Text = "...";
            this.btnDiretorioMonitorado.UseVisualStyleBackColor = true;
            this.btnDiretorioMonitorado.Click += new System.EventHandler(this.btnDiretorioMonitorado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log Eventos Monitor";
            // 
            // txtEventosMonitor
            // 
            this.txtEventosMonitor.Location = new System.Drawing.Point(9, 22);
            this.txtEventosMonitor.Multiline = true;
            this.txtEventosMonitor.Name = "txtEventosMonitor";
            this.txtEventosMonitor.Size = new System.Drawing.Size(269, 195);
            this.txtEventosMonitor.TabIndex = 5;
            // 
            // fswMonitorNfe
            // 
            this.fswMonitorNfe.EnableRaisingEvents = true;
            this.fswMonitorNfe.SynchronizingObject = this;
            this.fswMonitorNfe.Created += new System.IO.FileSystemEventHandler(this.fswMonitorNfe_Created);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtEventosMonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDiretorioMonitorado);
            this.Controls.Add(this.txtDiretorioMonitorado);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.Resize += new System.EventHandler(this.TelaPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fswMonitorNfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icoNotificacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretorioMonitorado;
        private System.Windows.Forms.FolderBrowserDialog fbdDiretorio;
        private System.Windows.Forms.Button btnDiretorioMonitorado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventosMonitor;
        private System.IO.FileSystemWatcher fswMonitorNfe;
    }
}
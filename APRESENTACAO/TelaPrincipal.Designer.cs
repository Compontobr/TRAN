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
            this.btnNfeAtivo = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnResposta = new System.Windows.Forms.Button();
            this.btnSetAmbienteProducao = new System.Windows.Forms.Button();
            this.btnSetAmbienteHomologacao = new System.Windows.Forms.Button();
            this.btnSetCertificado = new System.Windows.Forms.Button();
            this.txtCertificadoSerie = new System.Windows.Forms.TextBox();
            this.btnLerConfiguracoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaCertificado = new System.Windows.Forms.TextBox();
            this.btnStatusServicoNfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNfeAtivo
            // 
            this.btnNfeAtivo.Location = new System.Drawing.Point(12, 12);
            this.btnNfeAtivo.Name = "btnNfeAtivo";
            this.btnNfeAtivo.Size = new System.Drawing.Size(75, 23);
            this.btnNfeAtivo.TabIndex = 0;
            this.btnNfeAtivo.Text = "Cte Ativo";
            this.btnNfeAtivo.UseVisualStyleBackColor = true;
            this.btnNfeAtivo.Click += new System.EventHandler(this.btnNfeAtivo_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(93, 12);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(179, 238);
            this.txtResposta.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(174, 269);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // btnResposta
            // 
            this.btnResposta.Location = new System.Drawing.Point(12, 264);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(75, 23);
            this.btnResposta.TabIndex = 3;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            // 
            // btnSetAmbienteProducao
            // 
            this.btnSetAmbienteProducao.Location = new System.Drawing.Point(12, 41);
            this.btnSetAmbienteProducao.Name = "btnSetAmbienteProducao";
            this.btnSetAmbienteProducao.Size = new System.Drawing.Size(75, 23);
            this.btnSetAmbienteProducao.TabIndex = 4;
            this.btnSetAmbienteProducao.Text = "Amb. Prod.";
            this.btnSetAmbienteProducao.UseVisualStyleBackColor = true;
            this.btnSetAmbienteProducao.Click += new System.EventHandler(this.btnSetAmbienteProducao_Click);
            // 
            // btnSetAmbienteHomologacao
            // 
            this.btnSetAmbienteHomologacao.Location = new System.Drawing.Point(12, 70);
            this.btnSetAmbienteHomologacao.Name = "btnSetAmbienteHomologacao";
            this.btnSetAmbienteHomologacao.Size = new System.Drawing.Size(75, 23);
            this.btnSetAmbienteHomologacao.TabIndex = 5;
            this.btnSetAmbienteHomologacao.Text = "Amb. Hom.";
            this.btnSetAmbienteHomologacao.UseVisualStyleBackColor = true;
            this.btnSetAmbienteHomologacao.Click += new System.EventHandler(this.btnSetAmbienteHomologacao_Click);
            // 
            // btnSetCertificado
            // 
            this.btnSetCertificado.Location = new System.Drawing.Point(12, 183);
            this.btnSetCertificado.Name = "btnSetCertificado";
            this.btnSetCertificado.Size = new System.Drawing.Size(75, 23);
            this.btnSetCertificado.TabIndex = 6;
            this.btnSetCertificado.Text = "Set. Cert.";
            this.btnSetCertificado.UseVisualStyleBackColor = true;
            this.btnSetCertificado.Click += new System.EventHandler(this.btnSetCertificado_Click);
            // 
            // txtCertificadoSerie
            // 
            this.txtCertificadoSerie.Location = new System.Drawing.Point(12, 118);
            this.txtCertificadoSerie.Name = "txtCertificadoSerie";
            this.txtCertificadoSerie.Size = new System.Drawing.Size(75, 20);
            this.txtCertificadoSerie.TabIndex = 7;
            // 
            // btnLerConfiguracoes
            // 
            this.btnLerConfiguracoes.Location = new System.Drawing.Point(93, 264);
            this.btnLerConfiguracoes.Name = "btnLerConfiguracoes";
            this.btnLerConfiguracoes.Size = new System.Drawing.Size(75, 23);
            this.btnLerConfiguracoes.TabIndex = 8;
            this.btnLerConfiguracoes.Text = "Ler Conf.";
            this.btnLerConfiguracoes.UseVisualStyleBackColor = true;
            this.btnLerConfiguracoes.Click += new System.EventHandler(this.btnLerConfiguracoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Série";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // txtSenhaCertificado
            // 
            this.txtSenhaCertificado.Location = new System.Drawing.Point(12, 157);
            this.txtSenhaCertificado.Name = "txtSenhaCertificado";
            this.txtSenhaCertificado.Size = new System.Drawing.Size(75, 20);
            this.txtSenhaCertificado.TabIndex = 11;
            this.txtSenhaCertificado.UseSystemPasswordChar = true;
            // 
            // btnStatusServicoNfe
            // 
            this.btnStatusServicoNfe.Location = new System.Drawing.Point(12, 212);
            this.btnStatusServicoNfe.Name = "btnStatusServicoNfe";
            this.btnStatusServicoNfe.Size = new System.Drawing.Size(75, 23);
            this.btnStatusServicoNfe.TabIndex = 12;
            this.btnStatusServicoNfe.Text = "Status NFE";
            this.btnStatusServicoNfe.UseVisualStyleBackColor = true;
            this.btnStatusServicoNfe.Click += new System.EventHandler(this.btnStatusServicoNfe_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.btnStatusServicoNfe);
            this.Controls.Add(this.txtSenhaCertificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLerConfiguracoes);
            this.Controls.Add(this.txtCertificadoSerie);
            this.Controls.Add(this.btnSetCertificado);
            this.Controls.Add(this.btnSetAmbienteHomologacao);
            this.Controls.Add(this.btnSetAmbienteProducao);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.btnNfeAtivo);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNfeAtivo;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.Button btnSetAmbienteProducao;
        private System.Windows.Forms.Button btnSetAmbienteHomologacao;
        private System.Windows.Forms.Button btnSetCertificado;
        private System.Windows.Forms.TextBox txtCertificadoSerie;
        private System.Windows.Forms.Button btnLerConfiguracoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaCertificado;
        private System.Windows.Forms.Button btnStatusServicoNfe;
    }
}
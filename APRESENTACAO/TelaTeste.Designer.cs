namespace APRESENTACAO
{
    partial class TelaTeste
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
            this.btnProcXml = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.ofdAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnProcXml
            // 
            this.btnProcXml.Location = new System.Drawing.Point(12, 12);
            this.btnProcXml.Name = "btnProcXml";
            this.btnProcXml.Size = new System.Drawing.Size(75, 38);
            this.btnProcXml.TabIndex = 0;
            this.btnProcXml.Text = "Processar XML";
            this.btnProcXml.UseVisualStyleBackColor = true;
            this.btnProcXml.Click += new System.EventHandler(this.btnProcXml_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(93, 12);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(179, 238);
            this.txtResposta.TabIndex = 1;
            // 
            // TelaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.btnProcXml);
            this.Name = "TelaTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcXml;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArquivo;
    }
}
namespace SpedBr.AppTeste
{
    partial class ucGerarArquivo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarArquivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerarArquivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGerarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarArquivo.Location = new System.Drawing.Point(745, 479);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(90, 30);
            this.btnGerarArquivo.TabIndex = 0;
            this.btnGerarArquivo.Text = "&Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            // 
            // ucGerarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnGerarArquivo);
            this.Name = "ucGerarArquivo";
            this.Size = new System.Drawing.Size(838, 512);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarArquivo;
    }
}

namespace SpedBr.AppTeste
{
    partial class ucHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkGitHub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLinkIconPack = new System.Windows.Forms.LinkLabel();
            this.ucNotasAtualizacao1 = new SpedBr.AppTeste.ucNotasAtualizacao();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerador de declarações fiscais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPEDBr";
            // 
            // lblLinkGitHub
            // 
            this.lblLinkGitHub.AutoSize = true;
            this.lblLinkGitHub.Location = new System.Drawing.Point(32, 89);
            this.lblLinkGitHub.Name = "lblLinkGitHub";
            this.lblLinkGitHub.Size = new System.Drawing.Size(112, 13);
            this.lblLinkGitHub.TabIndex = 1;
            this.lblLinkGitHub.TabStop = true;
            this.lblLinkGitHub.Text = "1.1. Projeto no GitHub";
            this.lblLinkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGitHub_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. Locais";
            // 
            // lblLinkIconPack
            // 
            this.lblLinkIconPack.AutoSize = true;
            this.lblLinkIconPack.Location = new System.Drawing.Point(32, 109);
            this.lblLinkIconPack.Name = "lblLinkIconPack";
            this.lblLinkIconPack.Size = new System.Drawing.Size(77, 13);
            this.lblLinkIconPack.TabIndex = 3;
            this.lblLinkIconPack.TabStop = true;
            this.lblLinkIconPack.Text = "1.2. Icon Pack";
            this.lblLinkIconPack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkIconPack_LinkClicked);
            // 
            // ucNotasAtualizacao1
            // 
            this.ucNotasAtualizacao1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucNotasAtualizacao1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucNotasAtualizacao1.Location = new System.Drawing.Point(19, 188);
            this.ucNotasAtualizacao1.Name = "ucNotasAtualizacao1";
            this.ucNotasAtualizacao1.Size = new System.Drawing.Size(760, 306);
            this.ucNotasAtualizacao1.TabIndex = 4;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucNotasAtualizacao1);
            this.Controls.Add(this.lblLinkIconPack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLinkGitHub);
            this.Controls.Add(this.panel1);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(800, 530);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkGitHub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblLinkIconPack;
        private ucNotasAtualizacao ucNotasAtualizacao1;
    }
}

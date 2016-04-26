namespace SpedBr.AppTeste
{
    partial class frmMain
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
            this.toolStripStatusLabelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripRodape = new System.Windows.Forms.StatusStrip();
            this.ucLeftPanel1 = new SpedBr.AppTeste.ucLeftPanel();
            this.statusStripRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabelRodape
            // 
            this.toolStripStatusLabelRodape.Name = "toolStripStatusLabelRodape";
            this.toolStripStatusLabelRodape.Size = new System.Drawing.Size(142, 17);
            this.toolStripStatusLabelRodape.Text = "Product | Version | More...";
            // 
            // statusStripRodape
            // 
            this.statusStripRodape.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRodape});
            this.statusStripRodape.Location = new System.Drawing.Point(0, 539);
            this.statusStripRodape.Name = "statusStripRodape";
            this.statusStripRodape.Size = new System.Drawing.Size(1008, 22);
            this.statusStripRodape.TabIndex = 1;
            // 
            // ucLeftPanel1
            // 
            this.ucLeftPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLeftPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucLeftPanel1.Name = "ucLeftPanel1";
            this.ucLeftPanel1.Size = new System.Drawing.Size(1008, 561);
            this.ucLeftPanel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.statusStripRodape);
            this.Controls.Add(this.ucLeftPanel1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPEDBr";
            this.statusStripRodape.ResumeLayout(false);
            this.statusStripRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucLeftPanel ucLeftPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRodape;
        private System.Windows.Forms.StatusStrip statusStripRodape;
    }
}
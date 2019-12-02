using System;
using System.Windows.Forms;
using SpedBr.AppTeste.Utils;
using SpedBr.Common;

namespace SpedBr.AppTeste
{
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();

            this.FormClosing += (sender, args) =>
            {
                args.Cancel = this.FecharSistema();
            };

            this.Load += (sender, args) =>
            {
                AbrirFormHome();
            };

            this.btnHome.Click += PanelButtonsOnClick;

            lblStatusBarProductVersionMore.Text =
                $@"{"SPEDBr"} | Versão: {Application.ProductVersion.ToStringSafe()
                    } | Icons by flaticons.net AND icons8.com - Good Boy License";
        }

        #region Abrir Forms

        private void AbrirFormHome()
        {
            this.NovaInstanciaChildren(typeof(frmHome));
        }

        #endregion

        private void PanelButtonsOnClick(object sender, EventArgs eventArgs)
        {
            var button = sender as Button;

            if (button == null)
                return;

            string buttonTag = (string) button.Tag;
            
            if (buttonTag == "btnHome")
                AbrirFormHome();
        }

        private bool FecharSistema()
        {
            if (
                MessageBox.Show("Deseja realmente fechar o sistema?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                return false;

            return true;
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

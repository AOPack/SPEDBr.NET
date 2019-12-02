using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpedBr.AppTeste.Utils;

namespace SpedBr.AppTeste
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            InicializaFormHome();
        }

        private void InicializaFormHome()
        {
            InicializaLabels();
        }

        private void InicializaLabels()
        {
            // Label Iniciar
            var lblStartPosition = this.PointToScreen(lblDeclaracoes.Location);
            lblStartPosition = pictureBoxHomePage.PointToClient(lblStartPosition);
            lblDeclaracoes.Parent = pictureBoxHomePage;
            lblDeclaracoes.Location = lblStartPosition;
            lblDeclaracoes.BackColor = Color.Transparent;

            // Label Opção 1
            var lblOption1Position = this.PointToScreen(lblDecOption1.Location);
            lblOption1Position = pictureBoxHomePage.PointToClient(lblOption1Position);
            lblDecOption1.Parent = pictureBoxHomePage;
            lblDecOption1.Location = lblOption1Position;
            lblDecOption1.BackColor = Color.Transparent;
            lblDecOption1.Text = "Sintegra";

            // Label Opção 1 Events
            lblDecOption1.LinkClicked += (sender, args) =>
            {
                try
                {
                    //TODO: Criar form para Sintegra
                    //this.ParentForm.NovaInstanciaChildren(typeof(frmMain));
                }
                catch (Exception ex)
                {
                    FormUtils.ExibirMensagem(
                        $"Ocorreu um erro tentar abrir a janela do {lblDecOption1.Text}.{Environment.NewLine}Mensagem:{Environment.NewLine}{ex.Message}",
                        FormUtils.TipoMensagem.Erro);
                }
            };
            
            // Label Opção 2
            var lblOption2Position = this.PointToScreen(lblDecOption2.Location);
            lblOption2Position = pictureBoxHomePage.PointToClient(lblOption2Position);
            lblDecOption2.Parent = pictureBoxHomePage;
            lblDecOption2.Location = lblOption2Position;
            lblDecOption2.BackColor = Color.Transparent;
            lblDecOption2.Text = "SPED Fiscal";

            // Label Opção 2 Events
            lblDecOption2.LinkClicked += (sender, args) =>
            {
                
            };

            // Label Links
            var lblLinksPosition = this.PointToScreen(lblLinks.Location);
            lblLinksPosition = pictureBoxHomePage.PointToClient(lblLinksPosition);
            lblLinks.Parent = pictureBoxHomePage;
            lblLinks.Location = lblLinksPosition;
            lblLinks.BackColor = Color.Transparent;

            // Label Link 1
            var lblLink1Position = this.PointToScreen(lblLink1.Location);
            lblLink1Position = pictureBoxHomePage.PointToClient(lblLink1Position);
            lblLink1.Parent = pictureBoxHomePage;
            lblLink1.Location = lblLink1Position;
            lblLink1.BackColor = Color.Transparent;
            lblLink1.Text = "GitHub";

            // Label Link 1 Events
            lblLink1.LinkClicked += (sender, args) =>
            {
                Process.Start("https://github.com/samuelroliveira/SPEDBr");
            };
        }
    }
}

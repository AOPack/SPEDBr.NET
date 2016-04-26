using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpedBr.AppTeste
{
    public partial class ucHome : UserControl
    {
        private static ucHome _instancia;

        public static ucHome Instancia
        {
            get { return _instancia ?? (_instancia = new ucHome()); }
        }

        public ucHome()
        {
            InitializeComponent();
        }

        private void lblLinkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/samuelroliveira/SPEDBr");
        }

        private void lblLinkIconPack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/c/flat-color-icons");
        }

        private void ucHome_Load(object sender, EventArgs e)
        {

        }
    }
}

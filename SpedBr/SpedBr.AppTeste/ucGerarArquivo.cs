using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpedBr.AppTeste
{
    public partial class ucGerarArquivo : UserControl
    {
        private static ucGerarArquivo _instancia;

        public static ucGerarArquivo Instancia
        {
            get { return _instancia ?? (_instancia = new ucGerarArquivo()); }
        }

        public ucGerarArquivo()
        {
            InitializeComponent();
        }
    }
}

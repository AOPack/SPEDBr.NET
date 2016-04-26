using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpedBr.AppTeste.Utils;
using SpedBr.Common;

namespace SpedBr.AppTeste
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            toolStripStatusLabelRodape.Text =
                $@"{"SPEDBr"} | Versão: {Application.ProductVersion.ToStringSafe()
                    } | Icons by icons8.com - Good Boy License";
        }
    }
}

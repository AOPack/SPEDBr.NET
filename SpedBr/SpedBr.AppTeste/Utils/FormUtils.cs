using System;
using System.Windows.Forms;

namespace SpedBr.AppTeste.Utils
{
    public static class FormUtils
    {
        public enum TipoMensagem
        {
            Cancelado,
            Erro,
            Sucesso,
        }

        public static void ExibirMensagem(Exception exception)
        {
            MessageBox.Show(exception.Message, @":( Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ExibirMensagem(string texto, TipoMensagem tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagem.Cancelado:
                    MessageBox.Show(texto, @":| Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMensagem.Erro:
                    MessageBox.Show(texto, @":( Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMensagem.Sucesso:
                    MessageBox.Show(texto, @":) Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        [Obsolete]
        public static void ExibirMensagemExceptionHtml(this Form parent, Exception exception)
        {
            var browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.DocumentText = exception.Message;

            var form = new Form();
            form.Width = 700;
            form.Height = 350;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.Text = @"Falha";
            form.StartPosition = FormStartPosition.CenterParent;
            form.Controls.Add(browser);
            form.ShowDialog(parent);
        }
    }
}

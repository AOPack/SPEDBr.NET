using System;
using System.Windows.Forms;

namespace SpedBr.AppTeste.Utils
{
    public static class FormUtils
    {
        public enum TipoMensagem
        {
            Cancelamento,
            Sucesso,
        }

        public static void ExibirMensagemException(Exception exception)
        {
            MessageBox.Show(exception.Message, @":( Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ExibirMensagemException(string texto, TipoMensagem tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagem.Cancelamento:
                    MessageBox.Show(texto, @":| Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static DateTime GetFirstDayOfMonth(int year, int month)
        {
            return new DateTime(year, month, DateTime.DaysInMonth(year, month)).AddDays(1).AddMonths(-1);
        }

        public static DateTime GetLastDayOfMonth(int year, int month)
        {
            return new DateTime(year, month, DateTime.DaysInMonth(year, month)).AddHours(23).AddMinutes(59).AddSeconds(59);
        }
    }
}

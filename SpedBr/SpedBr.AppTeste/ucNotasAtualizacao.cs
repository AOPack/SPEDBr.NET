using System.Windows.Forms;

namespace SpedBr.AppTeste
{
    public partial class ucNotasAtualizacao : UserControl
    {
        public ucNotasAtualizacao()
        {
            InitializeComponent();

            webBrowser1.DocumentText =
                string.Format("<html><body>" +
                              "<b>SPEDBr - Notas de Atualização</b> -> p/ Imprimir (Ctrl + P) e p/ Pesquisar (Ctrl + F) <br>" +
                              "<br><b>VERSÃO 1.16.04.291 -------------------------------------------------------------------------------------------------</b><br>" +
                              "<br><b>SPED Fiscal</b><br>" +
                              "<br>" +
                              "Alteração no método de geração das linhas no arquivo<br>" +
                              "Implementados registros 0300, 0305, 0400, 0450, 0460, 0500, 0600.<br>" +
                              "<br><b>VERSÃO 1.16.04.261 -------------------------------------------------------------------------------------------------</b><br>" +
                              "<br><b>EFD Contribuições</b><br>" +
                              "<br>" +
                              "Implementados registros básicos para geração das informações imobiliárias no regime caixa.<br>" +
                              "<br><b>VERSÃO 1.16.02.02 -------------------------------------------------------------------------------------------------</b><br>" +
                              "<br><b>SINTEGRA</b><br>" +
                              "<br>" +
                              "Implementada versão inicial de geração do Sintegra, com registros tipo 10, 11, 50, 61 e 90.<br>" +
                              "<br><b>VERSÃO 1.15.12.06 -------------------------------------------------------------------------------------------------</b><br>" +
                              "<br><b>SPED Fiscal</b><br>" +
                              "<br>" +
                              "Implementada versão inicial de geração do SPED Fiscal, com registros básicos do Bloco 0.<br>" +
                              "</body></html>");
        }
    }
}

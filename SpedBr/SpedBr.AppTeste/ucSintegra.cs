using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using Delta.Sintegra;
using SpedBr.AppTeste.Utils;
using SpedBr.Common;
using SpedBr.OutrasDeclaracoes.Sintegra;
using Excel = Microsoft.Office.Interop.Excel;

namespace SpedBr.AppTeste
{
    public partial class ucSintegra : UserControl
    {
        private List<Registro50> _regs50;
        private List<Registro61> _regs61;

        private BackgroundWorker _bw;
        private static ucSintegra _instancia;

        public static ucSintegra Instancia
        {
            get { return _instancia ?? (_instancia = new ucSintegra()); }
        }

        public ucSintegra()
        {
            InitializeComponent();

            chkImportarExcel.Checked = false;
            lblCaminhoArquivoExcel.Enabled = false;
            txbCaminhoArquivoExcel.Enabled = false;
            btnImportarDoExcel.Enabled = false;

            dtDataInicial.Value = DateTime.Now.ObterPrimeiroDiaMesAtual();
            dtDataFinal.Value = DateTime.Now.ObterUltimoDiaMesAtual();
        }

        private void GerarSintegra(string filename, bool importarDadosExcel, bool gerarArquivoZerado = false,
            bool validarRegistros = true)
        {
            _bw = new BackgroundWorker();

            _bw.DoWork += (o, args) =>
            {
                try
                {
                    #region Indicadores

                    string codIdentificacaoEstrutura;
                    string codItentificacaoNatOperacao;
                    string codFinalidadeArquivoMagnetico;

                    if (radioButtonCodEstrut1.Checked)
                    {
                        codIdentificacaoEstrutura = "1";
                    }
                    else if (radioButtonCodEstrut2.Checked)
                    {
                        codIdentificacaoEstrutura = "2";
                    }
                    else
                    {
                        codIdentificacaoEstrutura = "3";
                    }

                    if (radioButtonCodNatOpe1.Checked)
                    {
                        codItentificacaoNatOperacao = "1";
                    }
                    else if (radioButtonCodNatOpe2.Checked)
                    {
                        codItentificacaoNatOperacao = "2";
                    }
                    else
                    {
                        codItentificacaoNatOperacao = "3";
                    }

                    if (radioButtonCodFinalidade1.Checked)
                    {
                        codFinalidadeArquivoMagnetico = "1";
                    }
                    else
                    {
                        codFinalidadeArquivoMagnetico = "2";
                    }

                    #endregion Indicadores

                    #region Montagem dos Registros

                    var r10 = new Registro10(
                        txbCnpj.Text,
                        txbIe.Text,
                        txbRazaoSocial.Text,
                        txbMunicipio.Text,
                        txbUf.Text,
                        txbFax.Text,
                        dtDataInicial.Value,
                        dtDataFinal.Value,
                        codIdentificacaoEstrutura,
                        codItentificacaoNatOperacao,
                        codFinalidadeArquivoMagnetico == "1"
                            ? FinalidadeArquivo.RemessaArquivoOriginal
                            : FinalidadeArquivo.RemessaArquivoSubstituto
                        );

                    var r11 = new Registro11(
                        txbLogradouro.Text,
                        txbNumero.Text,
                        txbComplemento.Text,
                        txbBairro.Text,
                        txbCep.Text,
                        txbNomeContato.Text,
                        txbTelefoneContato.Text
                        );

                    var linhasGeradas = new List<string>();

                    // Escreve Registro 10 - obrigatório
                    linhasGeradas.Add(r10.EscreverRegistro10(validarRegistros));

                    // Escreve Registro 11 - obrigatório
                    linhasGeradas.Add(r11.EscreverRegistro11(validarRegistros));

                    #region Leitura da Planilha em Excel p/ Obtenção das Informações

                    if (!gerarArquivoZerado)
                    {
                        if (importarDadosExcel)
                        {
                            #region Importar Dados Excel

                            if (string.IsNullOrEmpty(filename))
                                throw new Exception("O arquivo com os dados dos documentos fiscais não foi encontrado!");

                            int rCnt;
                            var xlApp = new Excel.Application();
                            var xlWorkBook = xlApp.Workbooks.Open(filename, 0, true, 5, "", "", true,
                                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                            var xlWorkSheetR50 = (Excel.Worksheet) xlWorkBook.Worksheets.Item[1];
                            var xlWorkSheetR61 = (Excel.Worksheet) xlWorkBook.Worksheets.Item[2];

                            #region Registros Tipo 50 - Notas Fiscais de Entrada/Saída

                            var rangeReg50 = xlWorkSheetR50.UsedRange;

                            _regs50 = new List<Registro50>();

                            for (rCnt = 2; rCnt <= rangeReg50.Rows.Count; rCnt++)
                            {
                                var rangeR50Cnpj = rangeReg50.Cells[rCnt, 1] as Excel.Range;
                                var rangeR50Ie = rangeReg50.Cells[rCnt, 2] as Excel.Range;
                                var rangeR50Uf = rangeReg50.Cells[rCnt, 3] as Excel.Range;
                                var rangeR50DataEmissao = rangeReg50.Cells[rCnt, 4] as Excel.Range;
                                var rangeR50Modelo = rangeReg50.Cells[rCnt, 5] as Excel.Range;
                                var rangeR50Serie = rangeReg50.Cells[rCnt, 6] as Excel.Range;
                                var rangeR50Numero = rangeReg50.Cells[rCnt, 7] as Excel.Range;
                                var rangeR50Cfop = rangeReg50.Cells[rCnt, 8] as Excel.Range;
                                var rangeR50Emitente = rangeReg50.Cells[rCnt, 9] as Excel.Range;
                                var rangeR50ValorTotal = rangeReg50.Cells[rCnt, 10] as Excel.Range;
                                var rangeR50ValorBaseIcms = rangeReg50.Cells[rCnt, 11] as Excel.Range;
                                var rangeR50ValorIcms = rangeReg50.Cells[rCnt, 12] as Excel.Range;
                                var rangeR50ValorIsenta = rangeReg50.Cells[rCnt, 13] as Excel.Range;
                                var rangeR50ValorOutras = rangeReg50.Cells[rCnt, 14] as Excel.Range;
                                var rangeR50Aliquota = rangeReg50.Cells[rCnt, 15] as Excel.Range;
                                var rangeR50Situacao = rangeReg50.Cells[rCnt, 16] as Excel.Range;

                                var objRegistro50 = new Registro50();

                                objRegistro50.CNPJ = rangeR50Cnpj.get_Value() == null
                                    ? ""
                                    : rangeR50Cnpj.get_Value().ToString();
                                objRegistro50.IE = rangeR50Ie.get_Value() == null
                                    ? ""
                                    : rangeR50Ie.get_Value().ToString();
                                objRegistro50.DATA_EMISSAO_RECEBIMENTO = rangeR50DataEmissao.get_Value() == null
                                    ? ""
                                    : Convert.ToDateTime(rangeR50DataEmissao.get_Value());
                                objRegistro50.UF = rangeR50Uf.get_Value() == null
                                    ? ""
                                    : rangeR50Uf.get_Value().ToString();
                                objRegistro50.MODELO = rangeR50Modelo.get_Value() == null
                                    ? ""
                                    : rangeR50Modelo.get_Value().ToString();
                                objRegistro50.SERIE = rangeR50Serie.get_Value() == null
                                    ? ""
                                    : rangeR50Serie.get_Value().ToString();
                                objRegistro50.NUMERO_NOTA_FISCAL = rangeR50Numero.get_Value() == null
                                    ? ""
                                    : Convert.ToInt32(rangeR50Numero.get_Value());
                                objRegistro50.CFOP = rangeR50Cfop.get_Value() == null
                                    ? ""
                                    : Convert.ToInt32(rangeR50Cfop.get_Value());
                                objRegistro50.EMITENTE = rangeR50Emitente.get_Value() == null
                                    ? ""
                                    : rangeR50Emitente.get_Value().ToString();
                                objRegistro50.VALOR_TOTAL = rangeR50ValorTotal.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50ValorTotal.get_Value());
                                objRegistro50.BASE_CALC_ICMS = rangeR50ValorBaseIcms.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50ValorBaseIcms.get_Value());
                                objRegistro50.VALOR_ICMS = rangeR50ValorIcms.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50ValorIcms.get_Value());
                                objRegistro50.VALOR_ISENTA_NTRIBUT = rangeR50ValorIsenta.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50ValorIsenta.get_Value());
                                objRegistro50.OUTRAS = rangeR50ValorOutras.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50ValorOutras.get_Value());
                                objRegistro50.ALIQUOTA = rangeR50Aliquota.get_Value() == null
                                    ? ""
                                    : Convert.ToDecimal(rangeR50Aliquota.get_Value());
                                objRegistro50.SITUACAO = rangeR50Situacao.get_Value() == null
                                    ? ""
                                    : rangeR50Situacao.get_Value().ToString();

                                _regs50.Add(objRegistro50);
                            }

                            #endregion

                            #region Registros Tipo 61 - Venda a Consumidor

                            var rangeReg61 = xlWorkSheetR61.UsedRange;

                            _regs61 = new List<Registro61>();

                            for (rCnt = 2; rCnt <= rangeReg61.Rows.Count; rCnt++)
                            {
                                var rangeR61DataEmissao = rangeReg61.Cells[rCnt, 1] as Excel.Range;
                                var rangeR61Modelo = rangeReg61.Cells[rCnt, 2] as Excel.Range;
                                var rangeR61Serie = rangeReg61.Cells[rCnt, 3] as Excel.Range;
                                var rangeR61Subserie = rangeReg61.Cells[rCnt, 4] as Excel.Range;
                                var rangeR61Numero = rangeReg61.Cells[rCnt, 5] as Excel.Range;
                                var rangeR61ValorTotal = rangeReg61.Cells[rCnt, 6] as Excel.Range;
                                var rangeR61ValorBaseIcms = rangeReg61.Cells[rCnt, 7] as Excel.Range;
                                var rangeR61ValorIcms = rangeReg61.Cells[rCnt, 8] as Excel.Range;
                                var rangeR61ValorIsenta = rangeReg61.Cells[rCnt, 9] as Excel.Range;
                                var rangeR61ValorOutras = rangeReg61.Cells[rCnt, 10] as Excel.Range;
                                var rangeR61Aliquota = rangeReg61.Cells[rCnt, 11] as Excel.Range;

                                var objRegistro61 = new Registro61()
                                {
                                    DATA_EMISSAO =
                                        rangeR61DataEmissao.get_Value() == null
                                            ? ""
                                            : Convert.ToDateTime(rangeR61DataEmissao.get_Value()),
                                    MODELO =
                                        rangeR61Modelo.get_Value() == null ? "" : rangeR61Modelo.get_Value().ToString(),
                                    SERIE =
                                        rangeR61Serie.get_Value() == null ? "" : rangeR61Serie.get_Value().ToString(),
                                    SUBSERIE =
                                        rangeR61Subserie.get_Value() == null
                                            ? ""
                                            : rangeR61Subserie.get_Value().ToString(),
                                    NRO_ORDEM =
                                        rangeR61Numero.get_Value() == null
                                            ? ""
                                            : Convert.ToInt32(rangeR61Numero.get_Value()),
                                    VALOR_TOTAL =
                                        rangeR61ValorTotal.get_Value() == null
                                            ? ""
                                            : Convert.ToDecimal(rangeR61ValorTotal.get_Value()),
                                    BASE_CALC_ICMS =
                                        rangeR61ValorBaseIcms.get_Value() == null
                                            ? ""
                                            : Convert.ToDecimal(rangeR61ValorBaseIcms.get_Value()),
                                    VALOR_ICMS =
                                        rangeR61ValorIcms.get_Value() == null
                                            ? ""
                                            : Convert.ToDecimal(rangeR61ValorIcms.get_Value()),
                                    VALOR_ISENTA_NTRIBUT =
                                        rangeR61ValorIsenta.get_Value() == null
                                            ? ""
                                            : Convert.ToDecimal(rangeR61ValorIsenta.get_Value()),
                                    OUTRAS =
                                        rangeR61ValorOutras.get_Value() == null
                                            ? ""
                                            : Convert.ToDecimal(rangeR61ValorOutras.get_Value()),
                                    ALIQUOTA = 0
                                };

                                _regs61.Add(objRegistro61);
                            }

                            #endregion

                            xlWorkBook.Close(true, null, null);
                            xlApp.Quit();

                            #endregion
                        }
                    }

                    #endregion Leitura da Planilha em Excel p/ Obtenção das Informações

                    if (!gerarArquivoZerado)
                    {
                        var r50 = new Registro50();

                        linhasGeradas.AddRange(r50.EscreverRegistro50(
                            _regs50,
                            dtDataInicial.Value.Date,
                            dtDataFinal.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
                            ));

                        var r61 = new Registro61();

                        // Escreve Registro 61 - Notas de Consumidor
                        linhasGeradas.AddRange(r61.EscreverRegistro61(
                            _regs61,
                            dtDataInicial.Value.Date,
                            dtDataFinal.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
                            ));
                    }

                    var r90 = new Registro90(
                        txbCnpj.Text,
                        txbIe.Text,
                        linhasGeradas
                        );

                    // Escreve Registro 90 - obrigatório
                    linhasGeradas.Add(r90.EscreverRegistro90(validarRegistros));

                    #endregion Montagem dos Registros

                    #region Nomeação e Escrita do Arquivo de Texto

                    var path = txbLocalExportacao.Text.ToStringSafe().Trim();

                    if (string.IsNullOrEmpty(path))
                        throw new Exception("O local de exportação do arquivo não foi definido!");

                    string nomeArquivo;
                    if (gerarArquivoZerado)
                    {
                        nomeArquivo = string.Format("{0}{1}{2}{3}.TXT",
                            "SINTEGRA_ZERADO_",
                            DateTime.Now.Hour.ToString("00"),
                            DateTime.Now.Minute.ToString("00"),
                            DateTime.Now.Second.ToString("00"));
                    }
                    else
                    {
                        nomeArquivo = string.Format("{0}{1}{2}{3}.TXT",
                            "SINTEGRA_",
                            DateTime.Now.Hour.ToString("00"),
                            DateTime.Now.Minute.ToString("00"),
                            DateTime.Now.Second.ToString("00"));
                    }

                    var pathCompleto = Path.Combine(path, nomeArquivo);

                    File.GetAccessControl(path, AccessControlSections.Owner);

                    File.WriteAllLines(pathCompleto, linhasGeradas.ToArray());

                    MessageBox.Show("Gerado com sucesso!");

                    #endregion Nomeação e Escrita do Arquivo de Texto
                }
                catch (Exception ex)
                {
                    FormUtils.ExibirMensagem(ex);
                }
            };

            _bw.RunWorkerCompleted += (o, args) =>
            {
                btnGerarSintegra.Enabled = true;
                btnGerarSintegraZerado.Enabled = true;

                if (args.Error != null) return;
            };

            btnGerarSintegra.Enabled = false;
            btnGerarSintegraZerado.Enabled = false;

            _bw.RunWorkerAsync();
        }

        private void btnGerarSintegra_Click (object sender, EventArgs e)
        {
            GerarSintegra(txbCaminhoArquivoExcel.Text, true);
        }

        private void btnGerarSintegraZerado_Click (object sender, EventArgs e)
        {
            GerarSintegra("", false, true, false);
        }

        private void btnImportarDoExcel_Click (object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,
                Filter = @"Todos os arquivos (*.*)|*.*|Excel 2007 > (*.xlsx)|*.xlxs|Excel 97-2003 (*.xls)|*.xls"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txbCaminhoArquivoExcel.Text = dialog.FileName;
            }
        }

        private void btnDefinirLocalExportacao_Click (object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = @"Selecione o local de exportação..."
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txbLocalExportacao.Text = fbd.SelectedPath;
            }
        }

        private void chkImportarExcel_CheckedChanged(object sender, EventArgs e)
        {
            lblCaminhoArquivoExcel.Enabled = chkImportarExcel.Checked;
            txbCaminhoArquivoExcel.Enabled = chkImportarExcel.Checked;
            btnImportarDoExcel.Enabled = chkImportarExcel.Checked;
        }
    }
}


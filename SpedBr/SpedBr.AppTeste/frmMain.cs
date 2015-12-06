using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SpedBr.AppTeste.Utils;
using SpedBr.SpedFiscal;

namespace SpedBr.AppTeste
{
    public partial class frmMain : Form
    {
        BackgroundWorker _bw;

        public frmMain()
        {
            InitializeComponent();

            lblVersao.Text = String.Format("v.{0}", Application.ProductVersion.ToStringSafe());

            dtReg0000DataInicial.Value = FormUtils.GetFirstDayOfMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtReg0000DataFinal.Value = FormUtils.GetLastDayOfMonth(DateTime.Now.Year, DateTime.Now.Month);
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            //var fileName = "";

            //if (
            //       MessageBox.Show(@"Deseja exportar o resultado do processamento?", @"Exportar?",
            //           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.FileName = string.Format("{0}-{1}-{2}.txt", "SpedBr", DateTime.Now.ToShortDateString().Replace("/", ""), DateTime.Now.ToShortTimeString().Replace(":", ""));
            //    sfd.RestoreDirectory = true;
            //    sfd.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        fileName = sfd.FileName;
            //    }
            //}

            btnLimpar.PerformClick();

            _bw = new BackgroundWorker();
            _bw.WorkerReportsProgress = true;
            _bw.WorkerSupportsCancellation = true;

            var linhas = new List<string>();
            var temException = false;
           
            _bw.DoWork += (o, args) =>
            {
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (_bw.CancellationPending)
                        {
                            args.Cancel = true;
                            _bw.ReportProgress(i);
                            return;
                        }
                        else
                        {
                            _bw.ReportProgress(i);
                        }

                        Thread.Sleep(10);
                    }
                    
                    #region Bloco 0

                    Bloco0 b0 = new Bloco0();

                    var finalidade = txbReg0000CodigoFinalidade.Text.ToInt();
                    FinalidadeArquivo codFinalidadeArquivo;

                    if (finalidade == 0)
                        codFinalidadeArquivo = FinalidadeArquivo.RemessaArquivoOriginal;
                    else 
                        codFinalidadeArquivo = FinalidadeArquivo.RemessaArquivoSubstituto;

                    Bloco0.Registro0000 reg0000 = new Bloco0.Registro0000(
                        txbReg0000CodigoVersao.Text.ToStringSafe(),
                        codFinalidadeArquivo, 
                        dtReg0000DataInicial.Value,
                        dtReg0000DataFinal.Value,
                        txbReg0000RazaoSocial.Text.ToStringSafe(),
                        txbReg0000Cnpj.Text.ToStringSafe(),
                        txbReg0000Cpf.Text.ToStringSafe(),
                        txbReg0000Uf.Text.ToStringSafe(),
                        txbReg0000InscricaoEstadual.Text.ToStringSafe(),
                        txbReg0000CodigoMunicipioIbge.Text.ToStringSafe(),
                        txbReg0000InscricaoMunicipal.Text.ToStringSafe(),
                        txbReg0000InscricaoSuframa.Text.ToStringSafe(),
                        txbReg0000IndPerfil.Text.ToStringSafe(),
                        txbReg0000IndAtividade.Text.ToStringSafe());

                    Bloco0.Registro0001 reg0001 = new Bloco0.Registro0001(txbReg0001IndMovimento.Text.ToStringSafe());

                    Bloco0.Registro0005 reg0005 = new Bloco0.Registro0005("", "", "", "", "", "", "", "", "");

                    var registros0015 = new List<Bloco0.Registro0015>();
                    registros0015.Add(new Bloco0.Registro0015() { UF_ST = "GO", IE_ST = "123456789" });
                    registros0015.Add(new Bloco0.Registro0015() { UF_ST = "SP", IE_ST = "123456789" });
                
                    Bloco0.Registro0100 reg0100 = new Bloco0.Registro0100("", "", "", "", "", "", "", "", "", "", "", "", "");

                    var registros0150 = new List<Bloco0.Registro0150>();
                    registros0150.Add(new Bloco0.Registro0150()
                    {
                        COD_PART = "123",
                        NOME = "PARTICIPANTE 1",
                        ListaAlteracoes =
                            new List<Bloco0.Registro0150.Registro0175>()
                            {
                                new Bloco0.Registro0150.Registro0175()
                                {
                                    DataAlteracao = DateTime.Now,
                                    NR_CAMPO = "01",
                                    CONT_ANT = "456"
                                }
                            }
                    });
                    registros0150.Add(new Bloco0.Registro0150()
                    {
                        COD_PART = "789",
                        NOME = "PARTICIPANTE 2",
                        ListaAlteracoes =
                            new List<Bloco0.Registro0150.Registro0175>()
                            {
                                new Bloco0.Registro0150.Registro0175()
                                {
                                    DataAlteracao = DateTime.Now,
                                    NR_CAMPO = "01",
                                    CONT_ANT = "890"
                                }
                            }
                    });

                    var registros0190 = new List<Bloco0.Registro0190>()
                    {
                        new Bloco0.Registro0190() {UNID = "UND", DESCR = "UNIDADE"},
                        new Bloco0.Registro0190() {UNID = "LA", DESCR = "LATA"},
                        new Bloco0.Registro0190() {UNID = "MT2", DESCR = "METRO QUADRADO"}
                    };

                    var registros0200 = new List<Bloco0.Registro0200>()
                    {
                        new Bloco0.Registro0200()
                        {
                            COD_ITEM = "123",
                            DESCR_ITEM = "ITEM 1",
                            ListaAlteracoes =
                                new List<Bloco0.Registro0200.Registro0205>()
                                {
                                    new Bloco0.Registro0200.Registro0205()
                                    {
                                        COD_ANT_ITEM = "456",
                                        DESCR_ANT_ITEM = "ITEM 4",
                                        DataInicial = DateTime.Now,
                                        DataFinal = DateTime.Now
                                    },
                                    new Bloco0.Registro0200.Registro0205()
                                    {
                                        COD_ANT_ITEM = "456",
                                        DESCR_ANT_ITEM = "ITEM 2",
                                        DataInicial = DateTime.Now,
                                        DataFinal = DateTime.Now
                                    }
                                },
                            CodigoAnp =
                                new Bloco0.Registro0200.Registro0206() {COD_COMB = "COD_COMBUSTIVEL_ANP_123456789"},
                            ListaConsumoEspecPadronizado =
                                new List<Bloco0.Registro0200.Registro0210>()
                                {
                                    new Bloco0.Registro0200.Registro0210()
                                    {
                                        COD_ITEM_COMP = "123",
                                        QTD_COMP = 10,
                                        PERDA = 3
                                    }
                                },
                            ListaFatoresConversaoUnidades =
                                new List<Bloco0.Registro0200.Registro0220>()
                                {
                                    new Bloco0.Registro0200.Registro0220() {UNID_CONV = "UND", FAT_CONV = 1}
                                }
                        },
                        new Bloco0.Registro0200()
                        {
                            COD_ITEM = "789",
                            DESCR_ITEM = "ITEM 3",
                        }
                    };

                    /* Escreve as linhas do BLOCO 0  no arquivo */
                    linhas.AddRange(b0.EscreverBloco0(reg0000, reg0001, reg0005, registros0015, reg0100, registros0150,
                        registros0190, registros0200, chkValidarArquivo.Checked));

                    #endregion Bloco 0

                    #region Bloco C

                    BlocoC bC = new BlocoC();

                    BlocoC.RegistroC001 regC001 = new BlocoC.RegistroC001("1");

                    linhas.AddRange(bC.EscreverBlocoC(regC001, chkValidarArquivo.Checked));

                    #endregion Bloco C

                    #region Bloco D

                    BlocoD bD = new BlocoD();

                    BlocoD.RegistroD001 regD001 = new BlocoD.RegistroD001("1");

                    linhas.AddRange(bD.EscreverBlocoD(regD001, chkValidarArquivo.Checked));

                    #endregion Bloco D

                    #region Bloco E

                    BlocoE bE = new BlocoE();

                    BlocoE.RegistroE001 regE001 = new BlocoE.RegistroE001("1");

                    BlocoE.RegistroE100 regE100 = new BlocoE.RegistroE100(dtReg0000DataInicial.Value,
                        dtReg0000DataFinal.Value);

                    BlocoE.RegistroE110 regE110 = new BlocoE.RegistroE110(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    BlocoE.RegistroE500 regE500 = new BlocoE.RegistroE500("0", dtReg0000DataInicial.Value,
                        dtReg0000DataFinal.Value);

                    BlocoE.RegistroE520 regE520 = new BlocoE.RegistroE520(0, 0, 0, 0, 0, 0, 0);

                    linhas.AddRange(bE.EscreverBlocoE(regE001, regE100, regE110, regE500, regE520,
                        chkValidarArquivo.Checked));

                    #endregion Bloco E

                    #region Bloco G

                    BlocoG bG = new BlocoG();

                    BlocoG.RegistroG001 regG001 = new BlocoG.RegistroG001("1");

                    linhas.AddRange(bG.EscreverBlocoG(regG001, chkValidarArquivo.Checked));

                    #endregion Bloco G

                    #region Bloco H

                    BlocoH bH = new BlocoH();

                    BlocoH.RegistroH001 regH001 = new BlocoH.RegistroH001("1");

                    linhas.AddRange(bH.EscreverBlocoH(regH001, chkValidarArquivo.Checked));

                    #endregion Bloco H

                    #region Bloco 1

                    Bloco1 b1 = new Bloco1();

                    Bloco1.Registro1001 reg1001 = new Bloco1.Registro1001("0");

                    Bloco1.Registro1010 reg1010 = new Bloco1.Registro1010(false, false, false, false, false, false,
                        false, false, false);

                    linhas.AddRange(b1.EscreverBloco1(reg1001, reg1010, chkValidarArquivo.Checked));

                    #endregion Bloco 1

                    #region Bloco 9

                    Bloco9 b9 = new Bloco9();

                    Bloco9.Registro9001 reg9001 = new Bloco9.Registro9001("0");

                    linhas.AddRange(b9.EscreverBloco9(reg9001, linhas, chkValidarArquivo.Checked));

                    #endregion Bloco 9

                }
                catch (Exception exception)
                {
                    temException = true;
                    FormUtils.ExibirMensagemException(exception);
                }
            };

            _bw.ProgressChanged += (o, args) =>
            {
                progressBarProgresso.Value = args.ProgressPercentage;
                lblProgressoValor.Text = String.Format("{0} %", args.ProgressPercentage);

                //StreamWriter arquivo = new StreamWriter(fileName);
                //arquivo.WriteLine(rtbResultado.Text);
                //arquivo.Close();
            };

            _bw.RunWorkerCompleted += (o, args) =>
            {
                rtbResultado.Lines = linhas.ToArray();
                lblTotalLinhasArquivo.Text = rtbResultado.Lines.Count().ToString().PadLeft(6, '0') + @" linhas";

                if (args.Cancelled)
                {
                    FormUtils.ExibirMensagemException("A operação foi cancelada!", FormUtils.TipoMensagem.Cancelamento);
                }
                else
                {
                    if (args.Error != null)
                    {
                        var exception = args.Error.GetBaseException();

                        FormUtils.ExibirMensagemException(exception);
                    }
                    else
                    {
                        if (!temException)
                            FormUtils.ExibirMensagemException("A operação foi concluída!", FormUtils.TipoMensagem.Sucesso);
                    }
                }

                btnLimpar.Enabled = true;
                btnCancelar.Visible = false;
                btnGerarArquivo.Visible = true;
                progressBarProgresso.Value = 0;
                lblProgressoValor.Visible = false;
            };

            btnLimpar.Enabled = false;
            btnCancelar.Visible = true;
            btnGerarArquivo.Visible = false;
            lblProgressoValor.Visible = true;

            _bw.RunWorkerAsync();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbResultado.Text = string.Empty;
            lblTotalLinhasArquivo.Text = @"000000 linhas";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_bw.WorkerSupportsCancellation)
            {
                if (_bw.IsBusy)
                {
                    _bw.CancelAsync();
                }
            }
        }
    }
}

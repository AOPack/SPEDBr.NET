using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class BlocoE
    {
        /// <summary>
        /// Efetua a geração do BLOCO E do arquivo.
        /// </summary>
        /// <param name="regE001"></param>
        /// <param name="regE100"></param>
        /// <param name="regE110"></param>
        /// <param name="regE520"></param>
        /// <param name="validarRegistros"></param>
        /// <param name="regE500"></param>
        /// <returns>String</returns>
        public List<string> EscreverBlocoE(RegistroE001 regE001, RegistroE100 regE100, RegistroE110 regE110, RegistroE500 regE500, RegistroE520 regE520, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                regE001.EscreverRegistroE001(validarRegistros)
            };

            list.Add(regE100.EscreverRegistroE100());

            list.Add(regE110.EscreverRegistroE110());

            list.Add(regE500.EscreverRegistroE500());

            list.Add(regE520.EscreverRegistroE520());

            list.Add(new BlocoE.RegistroE990().EscreverRegistroE990(list.Count));

            return list;
        }

        public class RegistroE001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "E001".
            /// </summary>
            private string REG
            {
                get { return "E001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO E001: ABERTURA DO BLOCO E
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public RegistroE001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro E001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroE001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo INE_MOV (REGISTRO E001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class RegistroE100
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "E100".
            /// </summary>
            private string REG
            {
                get { return "E100"; }
            }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            private DateTime DataInicial { get; set; }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            private string DT_INI
            {
                get { return this.DataInicial.ToShortDateString().Replace("/", ""); }
            }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            private DateTime DataFinal { get; set; }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            private string DT_FIN
            {
                get { return this.DataFinal.ToShortDateString().Replace("/", ""); }
            }

            #endregion

            public RegistroE100(DateTime dataInicial, DateTime dataFinal)
            {
                this.DataInicial = dataInicial;
                this.DataFinal = dataFinal;
            }

            internal string EscreverRegistroE100()
            {
                return String.Format("|{0}|{1}|{2}|", REG, DT_INI, DT_FIN);
            }
        }

        public class RegistroE110
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "E110".
            /// </summary>
            private string REG
            {
                get { return "E110"; }
            }

            private decimal VL_TOT_DEBITOS { get; set; }
            private decimal VL_AJ_DEBITOS { get; set; }
            private decimal VL_TOT_AJ_DEBITOS { get; set; }
            private decimal VL_ESTORNOS_CRED { get; set; }
            private decimal VL_TOT_CREDITOS { get; set; }
            private decimal VL_AJ_CREDITOS { get; set; }
            private decimal VL_TOT_AJ_CREDITOS { get; set; }
            private decimal VL_ESTORNOS_DEB { get; set; }
            private decimal VL_SLD_CREDOR_ANT { get; set; }
            private decimal VL_SLD_APURADO { get; set; }
            private decimal VL_TOT_DED { get; set; }
            private decimal VL_ICMS_RECOLHER { get; set; }
            private decimal VL_SLD_CREDOR_TRANSPORTAR { get; set; }
            private decimal DEB_ESP { get; set; }

            #endregion Propriedades

            public RegistroE110(decimal totalDebitos, decimal ajusteDebitos, decimal totalAjusteDebitos,
                decimal estornoCreditos, decimal totalCreditos, decimal ajusteCreditos, decimal totalAjusteCreditos,
                decimal estornoDebitos, decimal saldoCredorAnterior, decimal saldoApurado, decimal totalDeducoes,
                decimal icmsRecolher, decimal saldoCredorTransportar, decimal debitosExtraApuracao)
            {
                VL_TOT_DEBITOS = totalDebitos;
                VL_AJ_DEBITOS = ajusteDebitos;
                VL_TOT_AJ_DEBITOS = totalAjusteDebitos;
                VL_ESTORNOS_CRED = estornoCreditos;
                VL_TOT_CREDITOS = totalCreditos;
                VL_AJ_CREDITOS = ajusteCreditos;
                VL_TOT_AJ_CREDITOS = totalAjusteCreditos;
                VL_ESTORNOS_DEB = estornoDebitos;
                VL_SLD_CREDOR_ANT = saldoCredorAnterior;
                VL_SLD_APURADO = saldoApurado;
                VL_TOT_DED = totalDeducoes;
                VL_ICMS_RECOLHER = icmsRecolher;
                VL_SLD_CREDOR_TRANSPORTAR = saldoCredorTransportar;
                DEB_ESP = debitosExtraApuracao;
            }

            internal string EscreverRegistroE110()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", REG, VL_TOT_DEBITOS, VL_AJ_DEBITOS, VL_TOT_AJ_DEBITOS, VL_ESTORNOS_CRED, VL_TOT_CREDITOS, VL_AJ_CREDITOS, VL_TOT_AJ_CREDITOS, VL_ESTORNOS_DEB, VL_SLD_CREDOR_ANT, VL_SLD_APURADO, VL_TOT_DED, VL_ICMS_RECOLHER, VL_SLD_CREDOR_TRANSPORTAR, DEB_ESP);
            }
        }

        public class RegistroE500
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "E500".
            /// </summary>
            private string REG
            {
                get { return "E500"; }
            }

            private string IND_APUR { get; set; }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            private DateTime DataInicial { get; set; }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            private string DT_INI
            {
                get { return this.DataInicial.ToShortDateString().Replace("/", ""); }
            }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            private DateTime DataFinal { get; set; }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            private string DT_FIN
            {
                get { return this.DataFinal.ToShortDateString().Replace("/", ""); }
            }

            #endregion

            public RegistroE500(string indicadorApuracaoIpi, DateTime dataInicial, DateTime dataFinal)
            {
                this.IND_APUR = indicadorApuracaoIpi;
                this.DataInicial = dataInicial;
                this.DataFinal = dataFinal;
            }

            internal string EscreverRegistroE500()
            {
                return String.Format("|{0}|{1}|{2}|{3}|", REG, IND_APUR, DT_INI, DT_FIN);
            }
        }

        public class RegistroE520
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "E520".
            /// </summary>
            private string REG
            {
                get { return "E520"; }
            }

            private decimal VL_SD_ANT_IPI { get; set; }

            private decimal VL_DEB_IPI { get; set; }

            private decimal VL_CRED_IPI { get; set; }

            private decimal VL_OD_IPI { get; set; }

            private decimal VL_OC_IPI { get; set; }

            private decimal VL_SC_IPI { get; set; }

            private decimal VL_SD_IPI { get; set; }

            #endregion Propriedades

            public RegistroE520(decimal saldoCredorAnterior, decimal valorDebitos, decimal valorCreditos,
                decimal outrosDebitos, decimal outrosCreditos, decimal saldoCredorTransportar, decimal saldoDevedor)
            {
                this.VL_SD_ANT_IPI = saldoCredorAnterior;
                this.VL_DEB_IPI = valorDebitos;
                this.VL_CRED_IPI = valorCreditos;
                this.VL_OD_IPI = outrosDebitos;
                this.VL_OC_IPI = outrosCreditos;
                this.VL_SC_IPI = saldoCredorTransportar;
                this.VL_SD_IPI = saldoDevedor;
            }

            internal string EscreverRegistroE520()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", REG, VL_SD_ANT_IPI, VL_DEB_IPI, VL_CRED_IPI, VL_OD_IPI, VL_OC_IPI, VL_SC_IPI, VL_SD_IPI);
            }
        }

        public class RegistroE990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "E990".
            /// </summary>
            private string REG
            {
                get { return "E990"; }
            }

            private string QTD_LIN_E { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro E990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro E990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroE990(int qtdLinhas)
            {
                int qtdLinhasRegistroE990 = 1;

                qtdLinhasRegistroE990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistroE990);
            }
        }
    }
}

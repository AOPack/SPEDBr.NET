using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class Bloco1
    {
        /// <summary>
        /// Efetua a geração do BLOCO 1 do arquivo.
        /// </summary>
        /// <param name="reg1001"></param>
        /// <param name="reg1010"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBloco1(Registro1001 reg1001, Registro1010 reg1010, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                reg1001.EscreverRegistro1001(validarRegistros)
            };

            list.Add(reg1010.EscreverRegistro1010());

            list.Add(new Registro1990().EscreverRegistro1990(list.Count));

            return list;
        }

        public class Registro1001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "1001".
            /// </summary>
            private string REG
            {
                get { return "1001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 1001: ABERTURA DO BLOCO 1
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public Registro1001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro 1001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro1001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO 1001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class Registro1010
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "1010".
            /// </summary>
            private string REG
            {
                get { return "1010"; }
            }

            private string IND_EXP { get; set; }

            private string IND_CCRF { get; set; }

            private string IND_COMB { get; set; }

            private string IND_USINA { get; set; }

            private string IND_VA { get; set; }

            private string IND_EE { get; set; }

            private string IND_CART { get; set; }

            private string IND_FORM { get; set; }

            private string IND_AER { get; set; }
            
            #endregion Propriedades

            /// <summary>
            /// REGISTRO 1010: OBRIGATORIEDADE DE REGISTROS DO BLOCO 1
            /// </summary>
            /// <param name="exportacao"></param>
            /// <param name="creditosIcms"></param>
            /// <param name="combustivel"></param>
            /// <param name="usina"></param>
            /// <param name="va"></param>
            /// <param name="energia"></param>
            /// <param name="cartao"></param>
            /// <param name="form"></param>
            /// <param name="servAereo"></param>
            public Registro1010(bool exportacao, bool creditosIcms, bool combustivel, bool usina, bool va, bool energia, bool cartao, bool form, bool servAereo)
            {
                this.IND_EXP = exportacao ? "S" : "N";
                this.IND_CCRF = creditosIcms ? "S" : "N";
                this.IND_COMB = combustivel ? "S" : "N";
                this.IND_USINA = usina ? "S" : "N";
                this.IND_VA = va ? "S" : "N";
                this.IND_EE = energia ? "S" : "N";
                this.IND_CART = cartao ? "S" : "N";
                this.IND_FORM = form ? "S" : "N";
                this.IND_AER = servAereo ? "S" : "N";
            }

            /// <summary>
            /// Efetua a escrita do Registro 1010 do arquivo.
            /// </summary>
            /// <returns></returns>
            internal string EscreverRegistro1010()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", REG, IND_EXP, IND_CCRF, IND_COMB, IND_USINA, IND_VA, IND_EE, IND_CART, IND_FORM, IND_AER);
            }
        }

        public class Registro1990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "1990".
            /// </summary>
            private string REG
            {
                get { return "1990"; }
            }
            /// <summary>
            /// Quantidade total de linhas do Bloco 1.
            /// </summary>
            private string QTD_LIN_1 { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro 1990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro 1990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro1990(int qtdLinhas)
            {
                int qtdLinhasRegistro1990 = 1;

                qtdLinhasRegistro1990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistro1990);
            }
        }
    }
}

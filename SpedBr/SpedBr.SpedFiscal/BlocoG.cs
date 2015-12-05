using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class BlocoG
    {
        /// <summary>
        /// Efetua a geração do BLOCO G do arquivo.
        /// </summary>
        /// <param name="regG001"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBlocoG(RegistroG001 regG001, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                regG001.EscreverRegistroG001(validarRegistros)
            };

            list.Add(new BlocoG.RegistroG990().EscreverRegistroG990(list.Count));

            return list;
        }

        public class RegistroG001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "G001".
            /// </summary>
            private string REG
            {
                get { return "G001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// RGGISTRO G001: ABGRTURA DO BLOCO G
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public RegistroG001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro G001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroG001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo ING_MOV (RGGISTRO G001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class RegistroG990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "G990".
            /// </summary>
            private string REG
            {
                get { return "G990"; }
            }

            private string QTD_LIN_G { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro G990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro G990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroG990(int qtdLinhas)
            {
                int qtdLinhasRegistroG990 = 1;

                qtdLinhasRegistroG990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistroG990);
            }
        }
    }
}

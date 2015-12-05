using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class BlocoD
    {
        /// <summary>
        /// Efetua a geração do BLOCO D do arquivo.
        /// </summary>
        /// <param name="regD001"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBlocoD(RegistroD001 regD001, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                regD001.EscreverRegistroD001(validarRegistros)
            };

            list.Add(new BlocoD.RegistroD990().EscreverRegistroD990(list.Count));

            return list;
        }

        public class RegistroD001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "D001".
            /// </summary>
            private string REG
            {
                get { return "D001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 0001: ABERTURA DO BLOCO 0
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public RegistroD001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro D001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroD001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO D001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class RegistroD990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "D990".
            /// </summary>
            private string REG
            {
                get { return "D990"; }
            }

            private string QTD_LIN_D { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro D990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro D990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroD990(int qtdLinhas)
            {
                int qtdLinhasRegistroD990 = 1;

                qtdLinhasRegistroD990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistroD990);
            }
        }
    }
}

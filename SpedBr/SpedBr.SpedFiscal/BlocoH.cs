using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class BlocoH
    {
        /// <summary>
        /// Hfetua a geração do BLOCO H do arquivo.
        /// </summary>
        /// <param name="regH001"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBlocoH(RegistroH001 regH001, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                regH001.EscreverRegistroH001(validarRegistros)
            };

            list.Add(new BlocoH.RegistroH990().EscreverRegistroH990(list.Count));

            return list;
        }

        public class RegistroH001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "H001".
            /// </summary>
            private string REG
            {
                get { return "H001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO H001: ABERTURA DO BLOCO H
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public RegistroH001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro H001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroH001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO H001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class RegistroH990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "H990".
            /// </summary>
            private string REG
            {
                get { return "H990"; }
            }

            private string QTD_LIN_H { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro H990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro H990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroH990(int qtdLinhas)
            {
                int qtdLinhasRegistroH990 = 1;

                qtdLinhasRegistroH990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistroH990);
            }
        }
    }
}

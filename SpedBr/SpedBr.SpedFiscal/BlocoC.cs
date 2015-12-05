using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class BlocoC
    {
        /// <summary>
        /// Efetua a geração do BLOCO C do arquivo.
        /// </summary>
        /// <param name="regC001"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBlocoC(RegistroC001 regC001, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                regC001.EscreverRegistroC001(validarRegistros)
            };

            list.Add(new BlocoC.RegistroC990().EscreverRegistroC990(list.Count));

            return list;
        }

        public class RegistroC001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "C001".
            /// </summary>
            private string REG
            {
                get { return "C001"; }
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
            public RegistroC001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro 0001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroC001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO C001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class RegistroC990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "C990".
            /// </summary>
            private string REG
            {
                get { return "C990"; }
            }

            private string QTD_LIN_C { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro C990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro C990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistroC990(int qtdLinhas)
            {
                int qtdLinhasRegistroC990 = 1;

                qtdLinhasRegistroC990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistroC990);
            }
        }
    }
}

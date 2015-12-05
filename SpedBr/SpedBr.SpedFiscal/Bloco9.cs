using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public class Bloco9
    {
        /// <summary>
        /// Efetua a geração do BLOCO 9 do arquivo.
        /// </summary>
        /// <param name="reg9001"></param>
        /// <param name="linhasArquivo"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBloco9(Registro9001 reg9001, List<string> linhasArquivo, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                reg9001.EscreverRegistro9001(validarRegistros)
            };

            list.AddRange(new Bloco9.Registro9900(linhasArquivo).EscreverRegistro9900());

            list.Add(new Bloco9.Registro9990().EscreverRegistro9990(list.Count));

            list.Add(new Bloco9.Registro9999().EscreverRegistro9999(list.Count + linhasArquivo.Count));

            return list;
        }

        public class Registro9001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "9001".
            /// </summary>
            private string REG
            {
                get { return "9001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 9001: ABERTURA DO BLOCO 9
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public Registro9001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro 9001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro9001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO 9001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        public class Registro9900
        {
            public class Registro9900Temp
            {
                public string REG_BLC { get; set; }

                public int QTD_REG_BLC { get; set; }
            }

            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "9900".
            /// </summary>
            private string REG
            {
                get { return "9900"; }
            }

            private List<Registro9900Temp> TotalizadoresDeRegistros { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 9900: REGISTROS DO ARQUIVO
            /// </summary>
            /// <param name="linhas"></param>
            public Registro9900(List<string> linhas)
            {
                var registros = new List<Registro9900Temp>();

                foreach (var linha in linhas)
                {
                    if (linha != null)
                    {
                        string registroAtual = linha.Substring(0, 6).Replace("|", "");

                        bool contemRegistroAtual = registros.Count(ct => ct.REG_BLC == registroAtual) > 0;

                        if (contemRegistroAtual)
                            registros.Find(f => f.REG_BLC == registroAtual).QTD_REG_BLC += 1;
                        else
                            registros.Add(new Registro9900Temp() {REG_BLC = registroAtual, QTD_REG_BLC = 1});
                    }
                }

                //Adiciona informações dos registros finais
                registros.Add(new Registro9900Temp() { REG_BLC = "9001", QTD_REG_BLC = 1 });
                registros.Add(new Registro9900Temp() { REG_BLC = "9990", QTD_REG_BLC = 1 });
                registros.Add(new Registro9900Temp() { REG_BLC = "9999", QTD_REG_BLC = 1 });
                registros.Add(new Registro9900Temp() { REG_BLC = "9900", QTD_REG_BLC = registros.Count() + 1 });
                
                this.TotalizadoresDeRegistros = registros;
            }

            /// <summary>
            /// Efetua a escrita do Registro 9900 do arquivo.
            /// </summary>
            /// <returns></returns>
            internal List<string> EscreverRegistro9900()
            {
                var list = new List<string>();

                foreach (var reg9900 in TotalizadoresDeRegistros)
                {
                    list.Add(String.Format("|{0}|{1}|{2}|", REG, reg9900.REG_BLC, reg9900.QTD_REG_BLC));
                }

                return list;
            }
        }

        public class Registro9990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "9990".
            /// </summary>
            private string REG
            {
                get { return "9990"; }
            }
            /// <summary>
            /// Quantidade total de linhas do Bloco 9.
            /// </summary>
            private string QTD_LIN_9 { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro 9990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro 9990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro9990(int qtdLinhas)
            {
                // Linha 9990 + Linha 9999 -> Aqui encerra a contagem de linha de 'TODOS' os registros do Bloco 9
                int qtdLinhasRegistro9990 = 2; // Considera a última linha do arquivo |9999|

                qtdLinhasRegistro9990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistro9990);
            }
        }

        public class Registro9999
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "9999".
            /// </summary>
            private string REG
            {
                get { return "9999"; }
            }
            /// <summary>
            /// Quantidade total de linhas do arquivo digital.
            /// </summary>
            private string QTD_LIN { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro 9999 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro 9999.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro9999(int qtdLinhas)
            {
                int qtdLinhasRegistro9999 = 1;

                qtdLinhasRegistro9999 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistro9999);
            }
        }
    }
}

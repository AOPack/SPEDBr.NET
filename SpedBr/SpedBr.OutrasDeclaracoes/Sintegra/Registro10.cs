using System;
using SpedBr.Common;

namespace SpedBr.OutrasDeclaracoes.Sintegra
{
    public class Registro10
    {
        #region Propriedades

        private string TIPO
        {
            get { return "10"; }
        }

        private string CGCMF { get; set; }

        /// <summary>
        /// Inscrição Estadual da entidade.
        /// </summary>
        private string IE { get; set; }

        /// <summary>
        /// Nome empresarial da entidade.
        /// </summary>
        private string NOME { get; set; }

        private string MUNICIPIO { get; set; }

        /// <summary>
        /// Sigla da unidade da federação da entidade.
        /// </summary>
        private string UF { get; set; }

        private string FAX { get; set; }

        /// <summary>
        /// Data inicial das informações contidas no arquivo.
        /// </summary>
        private DateTime DataInicial { get; set; }

        /// <summary>
        /// Data inicial das informações contidas no arquivo.
        /// </summary>
        private string DT_INI
        {
            get { return this.DataInicial.ToString("yyyyMMdd").Replace("/", ""); }
        }

        /// <summary>
        /// Data final das informações contidas no arquivo.
        /// </summary>
        private DateTime DataFinal { get; set; }

        /// <summary>
        /// Data final das informações contidas no arquivo.
        /// </summary>
        private string DT_FIN
        {
            get { return this.DataFinal.ToString("yyyyMMdd").Replace("/", ""); }
        }

        private string COD_ID_ESTRUT { get; set; }

        private string COD_ID_NAT_OPE { get; set; }

        private FinalidadeArquivo CodigoFinalidade { get; set; }

        private string COD_FIN
        {
            get
            {
                switch (CodigoFinalidade)
                {
                    case FinalidadeArquivo.RemessaArquivoOriginal:
                        return "1";
                        break;
                    case FinalidadeArquivo.RemessaArquivoSubstituto:
                        return "2";
                        break;
                    default:
                        return "--'";
                        break;
                }
            }
        }

        #endregion Propriedades

        public Registro10(
            string inscrCnpj,
            string inscrEstadual,
            string nomeEmpresarial,
            string municipio,
            string siglaUf,
            string fax,
            DateTime dataInicial,
            DateTime dataFinal,
            string codIdEstrutura,
            string codNatOp,
            FinalidadeArquivo codFinalidade
            )
        {
            this.CGCMF = inscrCnpj;
            this.IE = inscrEstadual;
            this.NOME = nomeEmpresarial;
            this.MUNICIPIO = municipio;
            this.UF = siglaUf;
            this.FAX = fax;
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
            this.COD_ID_ESTRUT = codIdEstrutura;
            this.COD_ID_NAT_OPE = codNatOp;
            this.CodigoFinalidade = codFinalidade;
        }

        /// <summary>
        /// Efetua a escrita do Registro 10 do arquivo.
        /// </summary>
        /// <param name="validarCampos">true ou false para realizar a validação dos dados.</param>
        /// <returns>String</returns>
        public string EscreverRegistro10(bool validarCampos = true)
        {
            if (validarCampos)
            {
                // Validar campos
            }

            var r10 = new string(' ', 126);
            try
            {
                r10 = r10.PreencherValorNaLinha(1, 2, TIPO.PadLeft(2, ' '));
                r10 = r10.PreencherValorNaLinha(3, 16, CGCMF.PadLeft(14, ' '));
                r10 = r10.PreencherValorNaLinha(17, 30, IE.PadRight(14, ' '));
                r10 = r10.PreencherValorNaLinha(31, 65, NOME.Length > 35 ? NOME.Substring(0, 35) : NOME.PadRight(35, ' '));
                r10 = r10.PreencherValorNaLinha(66, 95, MUNICIPIO.Length > 30 ? MUNICIPIO.Substring(0, 30) : MUNICIPIO.PadRight(30, ' '));
                r10 = r10.PreencherValorNaLinha(96, 97, UF.PadRight(2, ' '));
                r10 = r10.PreencherValorNaLinha(98, 107, FAX.PadLeft(10, '0'));
                r10 = r10.PreencherValorNaLinha(108, 115, DT_INI);
                r10 = r10.PreencherValorNaLinha(116, 123, DT_FIN);
                r10 = r10.PreencherValorNaLinha(124, 124, COD_ID_ESTRUT.PadRight(1, '3'));
                r10 = r10.PreencherValorNaLinha(125, 125, COD_ID_NAT_OPE.PadRight(1, '3'));
                r10 = r10.PreencherValorNaLinha(126, 126, COD_FIN.PadRight(1, '1'));

                return r10;
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao gerar registro tipo 10." + Environment.NewLine + e.Message);
            }
        }
    }
}

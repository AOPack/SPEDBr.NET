using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO 1: OUTRAS INFORMAÇÕES
    /// </summary>
    public class Bloco1
    {
        /// <summary>
        /// REGISTRO 1001: ABERTURA DO BLOCO 1
        /// </summary>
        public class Registro1001 : RegistroBaseSped
        {
            public Registro1001()
            {
                Reg = "1001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        /// REGISTRO 1010: OBRIGATORIEDADE DE REGISTROS DO BLOCO 1
        /// </summary>
        public class Registro1010 : RegistroBaseSped
        {
            public Registro1010()
            {
                Reg = "1010";
            }

            /// <summary>
            /// Reg. 1100 - Ocorreu averbação (conclusão) de exportação no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(2, "IND_EXP", "C", 1, 0, true)]
            public string IndExp { get; set; }

            /// <summary>
            /// Reg. 1200 - Existem informações acerca de créditos de ICMS a serem controlados, definidos pela Sefaz: S - Sim; N - Não
            /// </summary>
            [SpedCampos(3, "IND_CCRF", "C", 1, 0, true)]
            public string IndCcrf { get; set; }

            /// <summary>
            /// Reg. 1300 – É comercio varejista de combustíveis com movimentação e/ou estoque no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(4, "IND_COMB", "C", 1, 0, true)]
            public string IndComb { get; set; }

            /// <summary>
            /// Reg. 1390 – Usinas de açúcar e/álcool – O estabelecimento é produtor de açúcar e/ou álcool carburante com movimentação e/ou estoque no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(5, "IND_USINA", "C", 1, 0, true)]
            public string IndUsina { get; set; }

            /// <summary>
            /// Reg 1400 – Sendo o registro obrigatório em sua Unidade de Federação, existem informações a serem prestadas neste registro: S - Sim; N - Não
            /// </summary>
            [SpedCampos(6, "IND_VA", "C", 1, 0, true)]
            public string IndVa { get; set; }

            /// <summary>
            /// Reg 1500 - A empresa é distribuidora de energia e ocorreu fornecimento de energia elétrica para consumidores de outra UF: S - Sim; N - Não
            /// </summary>
            [SpedCampos(7, "IND_EE", "C", 1, 0, true)]
            public string IndEe { get; set; }

            /// <summary>
            /// Reg 1600 - Realizou vendas com Cartão de Crédito ou de débito: S - Sim; N - Não
            /// </summary>
            [SpedCampos(8, "IND_CART", "C", 1, 0, true)]
            public string IndCart { get; set; }

            /// <summary>
            /// Reg. 1700 – Foram emitidos documentos fiscais em papel no período em unidade da federação que exija o controle de utilização de documentos fiscais: S - Sim; N - Não
            /// </summary>
            [SpedCampos(9, "IND_FORM", "C", 1, 0, true)]
            public string IndForm { get; set; }

            /// <summary>
            /// Reg 1800 – A empresa prestou serviços de transporte aéreo de cargas e de passageiros: S - Sim; N - Não
            /// </summary>
            [SpedCampos(10, "IND_AER", "C", 1, 0, true)]
            public string IndAer { get; set; }
        }

        /// <summary>
        /// REGISTRO 1100: REGISTRO DE INFORMAÇÕES SOBRE EXPORTAÇÃO
        /// </summary>
        public class Registro1100 : RegistroBaseSped
        {
            public Registro1100()
            {
                Reg = "1100";
            }

            /// <summary>
            /// 0 - Declaração de Exportação; 1 - Declaração Simplificada de Exportação
            /// </summary>
            [SpedCampos(2, "IND_DOC", "N", 1, 0, true)]
            public int IndDoc { get; set; }

            /// <summary>
            /// Número da declaração
            /// </summary>
            [SpedCampos(3, "NRO_DE", "N", 11, 0, true)]
            public int NroDe { get; set; }

            /// <summary>
            /// Data da declaração
            /// </summary>
            [SpedCampos(4, "DT_DE", "N", 8, 0, true)]
            public DateTime DtDe { get; set; }

            /// <summary>
            /// 0 - Exportação Direta; 1 - Exportação Indireta
            /// </summary>
            [SpedCampos(5, "NAT_EXP", "N", 1, 0, true)]
            public int NatExp { get; set; }

            /// <summary>
            /// Nro do registro de exportação
            /// </summary>
            [SpedCampos(6, "NRO_RE", "N", 12, 0, false)]
            public int NroRe { get; set; }

            /// <summary>
            /// Data do registro de exportação
            /// </summary>
            [SpedCampos(7, "DT_RE", "N", 8, 0, false)]
            public DateTime DtRe { get; set; }

            /// <summary>
            /// Nro do conhecimento de embarque
            /// </summary>
            [SpedCampos(8, "CHC_EMB", "C", 18, 0, false)]
            public string ChcEmb { get; set; }

            /// <summary>
            /// Data do conhecimento de embarque
            /// </summary>
            [SpedCampos(9, "DT_CHC", "N", 8, 0, false)]
            public DateTime DtChc { get; set; }

            /// <summary>
            /// Data da averbação da declaração de exportação
            /// </summary>
            [SpedCampos(10, "DT_AVB", "N", 8, 0, true)]
            public DateTime DtAvb { get; set; }

            /// <summary>
            /// Tipo de conhecimento de embarque
            /// </summary>
            [SpedCampos(11, "TP_CHC", "N", 1, 0, true)]
            public int TpChc { get; set; }

            /// <summary>
            /// Código do país de destino da mercadoria (conforme tabela do SISCOMEX)
            /// </summary>
            [SpedCampos(12, "PAIS", "N", 3, 0, true)]
            public int Pais { get; set; }
        }

        /// <summary>
        /// REGISTRO 1105: DOCUMENTOS FISCAIS DE EXPORTAÇÃO
        /// </summary>
        public class Registro1105 : RegistroBaseSped
        {
            public Registro1105()
            {
                Reg = "1105";
            }

            /// <summary>
            /// Código do modelo da NF
            /// </summary>
            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Série da nota fiscal
            /// </summary>
            [SpedCampos(3, "SERIE", "C", 3, 0, false)]
            public string Serie { get; set; }

            /// <summary>
            /// Nro da nota fiscal de exportação emitida pelo exportador
            /// </summary>
            [SpedCampos(4, "NUM_DOC", "N", 9, 0, true)]
            public int NumDoc { get; set; }

            /// <summary>
            /// Chave da nota fiscal eletrônica
            /// </summary>
            [SpedCampos(5, "CHV_NFE", "N", 44, 0, false)]
            public string ChvNfe { get; set; }

            /// <summary>
            /// Data da emissão da NF de exportação
            /// </summary>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Código do item
            /// </summary>
            [SpedCampos(7, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }
        }

        public class Registro1110 : RegistroBaseSped
        {
            public Registro1110()
            {
                Reg = "1110";
            }

            /// <summary>
            /// Código do participante-fornecedor da mercadoria destinada à exportação
            /// </summary>
            [SpedCampos(2, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            /// Código do modelo da NF
            /// </summary>
            [SpedCampos(3, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Série da nota fiscal
            /// </summary>
            [SpedCampos(4, "SERIE", "C", 3, 0, false)]
            public string Serie { get; set; }

            /// <summary>
            /// Nro da nota fiscal recebida com fins específicos de exportação
            /// </summary>
            [SpedCampos(5, "NUM_DOC", "N", 9, 0, true)]
            public int NumDoc { get; set; }

            /// <summary>
            /// Data da emissão da NF de exportação
            /// </summary>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Chave da nota fiscal eletrônica
            /// </summary>
            [SpedCampos(7, "CHV_NFE", "N", 44, 0, false)]
            public string ChvNfe { get; set; }

            /// <summary>
            /// Nro do memorando de exportação
            /// </summary>
            [SpedCampos(8, "NR_MEMO", "N", 0, 0, false)]
            public string CodItem { get; set; }

            /// <summary>
            /// Quantidade do item efetivamente exportado
            /// </summary>
            [SpedCampos(9, "QTD", "N", 0, 3, true)]
            public int Qtd { get; set; }

            /// <summary>
            /// Unidade do item
            /// </summary>
            [SpedCampos(10, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }
        }

        /// <summary>
        /// REGISTRO 1200: CONTROLE DE CRÉDITOS FISCAIS - ICMS
        /// </summary>
        public class Registro1200 : RegistroBaseSped
        {
            public Registro1200()
            {
                Reg = "1200";
            }

            /// <summary>
            /// Código de ajuste
            /// </summary>
            [SpedCampos(2, "COD_AJ_APUR", "C", 8, 0, true)]
            public string CodAjApur { get; set; }

            /// <summary>
            /// Saldo de créditos fiscais de períodos anteriores
            /// </summary>
            [SpedCampos(3, "SLD_CRED", "N", 0, 2, true)]
            public decimal SldCred { get; set; }

            /// <summary>
            /// Total de credito apropriado no mês
            /// </summary>
            [SpedCampos(4, "CRED_APR", "N", 0, 2, true)]
            public decimal CredApr { get; set; }

            /// <summary>
            /// Total de créditos recebidos por transferência
            /// </summary>
            [SpedCampos(5, "CRED_RECEB", "N", 0, 2, true)]
            public decimal CredReceb { get; set; }

            /// <summary>
            /// Total de créditos utilizados no período
            /// </summary>
            [SpedCampos(6, "CRED_UTIL", "N", 0, 2, true)]
            public decimal CredUtil { get; set; }

            /// <summary>
            /// Saldo de crédito fiscal acumulado a transportar para o período seguinte
            /// </summary>
            [SpedCampos(7, "SLD_CRED_FIM", "N", 0, 2, true)]
            public decimal SldCredFim { get; set; }
        }

        /// <summary>
        /// REGISTRO 1210: UTILIZAÇÃO DE CRÉDITOS FISCAIS - ICMS
        /// </summary>
        public class Registro1210 : RegistroBaseSped
        {
            public Registro1210()
            {
                Reg = "1210";
            }

            /// <summary>
            /// Tipo de utilização do crédito
            /// </summary>
            [SpedCampos(2, "TIPO_UTIL", "C", 4, 0, true)]
            public string TipoUtil { get; set; }

            /// <summary>
            /// Nro do documento utilizado na baixa de créditos
            /// </summary>
            [SpedCampos(3, "NR_DOC", "C", 0, 0, false)]
            public string NrDoc { get; set; }

            /// <summary>
            /// Total de crédito utilizado
            /// </summary>
            [SpedCampos(4, "VL_CRED_UTIL", "N", 0, 2, true)]
            public decimal VlCredUtil { get; set; }
        }

        /// <summary>
        /// REGISTRO 1990: ENCERRAMENTO DO BLOCO 1
        /// </summary>
        public class Registro1990 : RegistroBaseSped
        {
            public Registro1990()
            {
                Reg = "1990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 1.
            /// </summary>
            [SpedCampos(2, "QTD_LIN_1", "N", 0, 0, true)]
            public int QtdLin1 { get; set; }
        }
    }
}

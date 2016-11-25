using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO D: DOCUMENTOS FISCAIS II - SERVIÇOS (ICMS)
    /// </summary>
    public class BlocoD
    {
        /// <summary>
        /// REGISTRO D001: ABERTURA DO BLOCO D
        /// </summary>
        public class RegistroD001 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroD001()
            {
                Reg = "D001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        /// REGISTRO D100: NOTA FISCAL DE SERVIÇO DE TRANSPORTE (CÓDIGO 07) E CONHECIMENTOS DE TRANSPORTE RODOVIÁRIO DE CARGAS (CÓDIGO 08), 
        /// CONHECIMENTOS DE TRANSPORTE DE CARGAS AVULSO (CÓDIGO 8B), AQUAVIÁRIO DE CARGAS (CÓDIGO 09), AÉREO (CÓDIGO 10), FERROVIÁRIO DE CARGAS (CÓDIGO 11) E 
        /// MULTIMODAL DE CARGAS (CÓDIGO 26), NOTA FISCAL DE TRANSPORTE FERROVIÁRIO DE CARGA ( CÓDIGO 27) E CONHECIMENTO DE TRANSPORTE ELETRÔNICO – CT-e (CÓDIGO 57). 
        /// </summary>
        public class RegistroD100 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroD100()
            {
                Reg = "D100";
            }

            /// <summary>
            /// Indicador do tipo de operação: 
            /// 0- Aquisição; 
            /// 1- Prestação
            /// </summary>
            [SpedCampos(2, "IND_OPER", "C", 1, 0, true)]
            public int IndOper { get; set; }

            /// <summary>
            /// Indicador do emitente do documento fiscal:
            /// 0 - Emissão própria;
            /// 1 - Terceiros;
            /// </summary>
            [SpedCampos(3, "IND_EMIT", "C", 1, 0, true)]
            public int IndEmit { get; set; }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150):
            /// - do emitente do documento ou do remetente das mercadorias, no caso de entradas;
            /// - do adquirente, no caso de saídas.
            /// </summary>
            [SpedCampos(4, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            [SpedCampos(5, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            [SpedCampos(6, "COD_SIT", "N", 2, 0, true)]
            public int CodSit { get; set; }

            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            [SpedCampos(7, "SER", "C", 4, 0, false)]
            public string Ser { get; set; }

            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            [SpedCampos(8, "SUB", "C", 3, 0, false)]
            public string Sub { get; set; }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            [SpedCampos(9, "NUM_DOC", "N", 9, 0, true)]
            public string NumDoc { get; set; }

            /// <summary>
            /// Chave do Conhecimento de Transporte Eletrônico
            /// </summary>
            [SpedCampos(10, "CHV_CTE", "N", 44, 0, false)]
            public string ChvCte { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(11, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Data da aquisição ou da prestação do serviço
            /// </summary>
            [SpedCampos(12, "DT_DOC", "N", 8, 0, false)]
            public DateTime DtAP { get; set; }

            /// <summary>
            ///Tipo de Conhecimento de Transporte Eletrônico conforme definido no Manual de Integração do CT-e
            /// </summary>
            [SpedCampos(13, "TP_CT-e", "N", 1, 0, false)]
            public int TpCte { get; set; }

            /// <summary>
            /// Chave do CT-e de referência cujos valores foram complementados (opção “1” do campo anterior) ou cujo débito foi anulado(opção “2” do campo anterior). 
            /// </summary>
            [SpedCampos(14, "CHV_CTE_REF", "N", 44, 0, false)]
            public string ChvCteRef { get; set; }

            /// <summary>
            /// Valor total do documento fisca
            /// </summary>
            [SpedCampos(15, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            [SpedCampos(16, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Indicador do tipo do frete: 
            /// 0- Por conta de terceiros; 
            /// 1- Por conta do emitente; 
            /// 2- Por conta do destinatário; 
            /// 9- Sem cobrança de frete.
            /// </summary>
            [SpedCampos(17, "IND_FRT", "N", 1, 0, true)]
            public int IndFrt { get; set; }

            /// <summary>
            /// Valor total do serviço
            /// </summary>
            [SpedCampos(18, "VL_SERV", "N", 0, 2, true)]
            public decimal VlServ { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            [SpedCampos(19, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            [SpedCampos(20, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            [SpedCampos(21, "VL_NT", "N", 0, 2, false)]
            public decimal VlNt { get; set; }

            /// <summary>
            ///  Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            [SpedCampos(22, "COD_INF", "C", 6, 0, false)]
            public string CodInf { get; set; }

            /// <summary>
            ///  Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            [SpedCampos(22, "COD_CTA", "C", 0, 0, false)]
            public string CodCta { get; set; }
        }

        /// <summary>
        /// REGISTRO D190: REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGO 07, 08, 8B, 09, 10, 11, 26, 27 e 57).
        /// </summary>
        public class RegistroD190 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroD190()
            {
                Reg = "D190";
            }

            /// <summary>
            /// Código da Situação Tributária referente ao ICMS, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            /// <summary>
            /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
            /// </summary>
            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, true)]
            public decimal AliqIcms { get; set; }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, true)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação CST_ICMS,  CFOP e alíquota do ICMS
            /// </summary>
            [SpedCampos(7, "VL_ICMS", "N", 0, 2, true)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(8, "VL_RED_BC", "N", 0, 2, true)]
            public decimal VlRedBc { get; set; }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            [SpedCampos(9, "COD_OBS", "C", 6, 0, false)]
            public int CodObs { get; set; }
        }

        /// <summary>
        /// REGISTRO D990: ENCERRAMENTO DO BLOCO D.
        /// </summary>
        public class RegistroD990 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroD990()
            {
                Reg = "D990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco D
            /// </summary>
            [SpedCampos(2, "QTD_LIN_D", "N", Int32.MaxValue, 0, true)]
            public int QtdLinD { get; set; }
        }
    }
}

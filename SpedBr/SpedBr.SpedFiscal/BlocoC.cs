using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO C: DOCUMENTOS FISCAIS I - MERCADORIAS (ICMS/IPI)
    /// </summary>
    public class BlocoC
    {
        /// <summary>
        /// REGISTRO C001: ABERTURA DO BLOCO C
        /// </summary>
        public class RegistroC001 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC001"/>.
            /// </summary>
            public RegistroC001()
            {
                Reg = "C001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        /// REGISTRO C100: Nota fiscal, Nota fiscal avulsa, Nota fiscal de produtor, NF-e e NFC-e
        /// </summary>
        public class RegistroC100 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC100"/>.
            /// </summary>
            public RegistroC100()
            {
                Reg = "C100";
            }

            /// <summary>
            /// Indicador do tipo de operação:
            /// 0 - Entrada;
            /// 1 - Saída.
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
            [SpedCampos(7, "SER", "C", 3, 0, false)]
            public string Ser { get; set; }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            [SpedCampos(8, "NUM_DOC", "N", 9, 0, true)]
            public string NumDoc { get; set; }

            /// <summary>
            /// Chave da nota fiscal eletrônica
            /// </summary>
            [SpedCampos(9, "CHV_NFE", "N", 44, 0, false)]
            public string ChvNfe { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(10, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Data da entrada ou da saída
            /// </summary>
            [SpedCampos(11, "DT_E_S", "N", 8, 0, false)]
            public DateTime DtEs { get; set; }

            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            [SpedCampos(12, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            /// <summary>
            /// Indicador do tipo de pagamento:
            /// 0 - À vista;
            /// 1 - A prazo;
            /// 2 - Outros (a partir de 01/07/2012).
            /// 9 - Sem pagamento (até 30/06/2012).
            /// </summary>
            [SpedCampos(13, "IND_PGTO", "C", 1, 0, true)]
            public int IndPgto { get; set; }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            [SpedCampos(14, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Abatimento não tributado e não comercial.
            /// Ex.: desconto ICMS nas remessas para ZFM.
            /// </summary>
            [SpedCampos(15, "VL_ABAT_NT", "N", 0, 2, false)]
            public decimal VlAbatNt { get; set; }

            /// <summary>
            /// Valor total das mercadorias e serviços
            /// </summary>
            [SpedCampos(16, "VL_MERC", "N", 0, 2, false)]
            public decimal VlMerc { get; set; }

            /// <summary>
            /// Indicador do tipo do frete:
            /// 0 - Por conta do emitente;
            /// 1 - Por conta do destinatário/remetente;
            /// 2 - Por conta de terceiros;
            /// 9 - Sem cobrança de frete.
            /// </summary>
            [SpedCampos(17, "IND_FRT", "C", 1, 0, true)]
            public int IndFrt { get; set; }

            /// <summary>
            /// Valor do frete indicado no documento fiscal
            /// </summary>
            [SpedCampos(18, "VL_FRT", "N", 0, 2, false)]
            public decimal VlFrt { get; set; }

            /// <summary>
            /// Valor do seguro indicado no documento fiscal
            /// </summary>
            [SpedCampos(19, "VL_SEG", "N", 0, 2, false)]
            public decimal VlSeg { get; set; }

            /// <summary>
            /// Valor de outras despesas acessórias
            /// </summary>
            [SpedCampos(20, "VL_OUT_DA", "N", 0, 2, false)]
            public decimal VlOutDa { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            [SpedCampos(21, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            [SpedCampos(22, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ICMS substituição tributária
            /// </summary>
            [SpedCampos(23, "VL_BC_ICMS_ST", "N", 0, 2, false)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Valor do ICMS retido por substituição tributária
            /// </summary>
            [SpedCampos(24, "VL_ICMS_ST", "N", 0, 2, false)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Valor total do IPI
            /// </summary>
            [SpedCampos(25, "VL_IPI", "N", 0, 2, false)]
            public decimal VlIpi { get; set; }

            /// <summary>
            /// Valor total do PIS
            /// </summary>
            [SpedCampos(26, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            [SpedCampos(27, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Valor total do PIS retido por substituição tributária
            /// </summary>
            [SpedCampos(28, "VL_PIS_ST", "N", 0, 2, false)]
            public decimal VlPisSt { get; set; }

            /// <summary>
            /// Valor total da COFINS retido por substituição tributária
            /// </summary>
            [SpedCampos(29, "VL_COFINS_ST", "N", 0, 2, false)]
            public decimal VlCofinsSt { get; set; }
        }

        /// <summary>
        /// REGISTRO C101: INFORMAÇÃO COMPLEMENTAR DOS DOCUMENTOS FISCAIS QUANDO DAS OPERAÇÕES INTERESTADUAIS DESTINADAS A CONSUMIDOR FINAL NÃO CONTRIBUINTE EC 87/15 (CÓDIGO 55)
        /// </summary>
        public class RegistroC101 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC101"/>.
            /// </summary>
            public RegistroC101()
            {
                Reg = "C101";
            }

            /// <summary>
            /// Valor total relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino
            /// </summary>
            [SpedCampos(2, "VL_FCP_UF_DEST", "N", 0, 2, true)]
            public decimal VlFcpUfDest { get; set; }

            /// <summary>
            /// Valor total do ICMS Interestadual para a UF de destino
            /// </summary>
            [SpedCampos(3, "VL_ICMS_UF_DEST", "N", 0, 2, true)]
            public decimal VlIcmsUfDest { get; set; }

            /// <summary>
            /// Valor total do ICMS Interestadual para a UF do remetente
            /// </summary>
            [SpedCampos(4, "VL_ICMS_UF_REM", "N", 0, 2, true)]
            public decimal VlIcmsUfRem { get; set; }
        }

        /// <summary>
        /// OPERAÇÕES COM ICMS ST RECOLHIDO PARA UF DIVERSA DO DESTINATÁRIO DO DOCUMENTO FISCAL (CÓDIGO 55)
        /// </summary>
        public class RegistroC105 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC105"/>.
            /// </summary>
            public RegistroC105()
            {
                Reg = "C105";
            }

            /// <summary>
            /// Indicador do tipo de operação:
            /// 0 - Combustíveis e lubrificantes;
            /// 1 - Leasing de veículos ou faturamento direto.
            /// </summary>
            [SpedCampos(2, "OPER", "N", 1, 0, true)]
            public int Oper { get; set; }

            /// <summary>
            /// Sigla da UF de destino do ICMS_ST
            /// </summary>
            [SpedCampos(3, "UF", "C", 2, 0, true)]
            public string Uf { get; set; }
        }

        /// <summary>
        /// INFORMAÇÃO COMPLEMENTAR DA NOTA FISCAL (CÓDIGO 01, 1B, 04 e 55)
        /// </summary>
        public class RegistroC110 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC110"/>.
            /// </summary>
            public RegistroC110()
            {
                Reg = "C110";
            }

            /// <summary>
            /// Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            [SpedCampos(2, "COD_INF", "C", 6, 0, true)]
            public string CodInf { get; set; }

            /// <summary>
            /// Descrição complementar do código de referência
            /// </summary>
            [SpedCampos(3, "TXT_COMPL", "C", 999, 0, false)]
            public string TxtCompl { get; set; }
        }

        /// <summary>
        /// PROCESSO REFERENCIADO
        /// </summary>
        public class RegistroC111 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC111"/>.
            /// </summary>
            public RegistroC111()
            {
                Reg = "C111";
            }

            /// <summary>
            /// Identificação do processo ou ato concessório.
            /// </summary>
            [SpedCampos(2, "NUM_PROC", "C", 15, 0, true)]
            public string NumProc { get; set; }

            /// <summary>
            /// Indicador da origem do processo:
            /// 0 - SEFAZ;
            /// 1 - Justiça Federal;
            /// 2 - Justiça Estadual;
            /// 3 - SECEX/SRF;
            /// 9 - Outros.
            /// </summary>
            [SpedCampos(3, "IND_PROC", "C", 1, 0, true)]
            public int IndProc { get; set; }
        }

        /// <summary>
        /// DOCUMENTO DE ARRECADAÇÃO REFERENCIADO
        /// </summary>
        public class RegistroC112 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC112"/>.
            /// </summary>
            public RegistroC112()
            {
                Reg = "C112";
            }

            /// <summary>
            /// Código do modelo do documento de arrecadação:
            /// 0 - documento estadual de arrecadação
            /// 1 - GNRE
            /// </summary>
            [SpedCampos(2, "COD_DA", "C", 1, 0, true)]
            public int CodDa { get; set; }

            /// <summary>
            /// Unidade federada beneficiária do recolhimento
            /// </summary>
            [SpedCampos(3, "UF", "C", 2, 0, true)]
            public string Uf { get; set; }

            /// <summary>
            /// Número do documento de arrecadação
            /// </summary>
            [SpedCampos(4, "NUM_DA", "C", 999, 0, false)]
            public string NumDa { get; set; }

            /// <summary>
            /// Código completo da autenticação bancária
            /// </summary>
            [SpedCampos(5, "COD_AUT", "C", 999, 0, false)]
            public string Cod_Aut { get; set; }

            /// <summary>
            /// Valor do total do documento de arrecadação (principal, atualização monetária, juros e multa)
            /// </summary>
            [SpedCampos(6, "VL_DA", "N", 0, 2, true)]
            public decimal VlDa { get; set; }

            /// <summary>
            /// Data de vencimento do documento de arrecadação
            /// </summary>
            [SpedCampos(6, "DT_VCTO", "N", 8, 0, true)]
            public DateTime DtVcto { get; set; }

            /// <summary>
            /// Data de pagamento do documento de arrecadação ou data do vencimento, no caso de ICMS antecipado a recolher.
            /// </summary>
            [SpedCampos(7, "DT_PGTO", "N", 8, 0, true)]
            public DateTime DtPgto { get; set; }
        }

        /// <summary>
        /// DOCUMENTO FISCAL REFERENCIADO
        /// </summary>
        public class RegistroC113 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC113"/>.
            /// </summary>
            public RegistroC113()
            {
                Reg = "C113";
            }

            /// <summary>
            /// Indicador do tipo de operação:
            /// 0 - Entrada/aquisição
            /// 1 - Saída/prestação
            /// </summary>
            [SpedCampos(2, "IND_OPER", "C", 1, 0, true)]
            public int IndOper { get; set; }

            /// <summary>
            /// Indicador do emitente do título:
            /// 0 - Emissão própria
            /// 1 - Terceiros
            /// </summary>
            [SpedCampos(3, "IND_EMIT", "C", 1, 0, true)]
            public int IndEmit { get; set; }

            /// <summary>
            /// Código do participante emitente do documento referenciado
            /// </summary>
            [SpedCampos(4, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            /// Código do documento fiscal
            /// </summary>
            [SpedCampos(5, "COD_MOD", "C", 2, 0, true)]
            public int CodMod { get; set; }

            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            [SpedCampos(6, "SER", "C", 4, 0, false)]
            public string Ser { get; set; }

            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            [SpedCampos(7, "SUB", "C", 3, 0, false)]
            public string Sub { get; set; }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            [SpedCampos(8, "NUM_DOC", "N", 9, 0, true)]
            public string NumDoc { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(9, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }
        }

        /// <summary>
        /// CUPOM FISCAL REFERENCIADO
        /// </summary>
        public class RegistroC114 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC114"/>.
            /// </summary>
            public RegistroC114()
            {
                Reg = "C114";
            }

            /// <summary>
            /// Código do modelo do documento fiscal
            /// </summary>
            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public int CodMod { get; set; }

            /// <summary>
            /// Número de série de fabricação do ECF
            /// </summary>
            [SpedCampos(3, "ECF_FAB", "C", 21, 0, true)]
            public string EcfFab { get; set; }

            /// <summary>
            /// Número do caixa atribuído ao ECF
            /// </summary>
            [SpedCampos(4, "ECF_CX", "N", 3, 0, true)]
            public int EcfCx { get; set; }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            [SpedCampos(5, "NUM_DOC", "N", 9, 0, true)]
            public string NumDoc { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }
        }

        /// <summary>
        /// REGISTRO C115: LOCAL DA COLETA E/OU ENTREGA (CÓDIGO 01, 1B E 04)
        /// </summary>
        public class RegistroC115 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC115"/>.
            /// </summary>
            public RegistroC115()
            {
                Reg = "C115";
            }

            /// <summary>
            /// Indicador do tipo de transporte
            /// </summary>
            /// <remarks>
            /// 0 - Rodoviário;
            /// 1 - Ferroviário;
            /// 2 - Rodo-Ferroviário;
            /// 3 - Aquaviário;
            /// 4 - Dutoviário;
            /// 5 - Aéreo;
            /// 9 - Outros.
            /// </remarks>
            [SpedCampos(2, "IND_CARGA", "N", 1, 0, true)]
            public int IndCarga { get; set; }

            /// <summary>
            /// Número do CNPJ do contribuinte do local de coleta
            /// </summary>
            [SpedCampos(3, "CNPJ_COL", "N", 14, 0, false)]
            public string CnpjCol { get; set; }

            /// <summary>
            /// Inscrição estadual do contribuinte do local de coleta
            /// </summary>
            [SpedCampos(4, "IE_COL", "C", 14, 0, false)]
            public string IeCol { get; set; }

            /// <summary>
            /// CPF do contribuinte do local de coleta das mercadorias
            /// </summary>
            [SpedCampos(5, "CPF_COL", "N", 11, 0, false)]
            public string CpfCol { get; set; }

            /// <summary>
            /// Código do município do local de coleta
            /// </summary>
            [SpedCampos(6, "COD_MUN_COL", "N", 7, 0, false)]
            public string CodMunCol { get; set; }

            /// <summary>
            /// Número do CNPJ do contribuinte do local de entrega
            /// </summary>
            [SpedCampos(7, "CNPJ_ENTG", "N", 14, 0, false)]
            public string CnpjEntg { get; set; }

            /// <summary>
            /// Inscrição estadual do contribuinte do local de entrega
            /// </summary>
            [SpedCampos(8, "IE_ENTG", "C", 14, 0, false)]
            public string IeEntg { get; set; }

            /// <summary>
            /// CPF do contribuinte do local de entrega
            /// </summary>
            [SpedCampos(9, "CPF_ENTG", "N", 11, 0, false)]
            public string CpfEntg { get; set; }

            /// <summary>
            /// Código do município do local de entrega
            /// </summary>
            [SpedCampos(10, "COD_MUN_ENTG", "N", 7, 0, false)]
            public string CodMunEntg { get; set; }
        }

        /// <summary>
        /// REGISTRO C116: CUPOM FISCAL ELETRÔNICO REFERENCIADO
        /// </summary>
        public class RegistroC116 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC116"/>.
            /// </summary>
            public RegistroC116()
            {
                Reg = "C116";
            }

            /// <summary>
            /// Código do modelo do documento fiscal
            /// </summary>
            /// <remarks>
            /// Preenchimento: Deve corresponder ao código do Cupom Fiscal Eletrônico (59).
            /// </remarks>
            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Número de série do equipamento SAT
            /// </summary>
            [SpedCampos(3, "NR_SAT", "N", 9, 0, true)]
            public string NrSat { get; set; }

            /// <summary>
            /// Chave do cupom fiscal eletrônico
            /// </summary>
            [SpedCampos(4, "CHV_CFE", "N", 44, 0, true)]
            public string ChvCfe { get; set; }

            /// <summary>
            /// Número do cupom fiscal eletrônico
            /// </summary>
            [SpedCampos(5, "NUM_CFE", "N", 6, 0, true)]
            public int NumCfe { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            /// <remarks>
            /// Preenchimento: Informar a data de emissão do documento, no formato "ddmmaaaa".
            /// </remarks>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }
        }

        /// <summary>
        /// REGISTRO C120: COMPLEMENTO DE DOCUMENTO - OPERAÇÕES DE IMPORTAÇÃO (CÓDIGOS 01 E 55)
        /// </summary>
        public class RegistroC120 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC120"/>.
            /// </summary>
            public RegistroC120()
            {
                Reg = "C120";
            }

            /// <summary>
            /// Documento de importação
            /// </summary>
            /// <remarks>
            /// 0 - Declaração de Importação <para />
            /// 1 - Declaração Simplificada de Importação
            /// </remarks>
            [SpedCampos(2, "COD_DOC_IMP", "C", 1, 0, true)]
            public int CodDocImp { get; set; }

            /// <summary>
            /// Número do documento de importação
            /// </summary>
            [SpedCampos(3, "NUM_DOC_IMP", "C", 12, 0, true)]
            public string NumDocImp { get; set; }

            /// <summary>
            /// Valor pago de PIS na importação
            /// </summary>
            [SpedCampos(4, "PIS_IMP", "N", 0, 2, false)]
            public decimal PisImp { get; set; }

            /// <summary>
            /// Valor pago de COFINS na importação
            /// </summary>
            [SpedCampos(5, "COFINS_IMP", "N", 0, 2, false)]
            public decimal CofinsImp { get; set; }

            /// <summary>
            /// Número do Ato Concessório do regime Drawback
            /// </summary>
            [SpedCampos(6, "NUM_ACDRAW", "C", 20, 0, false)]
            public string NumAcDraw { get; set; }
        }

        /// <summary>
        /// REGISTRO C130: ISSQN, IRRF E PREVIDÊNCIA SOCIAL
        /// </summary>
        public class RegistroC130 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC130"/>.
            /// </summary>
            public RegistroC130()
            {
                Reg = "C130";
            }

            /// <summary>
            /// Valor dos serviços sob não-incidência ou não tributados pelo ICMS
            /// </summary>
            [SpedCampos(2, "VL_SERV_NT", "N", 0, 2, true)]
            public decimal VlServNt { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ISSQN
            /// </summary>
            [SpedCampos(3, "VL_BC_ISSQN", "N", 0, 2, true)]
            public decimal VlBcIssqn { get; set; }

            /// <summary>
            /// Valor do ISSQN
            /// </summary>
            [SpedCampos(4, "VL_ISSQN", "N", 0, 2, false)]
            public decimal VlIssqn { get; set; }

            /// <summary>
            /// Valor da base de cálculo do imposto de renda retido na fonte
            /// </summary>
            [SpedCampos(5, "VL_BC_IRRF", "N", 0, 2, false)]
            public decimal VlBcIrrf { get; set; }

            /// <summary>
            /// Valor do imposto de renda retido na fonte
            /// </summary>
            [SpedCampos(6, "VL_IRRF", "N", 0, 2, false)]
            public decimal VlIrrf { get; set; }

            /// <summary>
            /// Valor da base de cálculo de retenção da previdência social
            /// </summary>
            [SpedCampos(7, "VL_BC_PREV", "N", 0, 2, false)]
            public decimal VlBcPrev { get; set; }

            /// <summary>
            /// Valor destacado para retenção da previdência social
            /// </summary>
            [SpedCampos(8, "VL_PREV", "N", 0, 2, false)]
            public decimal VlPrev { get; set; }
        }

        /// <summary>
        /// REGISTRO C140: FATURA (CÓDIGO 01)
        /// </summary>
        public class RegistroC140 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC140"/>.
            /// </summary>
            public RegistroC140()
            {
                Reg = "C140";
            }

            /// <summary>
            /// Indicador do emitente do título
            /// </summary>
            /// <remarks>
            /// 0 - Emissão própria;<para />
            /// 1 - Terceiros.
            /// </remarks>
            [SpedCampos(2, "IND_EMIT", "C", 1, 0, true)]
            public int IndEmit { get; set; }

            /// <summary>
            /// Indicador do tipo de título de crédito
            /// </summary>
            /// <remarks>
            /// 00 - Duplicata;<para />
            /// 01 - Cheque;<para />
            /// 02 - Promissória;<para />
            /// 03 - Recibo;<para />
            /// 99 - Outros (descrever)
            /// </remarks>
            [SpedCampos(3, "IND_TIT", "C", 2, 0, true)]
            public int IndTit { get; set; }

            /// <summary>
            /// Descrição complementar do título de crédito
            /// </summary>
            [SpedCampos(4, "DESC_TIT", "C", 999, 0, false)]
            public string DescTit { get; set; }

            /// <summary>
            /// Número ou código identificador do título de crédito
            /// </summary>
            [SpedCampos(5, "NUM_TIT", "C", 999, 0, true)]
            public string NumTit { get; set; }

            /// <summary>
            /// Quantidade de parcelas a receber/pagar
            /// </summary>
            [SpedCampos(6, "QTD_PARC", "N", 2, 0, true)]
            public int QtdParc { get; set; }

            /// <summary>
            /// Valor total dos títulos de créditos
            /// </summary>
            [SpedCampos(7, "VL_TIT", "N", 0, 2, true)]
            public decimal VlTit { get; set; }
        }

        /// <summary>
        /// REGISTRO C141: VENCIMENTO DA FATURA (CÓDIGO 01)
        /// </summary>
        public class RegistroC141 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC141"/>.
            /// </summary>
            public RegistroC141()
            {
                Reg = "C141";
            }

            /// <summary>
            /// Número da parcela a receber/pagar
            /// </summary>
            [SpedCampos(2, "NUM_PARC", "N", 2, 0, true)]
            public int NumParc { get; set; }

            /// <summary>
            /// Data de vencimento da parcela
            /// </summary>
            [SpedCampos(3, "DT_VCTO", "N", 8, 0, true)]
            public DateTime DtVcto { get; set; }

            /// <summary>
            /// Valor da parcela a receber/pagar
            /// </summary>
            [SpedCampos(4, "VL_PARC", "N", 0, 2, true)]
            public decimal VlParc { get; set; }
        }

        /// <summary>
        /// REGISTRO 160: VOLUMES TRANSPORTADOS (CÓDIGO 01 E 04) - EXCETO COMBUSTÍVEIS
        /// </summary>
        public class RegistroC160 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC160"/>.
            /// </summary>
            public RegistroC160()
            {
                Reg = "C160";
            }

            /// <summary>
            /// Código do participante transportador, se houver
            /// </summary>
            [SpedCampos(2, "COD_PART", "C", 60, 0, false)]
            public string CodPart { get; set; }

            /// <summary>
            /// Placa de identificação do veículo automotor
            /// </summary>
            [SpedCampos(3, "VEIC_ID", "C", 7, 0, false)]
            public string VeicId { get; set; }

            /// <summary>
            /// Quantidade de volumes transportados
            /// </summary>
            [SpedCampos(4, "QTD_VOL", "N", Int32.MaxValue, 0, true)]
            public int QtdVol { get; set; }

            /// <summary>
            /// Peso bruto dos volumes transportados (em Kg)
            /// </summary>
            [SpedCampos(5, "PESO_BRT", "N", 0, 2, true)]
            public decimal PesoBrt { get; set; }

            /// <summary>
            /// Peso líquido dos volumes transportados (em Kg)
            /// </summary>
            [SpedCampos(6, "PESO_LIQ", "N", 0, 2, true)]
            public decimal PesoLiq { get; set; }

            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            [SpedCampos(7, "UF_ID", "C", 2, 0, false)]
            public string UfId { get; set; }
        }

        /// <summary>
        /// REGISTRO C165: OPERAÇÕES COM COMBUSTÍVEIS (CÓDIGO 01)
        /// </summary>
        public class RegistroC165 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC165"/>.
            /// </summary>
            public RegistroC165()
            {
                Reg = "C165";
            }

            /// <summary>
            /// Código do participante transportador, se houver
            /// </summary>
            [SpedCampos(2, "COD_PART", "C", 60, 0, false)]
            public string CodPart { get; set; }

            /// <summary>
            /// Placa de identificação do veículo
            /// </summary>
            [SpedCampos(3, "VEIC_ID", "C", 7, 0, true)]
            public string VeicId { get; set; }

            /// <summary>
            /// Código de autorização fornecido pela SEFAZ (combustíveis)
            /// </summary>
            [SpedCampos(4, "COD_AUT", "C", 999, 0, false)]
            public string CodAut { get; set; }

            /// <summary>
            /// Número do passe fiscal
            /// </summary>
            [SpedCampos(5, "NR_PASSE", "C", 999, 0, false)]
            public string NrPasse { get; set; }

            /// <summary>
            /// Hora da saída das mercadorias
            /// </summary>
            [SpedCampos(6, "HORA", "H", 6, 0, true)]
            public DateTime Hora { get; set; }

            /// <summary>
            /// Temperatura em graus Celsius utilizada para quantificação do volume de combustível
            /// </summary>
            [SpedCampos(7, "TEMPER", "N", 0, 1, false)]
            public decimal Temper { get; set; }

            /// <summary>
            /// Quantidade de volumes transportados
            /// </summary>
            [SpedCampos(8, "QTD_VOL", "N", 0, 0, true)]
            public int QtdVol { get; set; }

            /// <summary>
            /// Peso bruto dos volumes transportados (em Kg)
            /// </summary>
            [SpedCampos(9, "PESO_BRT", "N", 0, 2, true)]
            public decimal PesoBrt { get; set; }

            /// <summary>
            /// Peso líquido dos volumes transportados (em Kg)
            /// </summary>
            [SpedCampos(10, "PESO_LIQ", "N", 0, 2, true)]
            public decimal PesoLiq { get; set; }

            /// <summary>
            /// Nome do motorista
            /// </summary>
            [SpedCampos(11, "NOM_MOT", "C", 60, 0, false)]
            public string NomMot { get; set; }

            /// <summary>
            /// CPF do motorista
            /// </summary>
            [SpedCampos(12, "CPF", "N", 11, 0, false)]
            public string Cpf { get; set; }

            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            [SpedCampos(13, "UF_ID", "C", 2, 0, false)]
            public string UfId { get; set; }
        }

        /// <summary>
        /// REGISTRO 170: ITENS DO DOCUMENTO (CÓDIGO 01, 1B, 04 e 55)
        /// </summary>
        public class RegistroC170 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC170"/>.
            /// </summary>
            public RegistroC170()
            {
                Reg = "C170";
            }

            /// <summary>
            /// Número sequencial do item no documento fiscal
            /// </summary>
            [SpedCampos(2, "NUM_ITEM", "N", 3, 0, true)]
            public int NumItem { get; set; }

            /// <summary>
            /// Código do item
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            /// Descrição complementar do item como adotado no documento fiscal
            /// </summary>
            [SpedCampos(4, "DESCR_COMPL", "C", 999, 0, false)]
            public string DescrCompl { get; set; }

            /// <summary>
            /// Quantidade do item
            /// </summary>
            [SpedCampos(5, "QTD", "N", 0, 5, true)]
            public decimal Qtd { get; set; }

            /// <summary>
            /// Unidade do item
            /// </summary>
            [SpedCampos(6, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            /// <summary>
            /// Valor total do item (mercadorias ou serviços)
            /// </summary>
            [SpedCampos(7, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            /// <summary>
            /// Valor do desconto comercial
            /// </summary>
            [SpedCampos(8, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Indicador de movimentação física do item/produto
            /// </summary>
            /// <remarks>
            /// 0 - Sim<para />
            /// 1 - Não
            /// </remarks>
            [SpedCampos(9, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }

            /// <summary>
            /// Código da situação tributária referente ao ICMS
            /// </summary>
            [SpedCampos(10, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            /// <summary>
            /// Código fiscal de operação e prestação
            /// </summary>
            [SpedCampos(11, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            /// <summary>
            /// Código da natureza da operação
            /// </summary>
            [SpedCampos(12, "COD_NAT", "C", 10, 0, false)]
            public string CodNat { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            [SpedCampos(13, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            [SpedCampos(14, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            /// <summary>
            /// Valor do ICMS creditado/debitado
            /// </summary>
            [SpedCampos(15, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor da base de cálculo referente à substituição tributária
            /// </summary>
            [SpedCampos(16, "VL_BC_ICMS_ST", "N", 0, 2, false)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Alíquota do ICMS da substituição tributária na unidade da federação de destino
            /// </summary>
            [SpedCampos(17, "ALIQ_ST", "N", 0, 2, false)]
            public decimal AliqSt { get; set; }

            /// <summary>
            /// Valor do ICMS referente à substituição tributária
            /// </summary>
            [SpedCampos(18, "VL_ICMS_ST", "N", 0, 2, false)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Indicador do período de apuração do IPI
            /// </summary>
            /// <remarks>
            /// 0 - Mensal<para />
            /// 1 - Decendial
            /// </remarks>
            [SpedCampos(19, "IND_APUR", "C", 1, 0, false)]
            public int IndApur { get; set; }

            /// <summary>
            /// Código da situação tributária referente ao IPI
            /// </summary>
            [SpedCampos(20, "CST_IPI", "C", 2, 0, false)]
            public string CstIpi { get; set; }

            /// <summary>
            /// Código de enquadramento legal do IPI
            /// </summary>
            [SpedCampos(21, "COD_ENQ", "C", 3, 0, false)]
            public string CodEnq { get; set; }

            /// <summary>
            /// Valor da base de cálculo do IPI
            /// </summary>
            [SpedCampos(22, "VL_BC_IPI", "N", 0, 2, false)]
            public decimal VlBcIpi { get; set; }

            /// <summary>
            /// Alíquota do IPI
            /// </summary>
            [SpedCampos(23, "ALIQ_IPI", "N", 6, 2, false)]
            public decimal AliqIpi { get; set; }

            /// <summary>
            /// Valor do IPI creditado/debitado
            /// </summary>
            [SpedCampos(24, "VL_IPI", "N", 0, 2, false)]
            public decimal VlIpi { get; set; }

            /// <summary>
            /// Código da situação tributária referente ao PIS
            /// </summary>
            [SpedCampos(25, "CST_PIS", "N", 2, 0, false)]
            public int CstPis { get; set; }

            /// <summary>
            /// Valor da base de cálculo do PIS
            /// </summary>
            [SpedCampos(26, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal VlBcPis { get; set; }

            /// <summary>
            /// Alíquota do PIS (em percentual)
            /// </summary>
            [SpedCampos(27, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal AliqPis { get; set; }

            /// <summary>
            /// Quantidade - Base de cálculo PIS
            /// </summary>
            [SpedCampos(28, "QUANT_BC_PIS", "N", 0, 3, false)]
            public decimal QuantBcPis { get; set; }

            /// <summary>
            /// Alíquota do PIS (em reais)
            /// </summary>
            [SpedCampos(29, "ALIQ_PIS", "N", 0, 4, false)]
            public decimal AliqPisReais { get; set; }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            [SpedCampos(30, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// Código da situação tributária referente ao COFINS
            /// </summary>
            [SpedCampos(31, "CST_COFINS", "N", 2, 0, false)]
            public int CstCofins { get; set; }

            /// <summary>
            /// Valor da base de cálculo da COFINS
            /// </summary>
            [SpedCampos(32, "VL_BC_COFINS", "N", 0, 2, false)]
            public decimal VlBcCofins { get; set; }

            /// <summary>
            /// Alíquota do COFINS (em percentual)
            /// </summary>
            [SpedCampos(33, "ALIQ_COFINS", "N", 8, 4, false)]
            public decimal AliqCofins { get; set; }

            /// <summary>
            /// Quantidade - Base de cálculo COFINS
            /// </summary>
            [SpedCampos(34, "QUANT_BC_COFINS", "N", 0, 3, false)]
            public decimal QuantBcCofins { get; set; }

            /// <summary>
            /// Alíquota da COFINS (em reais)
            /// </summary>
            [SpedCampos(35, "ALIQ_COFINS", "N", 0, 4, false)]
            public decimal AliqCofinsReais { get; set; }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            [SpedCampos(36, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            [SpedCampos(37, "COD_CTA", "C", 999, 0, false)]
            public string CodCta { get; set; }
        }

        /// <summary>
        /// REGISTRO C177: OPERAÇÕES COM PRODUTOS SUJEITOS A SELO DE CONTROLE DE IPI
        /// </summary>
        public class RegistroC177 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC177"/>.
            /// </summary>
            public RegistroC177()
            {
                Reg = "C177";
            }

            /// <summary>
            /// Código do selo de controle do IPI
            /// </summary>
            [SpedCampos(2, "COD_SELO_IPI", "C", 6, 0, true)]
            public string CodSeloIpi { get; set; }

            /// <summary>
            /// Quantidade de selo de controle de IPI aplicada
            /// </summary>
            [SpedCampos(3, "QT_SELO_IPI", "N", 12, 0, true)]
            public double QtSeloIpi { get; set; }
        }

        /// <summary>
        /// REGISTRO C178: OPERAÇÕES COM PRODUTOS SUJEITOS À TRIBUTAÇÃO DE IPI POR UNIDADE OU QUANTIDADE DE PRODUTO
        /// </summary>
        public class RegistroC178 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC178"/>.
            /// </summary>
            public RegistroC178()
            {
                Reg = "C178";
            }

            /// <summary>
            /// Código da classe de enquadramento do IPI
            /// </summary>
            [SpedCampos(2, "CL_ENQ", "C", 5, 0, true)]
            public string ClEnq { get; set; }

            /// <summary>
            /// Valor por unidade padrão de tributação
            /// </summary>
            [SpedCampos(3, "VL_UNID", "N", 0, 2, true)]
            public decimal VlUnid { get; set; }

            /// <summary>
            /// Quantidade total de produtos na unidade padrão de tributação
            /// </summary>
            [SpedCampos(4, "QUANT_PAD", "N", 0, 3, true)]
            public decimal QuantPad { get; set; }
        }

        /// <summary>
        /// REGISTRO C179: INFORMAÇÕES COMPLEMENTARES ST (CÓDIGO 01)
        /// </summary>
        public class RegistroC179 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC179"/>.
            /// </summary>
            public RegistroC179()
            {
                Reg = "C179";
            }

            /// <summary>
            /// Valor da base de cálculo ST na origem/destino em operações interestaduais
            /// </summary>
            [SpedCampos(2, "BC_ST_ORIG_DEST", "N", 0, 2, true)]
            public decimal BcStOrigDest { get; set; }

            /// <summary>
            /// Valor do ICMS-ST a repassar/deduzir em operações interestaduais
            /// </summary>
            [SpedCampos(3, "ICMS_ST_REP", "N", 0, 2, true)]
            public decimal IcmsStRep { get; set; }

            /// <summary>
            /// Valor do ICMS-ST a complementar à UF de destino
            /// </summary>
            [SpedCampos(4, "ICMS_ST_COMPL", "N", 0, 2, false)]
            public decimal IcmsStCompl { get; set; }

            /// <summary>
            /// Valor da base de cálculo de retenção em remessa promovida por substituído intermediário
            /// </summary>
            [SpedCampos(5, "BC_RET", "N", 0, 2, false)]
            public decimal BcRet { get; set; }

            /// <summary>
            /// Valor da parcela do imposto retido em remessa promovida por substituído intermediário
            /// </summary>
            [SpedCampos(6, "ICMS_RET", "N", 0, 2, false)]
            public decimal IcmsRet { get; set; }
        }

        /// <summary>
        /// REGISTRO C190: REGISTRO ANALÍTICO DO DOCUMENTO (CÓDIGO 01, 1B, 04, 55 e 65)
        /// </summary>
        public class RegistroC190 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC190"/>.
            /// </summary>
            public RegistroC190()
            {
                Reg = "C190";
            }

            /// <summary>
            /// Código da situação tributária do ICMS
            /// </summary>
            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            /// <summary>
            /// Código fiscal de operação e prestação do agrupamento de itens
            /// </summary>
            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, true)]
            public decimal AliqIcms { get; set; }

            /// <summary>
            /// Valor da operação na combinação de CST_ICMS, CFOP e alíquota do ICMS,
            /// correspondente ao somatório do valor das mercadorias, despesas acessórias
            /// (frete, seguros e outras despesas acessórias), ICMS_ST e IPI.
            /// </summary>
            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à
            /// combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, true)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação de CST_ICMS,
            /// CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(7, "VL_ICMS", "N", 0, 2, true)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" da substituição
            /// tributária referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(8, "VL_BC_ICMS_ST", "N", 0, 2, true)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Parcela correspondente ao valor creditado/debitado do ICMS da substituição
            /// tributária, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(9, "VL_ICMS_ST", "N", 0, 2, true)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente
            /// à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(10, "VL_RED_BC", "N", 0, 2, true)]
            public decimal VlRedBc { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor do IPI" referente à combinação CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            [SpedCampos(11, "VL_IPI", "N", 0, 2, true)]
            public decimal VlIpi { get; set; }

            /// <summary>
            /// Código da observação do lançamento fiscal
            /// </summary>
            [SpedCampos(12, "COD_OBS", "C", 6, 0, false)]
            public string CodObs { get; set; }
        }

        public class RegistroC195 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC195"/>.
            /// </summary>
            public RegistroC195()
            {
                Reg = "C195";
            }

            [SpedCampos(2, "COD_OBS", "C", 6, 0, true)]
            public string CodObs { get; set; }

            [SpedCampos(3, "TXT_COMPL", "C", 999, 0, false)]
            public string TxtCompl { get; set; }
        }

        public class RegistroC197 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC197"/>.
            /// </summary>
            public RegistroC197()
            {
                Reg = "C197";
            }

            [SpedCampos(2, "COD_AJ", "C", 10, 0, true)]
            public string CodAj { get; set; }

            [SpedCampos(3, "DESCR_COMPL_AJ", "C", 999, 0, false)]
            public string DescrComplAj { get; set; }

            [SpedCampos(4, "COD_ITEM", "C", 60, 0, false)]
            public string CodItem { get; set; }

            [SpedCampos(5, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(6, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(7, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            [SpedCampos(8, "VL_OUTROS", "N", 0, 2, false)]
            public decimal VlOutros { get; set; }
        }

        public class RegistroC300 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC300"/>.
            /// </summary>
            public RegistroC300()
            {
                Reg = "C300";
            }

            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public int CodMod { get; set; }

            [SpedCampos(3, "SER", "C", 4, 0, true)]
            public string Ser { get; set; }

            [SpedCampos(4, "SUB", "C", 3, 0, false)]
            public string Sub { get; set; }

            [SpedCampos(5, "NUM_DOC_INI", "N", 6, 0, true)]
            public int NumDocIni { get; set; }

            [SpedCampos(6, "NUM_DOC_FIN", "N", 6, 0, true)]
            public int NumDocFin { get; set; }

            [SpedCampos(7, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            [SpedCampos(8, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            [SpedCampos(9, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(10, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(11, "COD_CTA", "C", 999, 0, false)]
            public string CodCta { get; set; }
        }

        public class RegistroC310 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC310"/>.
            /// </summary>
            public RegistroC310()
            {
                Reg = "C310";
            }

            [SpedCampos(2, "NUM_DOC_CANC", "N", 999, 0, true)]
            public int NumDocCanc { get; set; }
        }

        public class RegistroC320 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC320"/>.
            /// </summary>
            public RegistroC320()
            {
                Reg = "C320";
            }

            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, true)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(7, "VL_ICMS", "N", 0, 2, true)]
            public decimal VlIcms { get; set; }

            [SpedCampos(8, "VL_RED_BC", "N", 0, 2, true)]
            public decimal VlRedBc { get; set; }

            [SpedCampos(9, "COD_OBS", "C", 6, 0, false)]
            public string CodObs { get; set; }
        }

        public class RegistroC321 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC321"/>.
            /// </summary>
            public RegistroC321()
            {
                Reg = "C321";
            }

            [SpedCampos(2, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            [SpedCampos(3, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            [SpedCampos(4, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            [SpedCampos(5, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            [SpedCampos(6, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            [SpedCampos(7, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(8, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            [SpedCampos(9, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(10, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }
        }

        public class RegistroC350 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC350"/>.
            /// </summary>
            public RegistroC350()
            {
                Reg = "C350";
            }

            [SpedCampos(2, "SER", "C", 4, 0, false)]
            public string Ser { get; set; }

            [SpedCampos(3, "SUB_SER", "C", 3, 0, false)]
            public string SubSer { get; set; }

            [SpedCampos(4, "NUM_DOC", "C", 3, 0, true)]
            public int NumDoc { get; set; }

            [SpedCampos(5, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            [SpedCampos(6, "CNPJ_CPF", "N",14, 0, false)]
            public string CnpjCpf { get; set; }

            [SpedCampos(7, "VL_MERC", "N", 0, 2, true)]
            public decimal VlMerc { get; set; }

            [SpedCampos(8, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            [SpedCampos(9, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            [SpedCampos(10, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(11, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(12, "COD_CTA", "C", 999, 0, false)]
            public string CodCta { get; set; }
        }

        public class RegistroC370 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC370"/>.
            /// </summary>
            public RegistroC370()
            {
                Reg = "C370";
            }

            [SpedCampos(2, "NUM_ITEM", "N", 3, 0, true)]
            public int NumItem { get; set; }

            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            [SpedCampos(5, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            [SpedCampos(6, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            [SpedCampos(7, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }
        }

        public class RegistroC390 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC390"/>.
            /// </summary>
            public RegistroC390()
            {
                Reg = "C390";
            }

            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(7, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            [SpedCampos(8, "VL_RED_BC", "N", 0, 2, false)]
            public decimal VlRedBc { get; set; }

            [SpedCampos(9, "COD_OBS", "C", 6, 0, false)]
            public string CodObs { get; set; }
        }

        public class RegistroC400 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC400"/>.
            /// </summary>
            public RegistroC400()
            {
                Reg = "C400";
            }

            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            [SpedCampos(3, "ECF_MOD", "C", 20, 0, true)]
            public string EcfMod { get; set; }

            [SpedCampos(4, "ECF_FAB", "C", 21, 0, true)]
            public string EcfFab { get; set; }

            [SpedCampos(5, "ECF_CX", "N", 3, 0, true)]
            public int EcfCx { get; set; }
        }

        public class RegistroC405 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC405"/>.
            /// </summary>
            public RegistroC405()
            {
                Reg = "C405";
            }

            [SpedCampos(2, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            [SpedCampos(3, "CRO", "N", 3, 0, true)]
            public int Cro { get; set; }

            [SpedCampos(4, "CRZ", "N", 6, 0, true)]
            public int Crz { get; set; }

            [SpedCampos(5, "NUM_COO_FIN", "N", 9, 0, true)]
            public double NumCoofin { get; set; }

            [SpedCampos(6, "GT_FIN", "N", 0, 2, true)]
            public decimal GtFin { get; set; }

            [SpedCampos(7, "VL_BRT", "N", 0, 2, true)]
            public decimal VlBrt { get; set; }
        }

        public class RegistroC410 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC410"/>.
            /// </summary>
            public RegistroC410()
            {
                Reg = "C410";
            }

            [SpedCampos(2, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(3, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }
        }

        public class RegistroC420 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC420"/>.
            /// </summary>
            public RegistroC420()
            {
                Reg = "C420";
            }

            [SpedCampos(2, "COD_TOT_PAR", "C", 7, 0, true)]
            public string CodTotPar { get; set; }

            [SpedCampos(3, "VLR_ACUM_TOT", "N", 0, 2, true)]
            public decimal VlrAcumTot { get; set; }

            [SpedCampos(4, "NR_TOT", "N", 2, 0, false)]
            public int NrTot { get; set; }

            [SpedCampos(5, "DESCR_NR_TOT", "C", 999, 0, false)]
            public string DescrNrTot { get; set; }
        }

        public class RegistroC425 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC425"/>.
            /// </summary>
            public RegistroC425()
            {
                Reg = "C425";
            }
            
            [SpedCampos(2, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            [SpedCampos(3, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            [SpedCampos(4, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            [SpedCampos(5, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            [SpedCampos(6, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(7, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }
        }

        public class RegistroC460 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC460"/>.
            /// </summary>
            public RegistroC460()
            {
                Reg = "C460";
            }

            [SpedCampos(2, "COD_MOD", "C", 4, 0, true)]
            public string CodMod { get; set; }

            [SpedCampos(3, "COD_SIT", "N", 2, 0, true)]
            public int CodSit { get; set; }

            [SpedCampos(4, "NUM_DOC", "N", 9, 0, true)]
            public double NumDoc { get; set; }

            [SpedCampos(5, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            [SpedCampos(6, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            [SpedCampos(7, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(8, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(9, "CPF_CNPJ", "N", 14, 0, false)]
            public string CpfCnpj { get; set; }

            [SpedCampos(10, "NOM_ADQ", "C", 60, 0, false)]
            public string NomeAdq { get; set; }
        }

        public class RegistroC465 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC465"/>.
            /// </summary>
            public RegistroC465()
            {
                Reg = "C465";
            }

            [SpedCampos(2, "CHV_CFE", "N", 44, 0, true)]
            public string ChvCfe { get; set; }

            [SpedCampos(3, "NUM_CCF", "N", 9, 0, true)]
            public double NumCcf { get; set; }
        }

        public class RegistroC470 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC470"/>.
            /// </summary>
            public RegistroC470()
            {
                Reg = "C470";
            }

            [SpedCampos(2, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            [SpedCampos(3, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            [SpedCampos(4, "QTD_CANC", "N", 0, 3, false)]
            public decimal QtdCanc { get; set; }

            [SpedCampos(5, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            [SpedCampos(6, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }
        
            [SpedCampos(7, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            [SpedCampos(8, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            [SpedCampos(9, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(10, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(11, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }
        }

        public class RegistroC490 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC490"/>.
            /// </summary>
            public RegistroC490()
            {
                Reg = "C490";
            }

            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, true)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(7, "VL_ICMS", "N", 0, 2, true)]
            public decimal VlIcms { get; set; }

            [SpedCampos(8, "COD_OBS", "C", 6, 0, false)]
            public string CodObs { get; set; }
        }

        public class RegistroC495 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC495"/>.
            /// </summary>
            public RegistroC495()
            {
                Reg = "C495";
            }

            [SpedCampos(2, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            [SpedCampos(5, "QTD_CANC", "N", 0, 3, false)]
            public decimal QtdCanc { get; set; }

            [SpedCampos(6, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            [SpedCampos(7, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            [SpedCampos(8, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            [SpedCampos(9, "VL_CANC", "N", 0, 2, false)]
            public decimal VlCanc { get; set; }

            [SpedCampos(10, "VL_ACMO", "N", 0, 2, false)]
            public decimal VlAcmo { get; set; }

            [SpedCampos(11, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            [SpedCampos(12, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            [SpedCampos(13, "VL_ISEN", "N", 0, 2, false)]
            public decimal VlIsen { get; set; }

            [SpedCampos(14, "VL_NT", "N", 0, 2, false)]
            public decimal VlNt { get; set; }

            [SpedCampos(15, "VL_ICMS_ST", "N", 0, 2, false)]
            public decimal VlIcmsSt { get; set; }
        }

        /// <summary>
        /// REGISTRO C500: NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06),
        /// NOTA FISCAL/CONTA DE FORNECIMENTO D'ÁGUA CANALIZADA (CÓDIGO 29) E
        /// NOTA FISCAL CONSUMO FORNECIMENTO DE GÁS (CÓDIGO 28)
        /// </summary>
        public class RegistroC500 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC500"/>.
            /// </summary>
            public RegistroC500()
            {
                Reg = "C500";
            }

            /// <summary>
            /// Indicador do tipo de operação
            /// </summary>
            /// <remarks>
            /// 0 - Entrada<para />
            /// 1 - Saída
            /// </remarks>
            [SpedCampos(2, "IND_OPER", "C", 1, 0, true)]
            public int IndOper { get; set; }

            /// <summary>
            /// Indicador do emitente do documento fiscal
            /// </summary>
            /// <remarks>
            /// 0 - Emissão própria<para />
            /// 1 - Terceiros
            /// </remarks>
            [SpedCampos(3, "IND_EMIT", "C", 1, 0, true)]
            public int IndEmit { get; set; }

            /// <summary>
            /// Código do participante
            /// </summary>
            /// <remarks>
            /// - do adquirente, no caso das saídas<para />
            /// - do fornecedor no caso de entradas
            /// </remarks>
            [SpedCampos(4, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            /// Código do modelo do documento fiscal
            /// </summary>
            [SpedCampos(5, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Código da situação do documento fiscal
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
            [SpedCampos(8, "SUB", "N", 3, 0, false)]
            public string Sub { get; set; }

            /// <summary>
            /// Código de classe de consumo de energia elétrica ou gás
            /// </summary>
            /// <remarks>
            /// 01 - Comercial<para />
            /// 02 - Consumo Próprio<para />
            /// 03 - Iluminação Pública<para />
            /// 04 - Industrial<para />
            /// 05 - Poder Público<para />
            /// 06 - Residencial<para />
            /// 07 - Rural<para />
            /// 08 - Serviço Público<para />
            /// - Código de classe de consumo de fornecimento d'água
            /// </remarks>
            [SpedCampos(9, "COD_CONS", "C", 2, 0, true)]
            public int CodCons { get; set; }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            [SpedCampos(10, "NUM_DOC", "N", 9, 0, true)]
            public double NumDoc { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(11, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Data da entrada ou da saída
            /// </summary>
            [SpedCampos(12, "DT_E_S", "N", 8, 0, true)]
            public DateTime DtEs { get; set; }

            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            [SpedCampos(13, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            [SpedCampos(14, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Valor total fornecido/consumido
            /// </summary>
            [SpedCampos(15, "VL_FORN", "N", 0, 2, true)]
            public decimal VlForn { get; set; }

            /// <summary>
            /// Valor total dos serviços não-tributados pelo ICMS
            /// </summary>
            [SpedCampos(16, "VL_SERV_NT", "N", 0, 2, false)]
            public decimal VlServNt { get; set; }

            /// <summary>
            /// Valor total cobrado em nome de terceiros
            /// </summary>
            [SpedCampos(17, "VL_TERC", "N", 0, 2, false)]
            public decimal VlTerc { get; set; }

            /// <summary>
            /// Valor total das despesas acessórias indicadas no documento fiscal
            /// </summary>
            [SpedCampos(18, "VL_DA", "N", 0, 2, false)]
            public decimal VlDa { get; set; }

            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            [SpedCampos(19, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Valor acumulado do ICMS
            /// </summary>
            [SpedCampos(20, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS substituição tributária
            /// </summary>
            [SpedCampos(21, "VL_BC_ICMS_ST", "N", 0, 2, false)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Valor acumulado do ICMS retido por substituição tributária
            /// </summary>
            [SpedCampos(22, "VL_ICMS_ST", "N", 0, 2, false)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Código da informação complementar do documento fiscal
            /// </summary>
            [SpedCampos(23, "COD_INF", "C", 6, 0, false)]
            public string CodInf { get; set; }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            [SpedCampos(24, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            [SpedCampos(25, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Código do tipo de ligação
            /// </summary>
            /// <remarks>
            /// 1 - Monofásico<para />
            /// 2 - Bifásico<para />
            /// 3 - Trifásico
            /// </remarks>
            [SpedCampos(26, "TP_LIGACAO", "N", 1, 0, false)]
            public int TpLigacao { get; set; }

            /// <summary>
            /// Código do grupo de tensão
            /// </summary>
            /// <remarks>
            /// 01 - A1 - Alta tensão (230kV ou mais)<para />
            /// 02 - A2 - Alta tensão (88 a 138kV)<para />
            /// 03 - A3 - Alta tensão (69kV)<para />
            /// 04 - A3a - Alta tensão (30kV a 44kV)<para />
            /// 05 - A4 - Alta tensão (2,3kV a 25kV)<para />
            /// 06 - AS - Alta tensão subterrâneo
            /// 07 - B1 - Residencial
            /// 08 - B1 - Residencial baixa renda
            /// 09 - B2 - Rural
            /// 10 - B2 - Cooperativa de eletrificação rural
            /// 11 - B2 - Serviço público de irrigação
            /// 12 - B3 - Demais classes
            /// 13 - B4a - Iluminação pública - rede de distribuição
            /// 14 - B4b - Iluminação pública - bulbo de lâmpada
            /// </remarks>
            [SpedCampos(27, "COD_GRUPO_TENSAO", "C", 2, 0, false)]
            public int CodGrupoTensao { get; set; }
        }

        /// <summary>
        /// REGISTRO C510: ITENS DO DOCUMENTO NOTA FISCAL/CONTA ENERGIA ELÉTRICA (CÓDIGO 06),
        /// NOTA FISCAL/CONTA DE FORNECIMENTO D'ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL/CONTA
        /// DE FORNECIMENTO DE GÁS (CÓDIGO 28)
        /// </summary>
        public class RegistroC510 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC510"/>.
            /// </summary>
            public RegistroC510()
            {
                Reg = "C510";
            }

            /// <summary>
            /// Número sequencial do item no documento fiscal
            /// </summary>
            [SpedCampos(2, "NUM_ITEM", "N", 3, 0, true)]
            public int NumItem { get; set; }

            /// <summary>
            /// Código do item
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            /// Código de classificação do item de energia elétrica
            /// </summary>
            [SpedCampos(4, "COD_CLASS", "N", 4, 0, false)]
            public int CodClass { get; set; }

            /// <summary>
            /// Quantidade do item
            /// </summary>
            [SpedCampos(5, "QTD", "N", 0, 3, false)]
            public decimal Qtd { get; set; }

            /// <summary>
            /// Unidade do item
            /// </summary>
            [SpedCampos(6, "UNID", "C", 6, 0, false)]
            public string Unid { get; set; }

            /// <summary>
            /// Valor do item
            /// </summary>
            [SpedCampos(7, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            [SpedCampos(8, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Código da situação tributária
            /// </summary>
            [SpedCampos(9, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            /// <summary>
            /// Código fiscal de operação e prestação
            /// </summary>
            [SpedCampos(10, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            [SpedCampos(11, "VL_BC_ICMS", "N", 0, 2, false)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            [SpedCampos(12, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            /// <summary>
            /// Valor do ICMS creditado/debitado
            /// </summary>
            [SpedCampos(13, "VL_ICMS", "N", 0, 2, false)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Valor da base de cálculo referente à substituição tributária
            /// </summary>
            [SpedCampos(14, "VL_BC_ICMS_ST", "N", 0, 2, false)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Alíquota do ICMS da substituição tributária na unidade da federação de destino
            /// </summary>
            [SpedCampos(15, "ALIQ_ST", "N", 6, 2, false)]
            public decimal AliqSt { get; set; }

            /// <summary>
            /// Valor do ICMS referente à substituição tributária
            /// </summary>
            [SpedCampos(16, "VL_ICMS_ST", "N", 0, 2, false)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Indicador do tipo de receita
            /// </summary>
            /// <remarks>
            /// 0 - Receita própria<para />
            /// 1 - Receita de terceiros
            /// </remarks>
            [SpedCampos(17, "IND_REC", "C", 1, 0, true)]
            public int IndRec { get; set; }

            /// <summary>
            /// Código do participante receptor da receita
            /// </summary>
            [SpedCampos(18, "COD_PART", "C", 60, 0, false)]
            public string CodPart { get; set; }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            [SpedCampos(19, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// Valor do COFINS
            /// </summary>
            [SpedCampos(20, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Código da conta analíica contábil debitada/creditada
            /// </summary>
            [SpedCampos(21, "COD_CTA", "C", 99, 0, false)]
            public string CodCta { get; set; }
        }

        /// <summary>
        /// REGISTRO C590: REGISTRO ANALÍTICO DO DOCUMENTO - NOTA FISCAL/CONTA
        /// DE ENERGIA ELÉTRICA (CÓDIGO 06), NOTA FISCAL/CONTA DE FORNECIMENTO
        /// D'ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL CONSUMO FORNECIMENTO DE
        /// GÁS (CÓDIGO 28)
        /// </summary>
        public class RegistroC590 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC590"/>.
            /// </summary>
            public RegistroC590()
            {
                Reg = "C590";
            }

            /// <summary>
            /// Código da situação tributária
            /// </summary>
            [SpedCampos(2, "CST_ICMS", "N", 3, 0, true)]
            public int CstIcms { get; set; }

            /// <summary>
            /// Código fiscal de operação e prestaçaõ do agrupamento de itens
            /// </summary>
            [SpedCampos(3, "CFOP", "N", 4, 0, true)]
            public int Cfop { get; set; }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            [SpedCampos(4, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }

            /// <summary>
            /// Valor da operação correspondete à combinação de
            /// CST_ICMS, CFOP e alíquota do ICMS
            /// </summary>
            [SpedCampos(5, "VL_OPR", "N", 0, 2, true)]
            public decimal VlOpr { get; set; }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo
            /// do ICMS" referente à combinação de CST_ICMS, CFOP e
            /// alíquota do ICMS
            /// </summary>
            [SpedCampos(6, "VL_BC_ICMS", "N", 0, 2, true)]
            public decimal VlBcIcms { get; set; }

            /// <summary>
            /// Parcela corresponde ao "Valor do ICMS" referente à
            /// combinação de CST_ICMS, CFOP e alíquoa do ICMS
            /// </summary>
            [SpedCampos(7, "VL_ICMS", "N", 0, 2, true)]
            public decimal VlIcms { get; set; }

            /// <summary>
            /// Parcela corresponde ao "Valor da base de cálculo do 
            /// ICMS" da substituição tributária referente à combinação
            /// de CST_ICMS, CFOP alíquota do ICMS.
            /// </summary>
            [SpedCampos(8, "VL_BC_ICMS_ST", "N", 0, 2, true)]
            public decimal VlBcIcmsSt { get; set; }

            /// <summary>
            /// Parcela corresponde ao valor creditado/debitado do ICMS
            /// da substituição tributária, referente à combinação de CST_ICMS,
            /// CFOP e alíquota do ICMS
            /// </summary>
            [SpedCampos(9, "VL_ICMS_ST", "N", 0, 2, true)]
            public decimal VlIcmsSt { get; set; }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do
            /// ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS
            /// </summary>
            [SpedCampos(10, "VL_RED_BC", "N", 0, 2, true)]
            public decimal VlRedBc { get; set; }

            /// <summary>
            /// Código da observação do lançamento fiscal
            /// </summary>
            [SpedCampos(11, "COD_OBS", "C", 6, 0, false)]
            public string CodObs { get; set; }
        }

        /// <summary>
        /// REGISTRO C990: ENCERRAMENTO DO BLOCO C
        /// </summary>
        public class RegistroC990 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroC990"/>.
            /// </summary>
            public RegistroC990()
            {
                Reg = "C990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco C
            /// </summary>
            [SpedCampos(3, "QTD_LIN_C", "N", 0, 0, true)]
            public int QtdLinC { get; set; }
        }
    }
}

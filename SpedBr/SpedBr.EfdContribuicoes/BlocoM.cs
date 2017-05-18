using System;
using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoM
    {
        public class RegistroM001 : RegistroBaseSped
        {
            public RegistroM001()
            {
                Reg = "M001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        ///     REGISTRO M100: CRÉDITO DE PIS/PASEP RELATIVO AO PERIODO
        /// </summary>
        public class RegistroM100 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroM100"/>
            /// </summary>
            public RegistroM100()
            {
                Reg = "M100";
            }

            /// <summary>
            ///     Código de Tipo de C´redito apurado no período, conforme a Tabela 4.3.6
            /// </summary>
            [SpedCampos(2, "COD_CRED", "C", 3, 0, true)]
            public string CodCred { get; set; }

            /// <summary>
            ///     Indicador de Crédito Oriundo de:
            ///     0- Operações próprias
            ///     1- Evento de incorporação, cisão ou fusão
            /// </summary>
            [SpedCampos(3, "IND_CRED_ORI", "N", 1, 0, true)]
            public int IndCredOri { get; set; }

            /// <summary>
            ///     Valor da base de Cálculo do Crédito
            /// </summary>
            [SpedCampos(4, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal? VlBcPis { get; set; }

            /// <summary>
            ///     Alíquota do PIS/PASEP (em percentual)
            /// </summary>
            [SpedCampos(5, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal? AliqPis { get; set; }

            /// <summary>
            ///     Quantidade - Base de cálculo do PIS
            /// </summary>
            [SpedCampos(6, "QUANT_BC_PIS", "N", 0, 3, false)]
            public decimal? QuantBcPis { get; set; }

            /// <summary>
            ///     Alíquota do PIS (em reais)
            /// </summary>
            [SpedCampos(7, "ALI_PIS_QUANT", "N", 0, 4, false)]
            public decimal? AliqPisQuant { get; set; }

            /// <summary>
            ///     Valor total do crédito apurado no período
            /// </summary>
            [SpedCampos(8, "VL_CRED", "N", 0, 2, true)]
            public decimal VlCred { get; set; }

            /// <summary>
            ///     Valor total dos ajustes de acréscimo
            /// </summary>
            [SpedCampos(9, "VL_AJUS_ACRES", "N", 0, 2, true)]
            public decimal VlAjusAcres { get; set; }

            /// <summary>
            ///     Valor total dos ajustes de redução
            /// </summary>
            [SpedCampos(10, "VL_AJUS_REDUC", "N", 0, 2, true)]
            public decimal VlAjusReduc { get; set; }

            /// <summary>
            ///     Valor total do crédito diferido no período
            /// </summary>
            [SpedCampos(11, "VL_CRED_DIF", "N", 0, 2, true)]
            public decimal VlCredDif { get; set; }

            /// <summary>
            ///     Valor Total do Crédito Disponível relativo ao Período (08 + 09 – 10 – 11)
            /// </summary>
            [SpedCampos(12, "VL_CRED_DISP", "N", 0, 2, true)]
            public decimal VlCredDisp { get; set; }

            /// <summary>
            ///     Indicador de opção de utilização do crédito disponível no período: 
            ///     0 – Utilização do valor total para desconto da 
            ///     contribuição apurada no período, no Registro M200; 
            ///     1 – Utilização de valor parcial para desconto da 
            ///     contribuição apurada no período, no Registro M200. 
            /// </summary>
            [SpedCampos(13, "IND_DESC_CRED", "C", 1, 0, true)]
            public int IndDescCred { get; set; }

            /// <summary>
            ///     Valor do Crédito disponível, descontado  da contribuição
            ///     apurada no próprio período.
            ///     Se IND_DESC_CRED=0, informar o valor total do Campo 12;
            ///     Se IND_DESC_CRED=1, informar o valor parcial do Campo 12
            /// </summary>
            [SpedCampos(14, "VL_CRED_DESC", "N", 0, 2, false)]
            public decimal? VlCredDesc { get; set; }

            /// <summary>
            ///     Saldo de créditos a utilizar em períodos futuros (12 – 14)
            /// </summary>
            [SpedCampos(15, "VL_CRED_DESC", "N", 0, 2, true)]
            public decimal SldCred { get; set; }
        }

        /// <summary>
        ///     REGISTRO M105: DETALHAMENTO DA BASE DE CALCULO DO CRÉDITO APURADO NO PERÍODO – PIS/PASEP
        /// </summary>
        public class RegistroM105 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroM105"/>.
            /// </summary>
            public RegistroM105()
            {
                Reg = "M105";
            }

            /// <summary>
            ///     Código da Base de Cálculo do Crédito apurado no período, conforme a Tabela 4.3.7. 
            /// </summary>
            [SpedCampos(2, "NAT_BC_CRED", "C", 2, 0, true)]
            public string NatBcCred { get; set; }

            /// <summary>
            ///     Código da Situação Tributária referente ao crédito de PIS/Pasep (Tabela 4.3.3) 
            ///     vinculado ao tipo de crédito escriturado em M100
            /// </summary>
            [SpedCampos(3, "CST_PIS", "N", 2, 0, true)]
            public int CstPis { get; set; }

            /// <summary>
            ///     Valor Total da Base de Cálculo escriturada nos documentos e operações (Blocos "A", "C", "D", e "F"), 
            ///     referente ao CST_PIS informado no Campo 03.
            /// </summary>
            [SpedCampos(4, "VL_BC_PIS_TOT", "N", 0, 2, false)]
            public decimal? VlBcPisTot { get; set; }

            /// <summary>
            ///     Parcela do Valor Total da Base de Cálculo informada no Campo 04, 
            ///     vinculada a receitas com incidência cumulativa. 
            ///     Campo de preenchimento específico para a pessoa jurídica sujeita 
            ///     ao regime cumulativo e não-cumulativo da contribuição 
            ///     (COD_INC_TRIB = 3 do Registro 0110) 
            /// </summary>
            [SpedCampos(5, "VL_BC_PIS_CUM", "N", 0, 2, false)]
            public decimal? VlBcPisCum { get; set; }

            /// <summary>
            ///     Valor Total da Base de Cálculo do Crédito, 
            ///     vinculada a receitas com incidência não-cumulativa (Campo 04 – Campo 05)
            /// </summary>
            [SpedCampos(6, "VL_BC_PIS_NC", "N", 0, 2, false)]
            public decimal? VlBcPisNc { get; set; }

            /// <summary>
            ///     Valor da Base de Cálculo do Crédito, vinculada ao tipo de Crédito escriturado em M100. 
            ///     - Para os CST_PIS = "50", "51", "52", "60", "61" e "62": Informar o valor do Campo 06 (VL_BC_PIS_NC); 
            ///     - Para os CST_PIS = "53", "54", "55", "56", "63", "64" "65" e "66" 
            ///       (Crédito sobre operações vinculadas a mais de um tipo de receita): 
            ///       Informar a parcela do valor do Campo 06 (VL_BC_PIS_NC) vinculada especificamente ao tipo 
            ///       de crédito escriturado em M100. 
            ///
            ///       O valor deste campo será transportado para o Campo 04 (VL_BC_PIS) do registro M100.
            /// </summary>
            [SpedCampos(7, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal? VlBcPis { get; set; }

            /// <summary>
            ///     Quantidade Total da Base de Cálculo do Crédito apurado em Unidade de Medida de Produto, 
            ///     escriturada nos documentos e operações (Blocos "A", "C", "D" e "F"), 
            ///     referente ao CST_PIS informado no Campo 03 
            /// </summary>
            [SpedCampos(8, "QUANT_BC_PIS_TOT", "N", 0, 3, false)]
            public decimal? QuantBcPisTot { get; set; }

            /// <summary>
            ///     Parcela da base de cálculo do crédito em quantidade (campo 08) 
            ///     vinculada ao tipo de crédito escriturado em M100. 
            ///     - Para os CST_PIS = "50", “51" e "52": Informar o valor do Campo 08 (QUANT_BC_PIS); 
            ///     - Para os CST_PIS = "53", “54", "55" e "56" (crédito vinculado a mais de um tipo de receita): 
            ///     Informar a parcela do valor do Campo 08 (QUANT_BC_PIS) vinculada 
            ///     ao tipo de crédito escriturado em M100. 
            ///
            ///O valor deste campo será transportado para o Campo 06 (QUANT_BC_PIS) do registro M100.
            /// </summary>
            [SpedCampos(9, "QUANT_BC_PIS", "N", 0, 3, false)]
            public decimal? QuantBcPis { get; set; }

            /// <summary>
            ///     Descrição do crédito
            /// </summary>
            [SpedCampos(10, "DESC_CRED", "C", 60, 0, false)]
            public string DescCred { get; set; }
        }

        public class RegistroM200 : RegistroBaseSped
        {
            public RegistroM200()
            {
                Reg = "M200";
            }

            [SpedCampos(2, "VL_TOT_CONT_NC_PER", "N", 0, 2, true)]
            public decimal VlTotContNcPer { get; set; }

            [SpedCampos(3, "VL_TOT_CRED_DESC", "N", 0, 2, true)]
            public decimal VlTotCredDesc { get; set; }

            [SpedCampos(4, "VL_TOT_CRED_DESC_ANT", "N", 0, 2, true)]
            public decimal VlTotCredDescAnt { get; set; }

            [SpedCampos(5, "VL_TOT_CONT_NC_DEV", "N", 0, 2, true)]
            public decimal VlTotContNcDev { get; set; }

            [SpedCampos(6, "VL_RET_NC", "N", 0, 2, true)]
            public decimal VlRetNc { get; set; }

            [SpedCampos(7, "VL_OUT_DED_NC", "N", 0, 2, true)]
            public decimal VlOutDedNc { get; set; }

            [SpedCampos(8, "VL_CONT_NC_REC", "N", 0, 2, true)]
            public decimal VlContNcRec { get; set; }

            [SpedCampos(9, "VL_TOT_CONT_CUM_PER", "N", 0, 2, true)]
            public decimal VlTotContCumPer { get; set; }

            [SpedCampos(10, "VL_RET_CUM", "N", 0, 2, true)]
            public decimal VlRetCum { get; set; }

            [SpedCampos(11, "VL_OUT_DED_CUM", "N", 0, 2, true)]
            public decimal VlOutDedCum { get; set; }

            [SpedCampos(12, "VL_CONT_CUM_REC", "N", 0, 2, true)]
            public decimal VlContCumRec { get; set; }

            [SpedCampos(13, "VL_TOT_CONT_REC", "N", 0, 2, true)]
            public decimal VlTotContRec { get; set; }
        }

        public class RegistroM205 : RegistroBaseSped
        {
            public RegistroM205()
            {
                Reg = "M205";
            }

            [SpedCampos(2, "NUM_CAMPO", "C", 2, 0, true)]
            public int NumCampo { get; set; }

            [SpedCampos(3, "COD_REC", "C", 6, 0, true)]
            public int CodRec { get; set; }

            [SpedCampos(4, "VL_DEBITO", "N", 0, 2, true)]
            public decimal VlDebito { get; set; }
        }

        public class RegistroM210 : RegistroBaseSped
        {
            public RegistroM210()
            {
                Reg = "M210";
            }

            [SpedCampos(2, "COD_CONT", "C", 2, 0, true)]
            public int CodCont { get; set; }

            [SpedCampos(3, "VL_REC_BRT", "N", 0, 2, true)]
            public decimal VlRecBrt { get; set; }

            [SpedCampos(4, "VL_BC_CONT", "N", 0, 2, true)]
            public decimal VlBcCont { get; set; }

            [SpedCampos(5, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal? AliqPis { get; set; }

            [SpedCampos(6, "QUANT_BC_PIS", "N", 0, 3, false)]
            public decimal? QuantBcPis { get; set; }

            [SpedCampos(7, "ALIQ_PIS_QUANT", "N", 0, 4, false)]
            public decimal? AliqPisQuant { get; set; }

            [SpedCampos(8, "VL_CONT_APUR", "N", 0, 2, true)]
            public decimal VlContApur { get; set; }

            [SpedCampos(9, "VL_AJUS_ACRES", "N", 0, 2, true)]
            public decimal VlAjusAcres { get; set; }

            [SpedCampos(10, "VL_AJUS_REDUC", "N", 0, 2, true)]
            public decimal VlAjusReduc { get; set; }

            [SpedCampos(11, "VL_CONT_DIFER", "N", 0, 2, false)]
            public decimal? VlContDifer { get; set; }

            [SpedCampos(12, "VL_CONT_DIFER_ANT", "N", 0, 2, false)]
            public decimal? VlContDiferAnt { get; set; }

            [SpedCampos(13, "VL_CONT_PER", "N", 0, 2, true)]
            public decimal VlContPer { get; set; }
        }

        public class RegistroM220 : RegistroBaseSped
        {
            public RegistroM220()
            {
                Reg = "M220";
            }

            [SpedCampos(2, "IND_AJ", "C", 1, 0, true)]
            public int IndAj { get; set; }

            [SpedCampos(3, "VL_AJ", "N", 0, 2, true)]
            public decimal VlAj { get; set; }

            [SpedCampos(4, "COD_AJ", "C", 2, 0, true)]
            public int CodAj { get; set; }

            [SpedCampos(5, "NUM_DOC", "C", 0, 0, false)]
            public string NumDoc { get; set; }

            [SpedCampos(6, "DESCR_AJ", "C", 0, 0, false)]
            public string DescrAj { get; set; }

            [SpedCampos(7, "DT_REF", "N", 8, 0, false)]
            public DateTime? DtRef { get; set; }
        }

        [SpedRegistros("01/10/2015", null)]
        public class RegistroM225 : RegistroBaseSped
        {
            public RegistroM225()
            {
                Reg = "M225";
            }

            [SpedCampos(2, "DET_VALOR_AJ", "N", 0, 2, true)]
            public decimal DetValorAj { get; set; }

            [SpedCampos(3, "CST_PIS", "N", 2, 0, false)]
            public int CstPis { get; set; }

            [SpedCampos(4, "DET_BC_CRED", "N", 0, 3, false)]
            public decimal? DetBcCred { get; set; }

            [SpedCampos(5, "DET_ALIQ", "N", 8, 4, false)]
            public decimal? DetAliq { get; set; }

            [SpedCampos(6, "DT_OPER_AJ", "N", 8, 0, true)]
            public DateTime DtOperAj { get; set; }

            [SpedCampos(7, "DESC_AJ", "C", 0, 0, false)]
            public string DescAj { get; set; }

            [SpedCampos(8, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            [SpedCampos(9, "INFO_COMPL", "C", 0, 0, false)]
            public string InfoCompl { get; set; }
        }

        /// <summary>
        ///     REGISTRO M400: RECEITAS ISENTAS, NÃO ALCANÇADAS PELA INCIDÊNCIA DA
        ///     CONTRIBUIÇÃO, SUJEITAS A ALÍQUOTA ZERO OU DE VENDAS COM SUSPENSÃO - PIS/PASEP
        /// </summary>
        public class RegistroM400:RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classse <see cref="RegistroM400"/>
            /// </summary>
            public RegistroM400()
            {
                Reg = "M400";
            }

            /// <summary>
            ///     Código de Situação Tributária – CST das demais receitas 
            ///     auferidas no período, sem incidência da contribuição, ou 
            ///     sem contribuição apurada a pagar, conforme a Tabela 4.3.3.
            /// </summary>
            [SpedCampos(2, "CST_PIS", "C", 2, 0, true)]
            public int CstPis { get; set; }

            /// <summary>
            ///     Valor total da receita bruta no período. 
            /// </summary>
            [SpedCampos(3, "VL_TOT_REC", "N", 0, 2, true)]
            public decimal VlTotRec { get; set; }

            /// <summary>
            ///     Código da conta analítica contábil debitada/creditada.
            /// </summary>
            [SpedCampos(4, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            /// <summary>
            ///     Descrição Complementar da Natureza da Receita.
            /// </summary>
            [SpedCampos(4, "DESC_COMPL", "C",int.MaxValue, 0, false)]
            public string DescCompl { get; set; }
        }

        /// <summary>
        ///     REGISTRO M410: DETALHAMENTO DAS RECEITAS ISENTAS, NÃO ALCANÇADAS PELA 
        ///     INCIDÊNCIA DA CONTRIBUIÇÃO, SUJEITAS A ALÍQUOTA ZERO OU DE VENDAS COM
        ///     SUSPENSÃO – PIS/PASEP 
        /// </summary>
        public class RegistroM410 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroM410"/>
            /// </summary>
            public RegistroM410()
            {
                Reg = "M410";
            }

            /// <summary>
            ///     Natureza da Receita, conforme relação constante nas 
            ///     Tabelas de Detalhamento da Natureza da Receita por 
            ///     Situação Tributária abaixo: 
            ///     
            ///     - Tabela 4.3.10: Produtos Sujeitos à Incidência
            ///     Monofásica da Contribuição Social – Alíquotas 
            ///     Diferenciadas(CST 04 - Revenda); 
            ///     
            ///     - Tabela 4.3.11: Produtos Sujeitos à Incidência 
            ///     Monofásica da Contribuição Social – Alíquotas por 
            ///     Unidade de Medida de Produto(CST 04 - Revenda); 
            ///     
            ///     - Tabela 4.3.12: Produtos Sujeitos à Substituição 
            ///     Tributária da Contribuição Social(CST 05 - Revenda); 
            ///     
            ///     - Tabela 4.3.13: Produtos Sujeitos à Alíquota Zero da 
            ///     Contribuição Social(CST 06); 
            ///     
            ///     - Tabela 4.3.14: Operações com Isenção da Contribuição 
            ///     Social(CST 07); 
            ///     
            ///     - Tabela 4.3.15: Operações sem Incidência da
            ///     Contribuição Social(CST 08);
            ///     
            ///     - Tabela 4.3.16: Operações com Suspensão da 
            ///     Contribuição Social (CST 09). 
            /// </summary>
            [SpedCampos(2, "NAT_REC", "C", 3, 0, true)]
            public string NatRec { get; set; }

            /// <summary>
            ///     Valor da receita bruta no período, relativo a natureza da receita (NAT_REC)
            /// </summary>
            [SpedCampos(3, "VL_REC", "N", 0, 2, true)]
            public decimal VlRec { get; set; }

            /// <summary>
            ///     Código da conta analítica contábil debitada/creditada.
            /// </summary>
            [SpedCampos(4, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            /// <summary>
            ///     Descrição Complementar da Natureza da Receita.
            /// </summary>
            [SpedCampos(5, "DESC_COMPL", "C", int.MaxValue, 0, false)]
            public string DescCompl { get; set; }
        }

        public class RegistroM600 : RegistroBaseSped
        {
            public RegistroM600()
            {
                Reg = "M600";
            }

            [SpedCampos(2, "VL_TOT_CONT_NC_PER", "N", 0, 2, true)]
            public decimal VlTotContNcPer { get; set; }

            [SpedCampos(3, "VL_TOT_CRED_DESC", "N", 0, 2, true)]
            public decimal VlTotCredDesc { get; set; }

            [SpedCampos(4, "VL_TOT_CRED_DESC_ANT", "N", 0, 2, true)]
            public decimal VlTotCredDescAnt { get; set; }

            [SpedCampos(5, "VL_TOT_CONT_NC_DEV", "N", 0, 2, true)]
            public decimal VlTotContNcDev { get; set; }

            [SpedCampos(6, "VL_RET_NC", "N", 0, 2, true)]
            public decimal VlRetNc { get; set; }

            [SpedCampos(7, "VL_OUT_DED_NC", "N", 0, 2, true)]
            public decimal VlOutDedNc { get; set; }

            [SpedCampos(8, "VL_CONT_NC_REC", "N", 0, 2, true)]
            public decimal VlContNcRec { get; set; }

            [SpedCampos(9, "VL_TOT_CONT_CUM_PER", "N", 0, 2, true)]
            public decimal VlTotContCumPer { get; set; }

            [SpedCampos(10, "VL_RET_CUM", "N", 0, 2, true)]
            public decimal VlRetCum { get; set; }

            [SpedCampos(11, "VL_OUT_DED_CUM", "N", 0, 2, true)]
            public decimal VlOutDedCum { get; set; }

            [SpedCampos(12, "VL_CONT_CUM_REC", "N", 0, 2, true)]
            public decimal VlContCumRec { get; set; }

            [SpedCampos(13, "VL_TOT_CONT_REC", "N", 0, 2, true)]
            public decimal VlTotContRec { get; set; }
        }

        public class RegistroM605 : RegistroBaseSped
        {
            public RegistroM605()
            {
                Reg = "M605";
            }

            [SpedCampos(2, "NUM_CAMPO", "C", 2, 0, true)]
            public int NumCampo { get; set; }

            [SpedCampos(3, "COD_REC", "C", 6, 0, true)]
            public int CodRec { get; set; }

            [SpedCampos(4, "VL_DEBITO", "N", 0, 2, true)]
            public decimal VlDebito { get; set; }
        }

        public class RegistroM610 : RegistroBaseSped
        {
            public RegistroM610()
            {
                Reg = "M610";
            }

            [SpedCampos(2, "COD_CONT", "C", 2, 0, true)]
            public int CodCont { get; set; }

            [SpedCampos(3, "VL_REC_BRT", "N", 0, 2, true)]
            public decimal VlRecBrt { get; set; }

            [SpedCampos(4, "VL_BC_CONT", "N", 0, 2, true)]
            public decimal VlBcCont { get; set; }

            [SpedCampos(5, "ALIQ_COFINS", "N", 8, 4, false)]
            public decimal? AliqCofins { get; set; }

            [SpedCampos(6, "QUANT_BC_COFINS", "N", 0, 3, false)]
            public decimal? QuantBcCofins { get; set; }

            [SpedCampos(7, "ALIQ_COFINS_QUANT", "N", 0, 4, false)]
            public decimal? AliqCofinsQuant { get; set; }

            [SpedCampos(8, "VL_CONT_APUR", "N", 0, 2, true)]
            public decimal VlContApur { get; set; }

            [SpedCampos(9, "VL_AJUS_ACRES", "N", 0, 2, true)]
            public decimal VlAjusAcres { get; set; }

            [SpedCampos(10, "VL_AJUS_REDUC", "N", 0, 2, true)]
            public decimal VlAjusReduc { get; set; }

            [SpedCampos(11, "VL_CONT_DIFER", "N", 0, 2, false)]
            public decimal? VlContDifer { get; set; }

            [SpedCampos(12, "VL_CONT_DIFER_ANT", "N", 0, 2, false)]
            public decimal? VlContDiferAnt { get; set; }

            [SpedCampos(13, "VL_CONT_PER", "N", 0, 2, true)]
            public decimal VlContPer { get; set; }
        }

        public class RegistroM620 : RegistroBaseSped
        {
            public RegistroM620()
            {
                Reg = "M620";
            }

            [SpedCampos(2, "IND_AJ", "C", 1, 0, true)]
            public int IndAj { get; set; }

            [SpedCampos(3, "VL_AJ", "N", 0, 2, true)]
            public decimal VlAj { get; set; }

            [SpedCampos(4, "COD_AJ", "C", 2, 0, true)]
            public int CodAj { get; set; }

            [SpedCampos(5, "NUM_DOC", "C", 0, 0, false)]
            public string NumDoc { get; set; }

            [SpedCampos(6, "DESCR_AJ", "C", 0, 0, false)]
            public string DescrAj { get; set; }

            [SpedCampos(7, "DT_REF", "N", 8, 0, false)]
            public DateTime? DtRef { get; set; }
        }

        [SpedRegistros("01/10/2015", null)]
        public class RegistroM625 : RegistroBaseSped
        {
            public RegistroM625()
            {
                Reg = "M625";
            }

            [SpedCampos(2, "DET_VALOR_AJ", "N", 0, 2, true)]
            public decimal DetValorAj { get; set; }

            [SpedCampos(3, "CST_COFINS", "N", 2, 0, false)]
            public int CstCofins { get; set; }

            [SpedCampos(4, "DET_BC_CRED", "N", 0, 3, false)]
            public decimal? DetBcCred { get; set; }

            [SpedCampos(5, "DET_ALIQ", "N", 8, 4, false)]
            public decimal? DetAliq { get; set; }

            [SpedCampos(6, "DT_OPER_AJ", "N", 8, 0, true)]
            public DateTime DtOperAj { get; set; }

            [SpedCampos(7, "DESC_AJ", "C", 0, 0, false)]
            public string DescAj { get; set; }

            [SpedCampos(8, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            [SpedCampos(9, "INFO_COMPL", "C", 0, 0, false)]
            public string InfoCompl { get; set; }
        }

        /// <summary>
        ///     REGISTRO M800: RECEITAS ISENTAS, NÃO ALCANÇADAS PELA INCIDÊNCIA DA 
        ///     CONTRIBUIÇÃO, SUJEITAS A ALÍQUOTA ZERO OU DE VENDAS COM SUSPENSÃO – COFINS 
        /// </summary>
        public class RegistroM800 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classse <see cref="RegistroM800"/>
            /// </summary>
            public RegistroM800()
            {
                Reg = "M800";
            }

            /// <summary>
            ///     Código de Situação Tributária – CST das demais receitas 
            ///     auferidas no período, sem incidência da contribuição, ou 
            ///     sem contribuição apurada a pagar, conforme a Tabela 4.3.3.
            /// </summary>
            [SpedCampos(2, "CST_COFINS", "C", 2, 0, true)]
            public int CstCofins { get; set; }

            /// <summary>
            ///     Valor total da receita bruta no período. 
            /// </summary>
            [SpedCampos(3, "VL_TOT_REC", "N", 0, 2, true)]
            public decimal VlTotRec { get; set; }

            /// <summary>
            ///     Código da conta analítica contábil debitada/creditada.
            /// </summary>
            [SpedCampos(4, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            /// <summary>
            ///     Descrição Complementar da Natureza da Receita.
            /// </summary>
            [SpedCampos(4, "DESC_COMPL", "C", int.MaxValue, 0, false)]
            public string DescCompl { get; set; }
        }

        /// <summary>
        ///     REGISTRO M810: DETALHAMENTO DAS RECEITAS ISENTAS, NÃO ALCANÇADAS PELA 
        ///     INCIDÊNCIA DA CONTRIBUIÇÃO, SUJEITAS A ALÍQUOTA ZERO OU DE VENDAS COM
        ///     SUSPENSÃO – cofins
        /// </summary>
        public class RegistroM810 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroM810"/>
            /// </summary>
            public RegistroM810()
            {
                Reg = "M810";
            }

            /// <summary>
            ///     Natureza da Receita, conforme relação constante nas 
            ///     Tabelas de Detalhamento da Natureza da Receita por 
            ///     Situação Tributária abaixo: 
            ///     
            ///     - Tabela 4.3.10: Produtos Sujeitos à Incidência
            ///     Monofásica da Contribuição Social – Alíquotas 
            ///     Diferenciadas(CST 04 - Revenda); 
            ///     
            ///     - Tabela 4.3.11: Produtos Sujeitos à Incidência 
            ///     Monofásica da Contribuição Social – Alíquotas por 
            ///     Unidade de Medida de Produto(CST 04 - Revenda); 
            ///     
            ///     - Tabela 4.3.12: Produtos Sujeitos à Substituição 
            ///     Tributária da Contribuição Social(CST 05 - Revenda); 
            ///     
            ///     - Tabela 4.3.13: Produtos Sujeitos à Alíquota Zero da 
            ///     Contribuição Social(CST 06); 
            ///     
            ///     - Tabela 4.3.14: Operações com Isenção da Contribuição 
            ///     Social(CST 07); 
            ///     
            ///     - Tabela 4.3.15: Operações sem Incidência da
            ///     Contribuição Social(CST 08);
            ///     
            ///     - Tabela 4.3.16: Operações com Suspensão da 
            ///     Contribuição Social (CST 09). 
            /// </summary>
            [SpedCampos(2, "NAT_REC", "C", 3, 0, true)]
            public string NatRec { get; set; }

            /// <summary>
            ///     Valor da receita bruta no período, relativo a natureza da receita (NAT_REC)
            /// </summary>
            [SpedCampos(3, "VL_REC", "N", 0, 2, true)]
            public decimal VlRec { get; set; }

            /// <summary>
            ///     Código da conta analítica contábil debitada/creditada.
            /// </summary>
            [SpedCampos(4, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            /// <summary>
            ///     Descrição Complementar da Natureza da Receita.
            /// </summary>
            [SpedCampos(5, "DESC_COMPL", "C", int.MaxValue, 0, false)]
            public string DescCompl { get; set; }
        }

        public class RegistroM990 : RegistroBaseSped
        {
            public RegistroM990()
            {
                Reg = "M990";
            }

            [SpedCampos(2, "QTD_LIN_M", "N", 0, 0, true)]
            public int QtdLinM { get; set; }
        }
    }
}
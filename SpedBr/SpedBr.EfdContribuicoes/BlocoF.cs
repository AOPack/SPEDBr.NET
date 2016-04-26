using System;
using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoF
    {
        public class EfdContribRegF001 : RegistroBaseSped
        {
            public EfdContribRegF001()
            {
                REG = "F001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        /// Identificação do Estabelecimento
        /// </summary>
        public class EfdContribRegF010 : RegistroBaseSped
        {
            public EfdContribRegF010()
            {
                REG = "F010";
            }

            [SpedCampos(2, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }
        }

        /// <summary>
        /// OPERAÇÕES DA ATIVIDADE IMOBILIÁRIA - UNIDADE IMOBILIÁRIA VENDIDA
        /// </summary>
        public class EfdContribRegF200 : RegistroBaseSped
        {
            public EfdContribRegF200()
            {
                REG = "F200";
            }

            [SpedCampos(2, "IND_OPER", "N", 2, 0, true)]
            public int IndOper { get; set; }

            [SpedCampos(3, "UNID_IMOB", "N", 2, 0, true)]
            public int UnidImob { get; set; }

            [SpedCampos(4, "IDENT_EMP", "C", 0, 0, true)]
            public string IdentEmp { get; set; }

            [SpedCampos(5, "DESC_UNID_IMOB", "C", 90, 0, false)]
            public string DescUnidImob { get; set; }

            [SpedCampos(6, "NUM_CONT", "C", 90, 0, false)]
            public string NumCont { get; set; }

            [SpedCampos(7, "CPF_CNPJ_ADQU", "C", 14, 0, true)]
            public string CpfCnpjAdqu { get; set; }

            [SpedCampos(8, "DT_OPER", "N", 8, 0, true)]
            public DateTime DtOper { get; set; }

            [SpedCampos(9, "VL_TOT_VEND", "N", 0, 2, true)]
            public decimal VlTotVend { get; set; }

            [SpedCampos(10, "VL_REC_ACUM", "N", 0, 2, false)]
            public decimal VlRecAcum { get; set; }

            [SpedCampos(11, "VL_TOT_REC", "N", 0, 2, true)]
            public decimal VlTotRec { get; set; }

            [SpedCampos(12, "CST_PIS", "N", 2, 0, true)]
            public int CstPis { get; set; }

            [SpedCampos(13, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal VlBcPis { get; set; }

            [SpedCampos(14, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal AliqPis { get; set; }

            [SpedCampos(15, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(16, "CST_COFINS", "N", 2, 0, true)]
            public int CstCofins { get; set; }

            [SpedCampos(17, "VL_BC_COFINS", "N", 0, 2, false)]
            public decimal VlBcCofins { get; set; }

            [SpedCampos(18, "ALIQ_COFINS", "N", 8, 4, false)]
            public decimal AliqCofins { get; set; }

            [SpedCampos(19, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(20, "PERC_REC_RECEB", "N", 6, 2, false)]
            public decimal PercRecReceb { get; set; }

            [SpedCampos(21, "IND_NAT_EMP", "N", 1, 0, false)]
            public int IndNatEmp { get; set; }

            [SpedCampos(22, "INF_COMP", "C", 90, 0, false)]
            public string InfComp { get; set; }
        }

        /// <summary>
        /// CONSOLIDAÇÃO DAS OPERAÇÕES DA PESSOA JURÍDICA SUBMETIDA AO REGIME DE TRIBUTAÇÃO COM BASE NO LUCRO PRESUMIDO  – INCIDÊNCIA DO PIS/PASEP E DA COFINS PELO REGIME DE CAIXA
        /// </summary>
        public class EfdContribRegF500 : RegistroBaseSped
        {
            public EfdContribRegF500()
            {
                REG = "F500";
            }

            [SpedCampos(2, "VL_REC_CAIXA", "N", 0, 2, true)]
            public decimal VlRecCaixa { get; set; }

            [SpedCampos(3, "CST_PIS", "N", 2, 0, true)]
            public int CstPis { get; set; }

            [SpedCampos(4, "VL_DESC_PIS", "N", 0, 2, false)]
            public decimal VlDescPis { get; set; }

            [SpedCampos(5, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal VlBcPis { get; set; }

            [SpedCampos(6, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal AliqPis { get; set; }

            [SpedCampos(7, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(8, "CST_COFINS", "N", 2, 0, true)]
            public int CstCofins { get; set; }

            [SpedCampos(9, "VL_DESC_COFINS", "N", 0, 2, false)]
            public decimal VlDescCofins { get; set; }

            [SpedCampos(10, "VL_BC_COFINS", "N", 0, 2, false)]
            public decimal VlBcCofins { get; set; }

            [SpedCampos(11, "ALIQ_COFINS", "N", 8, 4, false)]
            public decimal AliqCofins { get; set; }

            [SpedCampos(12, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(13, "COD_MOD", "C", 2, 0, false)]
            public int? CodMod { get; set; }

            [SpedCampos(14, "CFOP", "N", 4, 0, false)]
            public string Cfop { get; set; }

            [SpedCampos(15, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            [SpedCampos(16, "INFO_COMPL", "C", 0, 0, false)]
            public string InfoCompl { get; set; }
        }

        public class EfdContribRegF525 : RegistroBaseSped
        {
            public EfdContribRegF525()
            {
                REG = "F525";
            }

            [SpedCampos(2, "VL_REC", "N", 0, 2, true)]
            public decimal VlRec { get; set; }

            [SpedCampos(3, "IND_REC", "C", 2, 0, true)]
            public int IndRec { get; set; }

            [SpedCampos(4, "CNPJ_CPF", "C", 14, 0, false)]
            public string CnpjCpf { get; set; }

            [SpedCampos(5, "NUM_DOC", "C", 60, 0, false)]
            public string NumDoc { get; set; }

            [SpedCampos(6, "VL_REC,DET", "C", 60, 0, false)]
            public string CodItem { get; set; }

            [SpedCampos(7, "VL_REC_DET", "N", 0, 2, true)]
            public decimal VlRecDet { get; set; }

            [SpedCampos(8, "CST_PIS", "N", 2, 0, false)]
            public int CstPis { get; set; }

            [SpedCampos(9, "CST_COFINS", "N", 2, 0, false)]
            public int CstCofins { get; set; }

            [SpedCampos(10, "INFO_COMPL", "C", 0, 0, false)]
            public string InfoCompl { get; set; }

            [SpedCampos(11, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }
        }

        public class EfdContribRegF990 : RegistroBaseSped
        {
            public EfdContribRegF990()
            {
                REG = "F990";
            }

            [SpedCampos(2, "QTD_LIN_F", "N", 0, 0, true)]
            public int QtdLinF { get; set; }
        }
    }
}

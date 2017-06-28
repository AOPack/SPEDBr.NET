using System;
using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoF
    {
        public class RegistroF001 : RegistroBaseSped
        {
            public RegistroF001()
            {
                Reg = "F001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public IndMovimento IndMov { get; set; }
        }

        /// <summary>
        /// Identificação do Estabelecimento
        /// </summary>
        public class RegistroF010 : RegistroBaseSped
        {
            public RegistroF010()
            {
                Reg = "F010";
            }

            [SpedCampos(2, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }
        }

        /// <summary>
        /// DEMAIS DOCUMENTOS E OPERAÇÕES GERADORAS DE CONTRIBUIÇÃO E CRÉDITOS
        /// </summary>
        public class RegistroF100 : RegistroBaseSped
        {
            public RegistroF100()
            {
                Reg = "F100";
            }

            [SpedCampos(2, "IND_OPER", "N", 1, 0, true)]
            public int IndOper { get; set; }

            [SpedCampos(3, "COD_PART", "C", 60, 0, false)]
            public string CodPart { get; set; }

            [SpedCampos(4, "COD_ITEM", "C", 60, 0, false)]
            public string CodItem { get; set; }

            [SpedCampos(5, "DT_OPER", "N", 8, 0, true)]
            public DateTime DtOper { get; set; }

            [SpedCampos(6, "VL_OPER", "N", 0, 2, true)]
            public decimal VlOper { get; set; }

            [SpedCampos(7, "CST_PIS", "N", 2, 0, true)]
            public int CstPis { get; set; }

            [SpedCampos(8, "VL_BC_PIS", "N", 0, 4, false)]
            public decimal VlBcPis { get; set; }

            [SpedCampos(9, "ALIQ_PIS", "N", 8, 4, false)]
            public decimal AliqPis { get; set; }

            [SpedCampos(10, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            [SpedCampos(11, "CST_COFINS", "N", 2, 0, true)]
            public int CstCofins { get; set; }

            [SpedCampos(12, "VL_BC_COFINS", "N", 0, 4, false)]
            public decimal VlBcCofins { get; set; }

            [SpedCampos(13, "ALIQ_COFINS", "N", 8, 4, false)]
            public decimal AliqCofins { get; set; }

            [SpedCampos(14, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            [SpedCampos(15, "NAT_BC_CRED", "C", 2, 0, false)]
            public string NatBcCred { get; set; }

            [SpedCampos(16, "IND_ORIG_CRED", "C", 1, 0, false)]
            public string IndOrigCred { get; set; }

            [SpedCampos(17, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            [SpedCampos(18, "COD_CCUS", "C", 60, 0, false)]
            public string CodCcus { get; set; }

            [SpedCampos(19, "DESC_DOC_OPER", "C", int.MaxValue, 0, false)]
            public string DescDocOper { get; set; }
        }

        /// <summary>
        /// OPERAÇÕES DA ATIVIDADE IMOBILIÁRIA - UNIDADE IMOBILIÁRIA VENDIDA
        /// </summary>
        public class RegistroF200 : RegistroBaseSped
        {
            public RegistroF200()
            {
                Reg = "F200";
            }

            [SpedCampos(2, "IND_OPER", "N", 2, 0, true)]
            public int IndOper { get; set; }

            [SpedCampos(3, "UNID_IMOB", "N", 2, 0, true)]
            public int UnidImob { get; set; }

            [SpedCampos(4, "IDENT_EMP", "C", int.MaxValue, 0, true)]
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
        public class RegistroF500 : RegistroBaseSped
        {
            public RegistroF500()
            {
                Reg = "F500";
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

            [SpedCampos(16, "INFO_COMPL", "C", int.MaxValue, 0, false)]
            public string InfoCompl { get; set; }
        }

        public class RegistroF525 : RegistroBaseSped
        {
            public RegistroF525()
            {
                Reg = "F525";
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

        public class RegistroF550 : RegistroBaseSped
        {
            public RegistroF550()
            {
                Reg = "F550";
            }

            [SpedCampos(2, "VL_REC_COMP", "N", 0, 2, true)]
            public decimal VlRecComp { get; set; }

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

        /// <summary>
        /// CONTRIBUIÇÃO RETIDA NA FONTE
        /// </summary>
        public class RegistroF600 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroF600" />.
            /// </summary>
            public RegistroF600()
            {
                Reg = "F600";
            }

            /// <summary>
            /// Indicador de Natureza da Retenção na Fonte
            /// </summary>
            /// <remarks>
            /// 01 - Retenção por Órgãos, Autarquias e Fundações Federais
            /// <para />
            /// 02 - Retenção por outras Entidades da Administração Pública Federal
            /// <para />
            /// 03 - Retenção por Pessoas Jurídicas de Direito Privado
            /// <para />
            /// 04 - Recolhimento por Sociedade Cooperativa
            /// <para />
            /// 05 - Retenção por Fabricante de Máquinas e Veículos
            /// <para />
            /// 99 - Outras Retenções
            /// </remarks>
            [SpedCampos(2, "IND_NAT_RET", "N", 2, 0, true)]
            public int IndNatRet { get; set; }

            /// <summary>
            /// Data da retenção
            /// </summary>
            [SpedCampos(3, "DT_RET", "N", 8, 0, true)]
            public DateTime DtRet { get; set; }

            /// <summary>
            /// Base de cálculo da retenção ou do acolhimento (sociedade cooperativa)
            /// </summary>
            [SpedCampos(4, "VL_BC_RET", "N", 0, 4, true)]
            public decimal VlBcRet { get; set; }

            /// <summary>
            /// Valor total retido na fonte / recolhido (sociedade cooperativa)
            /// </summary>
            [SpedCampos(5, "VL_RET", "N", 0, 2, true)]
            public decimal VlRet { get; set; }

            /// <summary>
            /// Código da receita
            /// </summary>
            [SpedCampos(6, "COD_REC", "C", 4, 0, false)]
            public string CodRec { get; set; }

            /// <summary>
            /// Indicador da natureza da receita
            /// </summary>
            /// <remarks>
            /// 0 - Receita de Natureza Não Cumulativa
            /// <para />
            /// 1 - Receita de Natureza Cumulativa
            /// </remarks>
            [SpedCampos(7, "IND_NAT_REC", "N", 1, 0, false)]
            public int? IndNatRec { get; set; }

            /// <summary>
            /// CNPJ da fonte pagadora ou da PJ beneficiária
            /// </summary>
            /// <remarks>
            /// - Fonte pagadora responsável pela retenção / recolhimento (no caso de o registro ser escriturado pela pessoa jurídica beneficiária da retenção); ou
            /// <para />
            /// - Pessoa jurídica beneficiária da retenção / recolhimento (no caso de o registro ser escriturado pela pessoa jurídica responsável pela retenção).
            /// </remarks>
            [SpedCampos(8, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }

            /// <summary>
            /// Valor retido na fonte - parcela referente ao PIS/Pasep
            /// </summary>
            [SpedCampos(9, "VL_RET_PIS", "N", 0, 2, true)]
            public decimal VlRetPis { get; set; }

            /// <summary>
            /// Valor retido na fonte - parcela referente a COFINS
            /// </summary>
            [SpedCampos(10, "VL_RET_COFINS", "N", 0, 2, true)]
            public decimal VlRetCofins { get; set; }

            /// <summary>
            /// Indicador da condição da pessoa jurídica declarante
            /// </summary>
            /// <remarks>
            /// 0 - Beneficiária da retenção / recolhimento
            /// <para />
            /// 1 - Responsável pelo recolhimento
            /// </remarks>
            [SpedCampos(11, "IND_DEC", "N", 1, 0, true)]
            public int IndDec { get; set; }
        }

        public class RegistroF990 : RegistroBaseSped
        {
            public RegistroF990()
            {
                Reg = "F990";
            }

            [SpedCampos(2, "QTD_LIN_F", "N", 0, 0, true)]
            public int QtdLinF { get; set; }
        }
    }
}
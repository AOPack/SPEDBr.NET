using System;
using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoM
    {
        public class EfdContribRegM001 : RegistroBaseSped
        {
            public EfdContribRegM001()
            {
                REG = "M001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegM200 : RegistroBaseSped
        {
            public EfdContribRegM200()
            {
                REG = "M200";
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

        public class EfdContribRegM205 : RegistroBaseSped
        {
            public EfdContribRegM205()
            {
                REG = "M205";
            }

            [SpedCampos(2, "NUM_CAMPO", "C", 2, 0, true)]
            public int NumCampo { get; set; }

            [SpedCampos(3, "COD_REC", "C", 6, 0, true)]
            public int CodRec { get; set; }

            [SpedCampos(4, "VL_DEBITO", "N", 0, 2, true)]
            public decimal VlDebito { get; set; }
        }

        public class EfdContribRegM210 : RegistroBaseSped
        {
            public EfdContribRegM210()
            {
                REG = "M210";
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

        public class EfdContribRegM220 : RegistroBaseSped
        {
            public EfdContribRegM220()
            {
                REG = "M220";
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
        public class EfdContribRegM225 : RegistroBaseSped
        {
            public EfdContribRegM225()
            {
                REG = "M225";
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

        public class EfdContribRegM600 : RegistroBaseSped
        {
            public EfdContribRegM600()
            {
                REG = "M600";
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

        public class EfdContribRegM605 : RegistroBaseSped
        {
            public EfdContribRegM605()
            {
                REG = "M605";
            }

            [SpedCampos(2, "NUM_CAMPO", "C", 2, 0, true)]
            public int NumCampo { get; set; }

            [SpedCampos(3, "COD_REC", "C", 6, 0, true)]
            public int CodRec { get; set; }

            [SpedCampos(4, "VL_DEBITO", "N", 0, 2, true)]
            public decimal VlDebito { get; set; }
        }

        public class EfdContribRegM610 : RegistroBaseSped
        {
            public EfdContribRegM610()
            {
                REG = "M610";
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

        public class EfdContribRegM620 : RegistroBaseSped
        {
            public EfdContribRegM620()
            {
                REG = "M620";
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
        public class EfdContribRegM625 : RegistroBaseSped
        {
            public EfdContribRegM625()
            {
                REG = "M625";
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

        public class EfdContribRegM990 : RegistroBaseSped
        {
            public EfdContribRegM990()
            {
                REG = "M990";
            }

            [SpedCampos(2, "QTD_LIN_M", "N", 0, 0, true)]
            public int QtdLinM { get; set; }
        }
    }
}

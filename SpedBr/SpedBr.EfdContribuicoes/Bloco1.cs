using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class Bloco1
    {
        public class Registro1001 : RegistroBaseSped
        {
            public Registro1001()
            {
                Reg = "1001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public IndMovimento IndMov { get; set; }
        }

        public class Registro1900 : RegistroBaseSped
        {
            public Registro1900()
            {
                Reg = "1900";
            }

            [SpedCampos(2, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }

            [SpedCampos(3, "COD_MOD", "C", 2, 0, true)]
            public int CodMod { get; set; }

            [SpedCampos(4, "SER", "C", 4, 0, false)]
            public string Ser { get; set; }

            [SpedCampos(5, "SUB_SER", "C", 4, 0, false)]
            public string SubSer { get; set; }

            [SpedCampos(6, "COD_SIT", "N", 2, 0, false)]
            public int CodSit { get; set; }

            [SpedCampos(7, "VL_TOT_REC", "N", 0, 2, true)]
            public decimal VlTotRec { get; set; }

            [SpedCampos(8, "QUANT_DOC", "N", 2, 0, false)]
            public int QuantDoc { get; set; }

            [SpedCampos(9, "CST_PIS", "N", 2, 0, false)]
            public int CstPis { get; set; }

            [SpedCampos(10, "CST_COFINS", "N", 2, 0, false)]
            public int CstCofins { get; set; }

            [SpedCampos(11, "CFOP", "N", 4, 0, false)]
            public string Cfop { get; set; }

            [SpedCampos(12, "INF_COMPL", "C", 0, 0, false)]
            public string InfCompl { get; set; }

            [SpedCampos(13, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }
        }

        public class Registro1990 : RegistroBaseSped
        {
            public Registro1990()
            {
                Reg = "1990";
            }

            [SpedCampos(2, "QTD_LIN_1", "N", 0, 0, true)]
            public int QtdLin1 { get; set; }
        }
    }
}

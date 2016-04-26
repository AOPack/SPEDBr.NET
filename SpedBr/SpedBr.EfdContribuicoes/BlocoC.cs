using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoC
    {
        public class EfdContribRegC001 : RegistroBaseSped
        {
            public EfdContribRegC001()
            {
                REG = "C001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegC990 : RegistroBaseSped
        {
            public EfdContribRegC990()
            {
                REG = "C990";
            }

            [SpedCampos(2, "QTD_LIN_C", "N", 0, 0, true)]
            public int QtdLinC { get; set; }
        }
    }
}

using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoD
    {
        public class EfdContribRegD001 : RegistroBaseSped
        {
            public EfdContribRegD001()
            {
                REG = "D001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegD990 : RegistroBaseSped
        {
            public EfdContribRegD990()
            {
                REG = "D990";
            }

            [SpedCampos(2, "QTD_LIN_D", "N", 0, 0, true)]
            public int QtdLinD { get; set; }
        }
    }
}

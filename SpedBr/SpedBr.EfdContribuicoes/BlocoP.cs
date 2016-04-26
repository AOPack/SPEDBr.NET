using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoP
    {
        public class EfdContribRegP001 : RegistroBaseSped
        {
            public EfdContribRegP001()
            {
                REG = "P001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegP990 : RegistroBaseSped
        {
            public EfdContribRegP990()
            {
                REG = "P990";
            }

            [SpedCampos(2, "QTD_LIN_P", "N", 0, 0, true)]
            public int QtdLinP { get; set; }
        }
    }
}

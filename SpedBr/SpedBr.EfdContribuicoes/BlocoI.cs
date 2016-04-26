using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoI
    {
        public class EfdContribRegI001 : RegistroBaseSped
        {
            public EfdContribRegI001()
            {
                REG = "I001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegI990 : RegistroBaseSped
        {
            public EfdContribRegI990()
            {
                REG = "I990";
            }

            [SpedCampos(2, "QTD_LIN_I", "N", 0, 0, true)]
            public int QtdLinI { get; set; }
        }
    }
}

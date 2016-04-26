using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoA
    {
        public class EfdContribRegA001 : RegistroBaseSped
        {
            public EfdContribRegA001()
            {
                REG = "A001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class EfdContribRegA990 : RegistroBaseSped
        {
            public EfdContribRegA990()
            {
                REG = "A990";
            }

            [SpedCampos(2, "QTD_LIN_A", "N", 0, 0, true)]
            public int QtdLinA { get; set; }
        }
    }
}

using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoD
    {
        public class RegistroD001 : RegistroBaseSped
        {
            public RegistroD001()
            {
                Reg = "D001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroD990 : RegistroBaseSped
        {
            public RegistroD990()
            {
                Reg = "D990";
            }

            [SpedCampos(2, "QTD_LIN_D", "N", 0, 0, true)]
            public int QtdLinD { get; set; }
        }
    }
}

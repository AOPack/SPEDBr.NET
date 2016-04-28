using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoA
    {
        public class RegistroA001 : RegistroBaseSped
        {
            public RegistroA001()
            {
                Reg = "A001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroA990 : RegistroBaseSped
        {
            public RegistroA990()
            {
                Reg = "A990";
            }

            [SpedCampos(2, "QTD_LIN_A", "N", 0, 0, true)]
            public int QtdLinA { get; set; }
        }
    }
}

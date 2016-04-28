using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoC
    {
        public class RegistroC001 : RegistroBaseSped
        {
            public RegistroC001()
            {
                Reg = "C001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroC990 : RegistroBaseSped
        {
            public RegistroC990()
            {
                Reg = "C990";
            }

            [SpedCampos(2, "QTD_LIN_C", "N", 0, 0, true)]
            public int QtdLinC { get; set; }
        }
    }
}

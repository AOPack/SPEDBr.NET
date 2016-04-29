using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoC
    {
        public class RegistroC001 : RegistroBaseSped
        {
            public RegistroC001()
            {
                Reg = "C001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroC990 : RegistroBaseSped
        {
            public RegistroC990()
            {
                Reg = "C990";
            }

            [SpedCampos(3, "QTD_LIN_C", "N", 0, 0, true)]
            public int QtdLinC { get; set; }
        }
    }
}

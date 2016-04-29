using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoD
    {
        public class RegistroD001 : RegistroBaseSped
        {
            public RegistroD001()
            {
                Reg = "D001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroD990 : RegistroBaseSped
        {
            public RegistroD990()
            {
                Reg = "D990";
            }

            [SpedCampos(3, "QTD_LIN_D", "N", 0, 0, true)]
            public int QtdLinD { get; set; }
        }
    }
}

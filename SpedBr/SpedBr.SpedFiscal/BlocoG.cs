using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoG
    {
        public class RegistroG001 : RegistroBaseSped
        {
            public RegistroG001()
            {
                Reg = "G001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroG990 : RegistroBaseSped
        {
            public RegistroG990()
            {
                Reg = "G990";
            }

            [SpedCampos(3, "QTD_LIN_G", "N", 0, 0, true)]
            public int QtdLinG { get; set; }
        }
    }
}

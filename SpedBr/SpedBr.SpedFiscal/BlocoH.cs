using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoH
    {
        public class RegistroH001 : RegistroBaseSped
        {
            public RegistroH001()
            {
                Reg = "H001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class RegistroH990 : RegistroBaseSped
        {
            public RegistroH990()
            {
                Reg = "H990";
            }

            [SpedCampos(3, "QTD_LIN_H", "N", 0, 0, true)]
            public int QtdLinH { get; set; }
        }
    }
}

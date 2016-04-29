using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class Bloco1
    {
        public class Registro1001 : RegistroBaseSped
        {
            public Registro1001()
            {
                Reg = "1001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class Registro1010 : RegistroBaseSped
        {
            public Registro1010()
            {
                Reg = "1010";
            }

            public string IndExp { get; set; }

            public string IndCcrf { get; set; }

            public string IndComb { get; set; }

            public string IndUsina { get; set; }

            public string IndVa { get; set; }

            public string IndEe { get; set; }

            public string IndCart { get; set; }

            public string IndForm { get; set; }

            public string IndAer { get; set; }
        }

        public class Registro1990 : RegistroBaseSped
        {
            public Registro1990()
            {
                Reg = "1990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 1.
            /// </summary>
            public int QtdLin1 { get; set; }
        }
    }
}

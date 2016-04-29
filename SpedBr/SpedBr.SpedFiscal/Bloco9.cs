using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class Bloco9
    {
        public class Registro9001 : RegistroBaseSped
        {
            public Registro9001()
            {
                Reg = "9001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class Registro9900 : RegistroBaseSped
        {
            public Registro9900()
            {
                Reg = "9900";
            }

            public string RegBlc { get; set; }

            public int QtdRegBlc { get; set; }
        }

        public class Registro9990 : RegistroBaseSped
        {
            public Registro9990()
            {
                Reg = "9990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 9.
            /// </summary>
            public int QtdLin9 { get; set; }
        }

        public class Registro9999 : RegistroBaseSped
        {
            public Registro9999()
            {
                Reg = "9999";
            }

            /// <summary>
            /// Quantidade total de linhas do arquivo digital.
            /// </summary>
            public int QtdLin { get; set; }
        }
    }
}

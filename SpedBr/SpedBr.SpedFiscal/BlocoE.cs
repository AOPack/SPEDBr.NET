using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoE
    {
        public class RegistroE001 : RegistroBaseSped
        {
            public RegistroE001()
            {
                Reg = "E001";
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public string IND_MOV { get; set; }
        }

        public class RegistroE100 : RegistroBaseSped
        {
            public RegistroE100()
            {
                Reg = "E100";
            }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            public DateTime DT_INI { get; set; }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            public DateTime DT_FIN { get; set; }
        }

        public class RegistroE110 : RegistroBaseSped
        {
            public RegistroE110()
            {
                Reg = "E110";
            }

            public decimal VL_TOT_DEBITOS { get; set; }
            public decimal VL_AJ_DEBITOS { get; set; }
            public decimal VL_TOT_AJ_DEBITOS { get; set; }
            public decimal VL_ESTORNOS_CRED { get; set; }
            public decimal VL_TOT_CREDITOS { get; set; }
            public decimal VL_AJ_CREDITOS { get; set; }
            public decimal VL_TOT_AJ_CREDITOS { get; set; }
            public decimal VL_ESTORNOS_DEB { get; set; }
            public decimal VL_SLD_CREDOR_ANT { get; set; }
            public decimal VL_SLD_APURADO { get; set; }
            public decimal VL_TOT_DED { get; set; }
            public decimal VL_ICMS_RECOLHER { get; set; }
            public decimal VL_SLD_CREDOR_TRANSPORTAR { get; set; }
            public decimal DEB_ESP { get; set; }
        }

        public class RegistroE500 : RegistroBaseSped
        {
            public RegistroE500()
            {
                Reg = "E500";
            }

            public string IND_APUR { get; set; }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            public DateTime DT_INI { get; set; }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            public DateTime DT_FIN { get; set; }
        }

        public class RegistroE520 : RegistroBaseSped
        {
            public RegistroE520()
            {
                Reg = "E520";
            }

            public decimal VL_SD_ANT_IPI { get; set; }

            public decimal VL_DEB_IPI { get; set; }

            public decimal VL_CRED_IPI { get; set; }

            public decimal VL_OD_IPI { get; set; }

            public decimal VL_OC_IPI { get; set; }

            public decimal VL_SC_IPI { get; set; }

            public decimal VL_SD_IPI { get; set; }
        }

        public class RegistroE990 : RegistroBaseSped
        {
            public RegistroE990()
            {
                Reg = "E990";
            }

            public string QTD_LIN_E { get; set; }
        }
    }
}

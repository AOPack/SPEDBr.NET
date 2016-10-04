using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO G – CONTROLE DO CRÉDITO DE ICMS DO ATIVO PERMANENTE CIAP
    /// </summary>
    public class BlocoG
    {
        /// <summary>
        /// REGISTRO G001: ABERTURA DO BLOCO G
        /// </summary>
        public class RegistroG001 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroG001()
            {
                Reg = "G001";
            }

            /// <summary>
            /// Indicador de movimento: 
            /// 0 - Bloco com dados informados; 
            /// 1 - Bloco sem dados informados.
            /// </summary>
            [SpedCampos(2, "IND_MOV", "N", 1, 0, true)]
            public int IndMov { get; set; }
        }

        /// <summary>
        /// REGISTRO G990: ENCERRAMENTO DO BLOCO G 
        /// </summary>
        public class RegistroG990 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroG990()
            {
                Reg = "G990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco G
            /// </summary>
            [SpedCampos(2, "QTD_LIN_G", "N", 0, 0, true)]
            public int QtdLinG { get; set; }
        }
    }
}

using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public class BlocoE
    {
        /// <summary>
        /// REGISTRO E001: ABERTURA DO BLOCO E
        /// </summary>
        public class RegistroE001 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
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

        /// <summary>
        /// REGISTRO E100: PERÍODO DA APURAÇÃO DO ICMS.
        /// </summary>
        public class RegistroE100 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroE100()
            {
                Reg = "E100";
            }

            /// <summary>
            /// Data inicial a que a apuração se refere.
            /// </summary>
            [SpedCampos(2, "DT_INI", "N", 8, 0, true)]
            public DateTime DT_INI { get; set; }

            /// <summary>
            /// Data final a que a apuração se refere.
            /// </summary>
            [SpedCampos(3, "DT_FIN", "N", 8, 0, true)]
            public DateTime DT_FIN { get; set; }
        }

        /// <summary>
        /// REGISTRO E110: APURAÇÃO DO ICMS – OPERAÇÕES PRÓPRIAS. 
        /// </summary>
        public class RegistroE110 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroE110()
            {
                Reg = "E110";
            }

            /// <summary>
            /// Valor total dos débitos por "Saídas e prestações com débito do imposto" 
            /// </summary>
            [SpedCampos(2, "VL_TOT_DEBITOS", "N", 0, 2, true)]
            public decimal VL_TOT_DEBITOS { get; set; }

            /// <summary>
            /// Valor total dos ajustes a débito decorrentes do documento fiscal.
            /// </summary>
            [SpedCampos(3, "VL_AJ_DEBITOS", "N", 0, 2, true)]
            public decimal VL_AJ_DEBITOS { get; set; }

            /// <summary>
            /// Valor total de "Ajustes a débito"
            /// </summary>
            [SpedCampos(4, "VL_TOT_AJ_DEBITOS", "N", 0, 2, true)]
            public decimal VL_TOT_AJ_DEBITOS { get; set; }

            /// <summary>
            /// Valor total de Ajustes “Estornos de créditos”
            /// </summary>
            [SpedCampos(5, "VL_ESTORNOS_CRED", "N", 0, 2, true)]
            public decimal VL_ESTORNOS_CRED { get; set; }

            /// <summary>
            /// Valor total dos créditos por "Entradas e aquisições com crédito do imposto" 
            /// </summary>
            [SpedCampos(6, "VL_TOT_CREDITOS", "N", 0, 2, true)]
            public decimal VL_TOT_CREDITOS { get; set; }

            /// <summary>
            /// Valor total dos ajustes a crédito decorrentes do documento fiscal.
            /// </summary>
            [SpedCampos(7, "VL_AJ_CREDITOS", "N", 0, 2, true)]
            public decimal VL_AJ_CREDITOS { get; set; }

            /// <summary>
            /// Valor total de "Ajustes a crédito"
            /// </summary>
            [SpedCampos(8, "VL_TOT_AJ_CREDITOS", "N", 0, 2, true)]
            public decimal VL_TOT_AJ_CREDITOS { get; set; }

            /// <summary>
            /// Valor total de Ajustes “Estornos de Débitos”
            /// </summary>
            [SpedCampos(9, "VL_ESTORNOS_DEB", "N", 0, 2, true)]
            public decimal VL_ESTORNOS_DEB { get; set; }

            /// <summary>
            /// Valor total de "Saldo credor do período anterior"
            /// </summary>
            [SpedCampos(10, "VL_SLD_CREDOR_ANT", "N", 0, 2, true)]
            public decimal VL_SLD_CREDOR_ANT { get; set; }

            /// <summary>
            /// Valor do saldo devedor apurado
            /// </summary>
            [SpedCampos(11, "VL_SLD_APURADO", "N", 0, 2, true)]
            public decimal VL_SLD_APURADO { get; set; }

            /// <summary>
            /// Valor total de "Deduções"
            /// </summary>
            [SpedCampos(12, "VL_TOT_DED", "N", 0, 2, true)]
            public decimal VL_TOT_DED { get; set; }

            /// <summary>
            /// Valor total de "ICMS a recolher (11-12)
            /// </summary>
            [SpedCampos(13, "VL_ICMS_RECOLHER", "N", 0, 2, true)]
            public decimal VL_ICMS_RECOLHER { get; set; }

            /// <summary>
            /// Valor total de "Saldo credor a transportar para o período seguinte” 
            /// </summary>
            [SpedCampos(14, "VL_SLD_CREDOR_TRANSPORTAR", "N", 0, 2, true)]
            public decimal VL_SLD_CREDOR_TRANSPORTAR { get; set; }

            /// <summary>
            /// Valores recolhidos ou a recolher, extraapuração.
            /// </summary>
            [SpedCampos(15, "DEB_ESP", "N", 0, 2, true)]
            public decimal DEB_ESP { get; set; }
        }

        /// <summary>
        /// REGISTRO E116: OBRIGAÇÕES DO ICMS RECOLHIDO OU A RECOLHER – OPERAÇÕES PRÓPRIAS. 
        /// </summary>
        public class RegistroE116 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroE116()
            {
                Reg = "E116";
            }

            /// <summary>
            /// Código da obrigação a recolher, conforme a Tabela 5.4
            /// </summary>
            [SpedCampos(2, "COD_OR", "C", 3, 0, true)]
            public string CodOr { get; set; }

            /// <summary>
            /// Valor da obrigação a recolher
            /// </summary>
            [SpedCampos(3, "VL_OR", "N", 0, 2, true)]
            public decimal VlOr { get; set; }

            /// <summary>
            /// Data de vencimento da obrigação
            /// </summary>
            [SpedCampos(4, "DT_VCTO", "N", 8, 0, true)]
            public string DtVcto { get; set; }

            /// <summary>
            /// Código de receita referente à obrigação, próprio da unidade da federação, conforme legislação estadual.
            /// </summary>
            [SpedCampos(5, "COD_REC", "C", 0, 0, true)]
            public string CodRec { get; set; }

            /// <summary>
            /// Número do processo ou auto de infração ao qual a obrigação está vinculada, se houver.
            /// </summary>
            [SpedCampos(6, "NUM_PROC", "C", 15, 0, false)]
            public string NumProc { get; set; }

            /// <summary>
            /// Indicador da origem do processo: 
            /// 0- SEFAZ; 
            /// 1- Justiça Federal; 
            /// 2- Justiça Estadual; 
            /// 9- Outros
            /// </summary>
            [SpedCampos(7, "IND_PROC", "C", 1, 0, false)]
            public int IndProc { get; set; }

            /// <summary>
            /// Descrição resumida do processo que embasou o lançamento
            /// </summary>
            [SpedCampos(8, "PROC", "C", 0, 0, false)]
            public string Proc { get; set; }

            /// <summary>
            /// Descrição complementar das obrigações a recolher.
            /// </summary>
            [SpedCampos(9, "TXT_COMPL", "C", 0, 0, false)]
            public string TxtCompl { get; set; }

            /// <summary>
            /// Informe o mês de referência no formato "mmaaaa"
            /// </summary>
            [SpedCampos(10, "MES_REF", "N", 6, 0, true)]
            public string MesRef { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class RegistroE500 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
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

        /// <summary>
        /// REGISTRO E990: ENCERRAMENTO DO BLOCO E 
        /// </summary>
        public class RegistroE990 : RegistroBaseSped
        {
            /// <summary>
            /// 
            /// </summary>
            public RegistroE990()
            {
                Reg = "E990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco E
            /// </summary>
            [SpedCampos(2, "QTD_LIN_E", "N", 0, 0, true)]
            public string QTD_LIN_E { get; set; }
        }
    }
}

using System;
using SpedBr.Common;

namespace SpedBr.Ecf
{
    public class Bloco0
    {
        /// <summary>
        /// REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO DA PESSOA JURÍDICA
        /// </summary>
        public class Registro0000 : RegistroBaseSped
        {
            public Registro0000()
            {
                Reg = "0000";
            }

            /// <summary>
            /// Texto fixo contendo a identificação do tipo de Sped (LECF)
            /// </summary>
            [SpedCampos(2, "NOME_ESC", "C", 4, 0, true)]
            public string NomeEsc { get; set; }

            /// <summary>
            /// Código da versão do leiaute conforme ato da RFB.
            /// </summary>
            [SpedCampos(3, "COD_VER", "C", 4, 0, true)]
            public int CodVer { get; set; }

            /// <summary>
            /// CNPJ do declarante.
            /// No caso de SCP informar o CNPJ do sócio ostensivo no campo COD_SCP.
            /// </summary>
            [SpedCampos(4, "CNPJ", "N", 14, 0, false)]
            public string Cnpj { get; set; }

            /// <summary>
            /// Nome empresarial
            /// </summary>
            [SpedCampos(5, "NOME", "C", 255, 0, false)]
            public string Nome { get; set; }

            /// <summary>
            /// Indicador do início do período.
            /// </summary>
            [SpedCampos(6, "IND_SIT_INI_PER", "N", 1, 0, true)]
            public int IndSitIniPer { get; set; }

            /// <summary>
            /// Indicador de situação especial e outros eventos.
            /// </summary>
            [SpedCampos(7, "SIT_ESPECIAL", "C", 1, 0, true)]
            public int SitEspecial { get; set; }

            /// <summary>
            /// Patrimônio remanescente em caso de cisão (%).
            /// </summary>
            [SpedCampos(8, "PAT_REMAN_CIS", "N", 8, 4, false)]
            public decimal PatRemanCis { get; set; }

            /// <summary>
            /// Data da situação especial ou evento.
            /// </summary>
            [SpedCampos(9, "DT_SIT_ESP", "N", 8, 0, false)]
            public DateTime DtSitEsp { get; set; }

            /// <summary>
            /// Data do início do período.
            /// </summary>
            [SpedCampos(10, "DT_INI", "N", 8, 0, true)]
            public DateTime DtIni { get; set; }

            /// <summary>
            /// Data do fim do período.
            /// </summary>
            [SpedCampos(11, "DT_FIN", "N", 8, 0, true)]
            public DateTime DtFin { get; set; }

            /// <summary>
            /// Indicador de escrituração retificadora.
            /// </summary>
            [SpedCampos(12, "RETIFICADORA", "C", 1, 0, true)]
            public string Retificadora { get; set; }

            /// <summary>
            /// Número do recibo da ECF anterior
            /// </summary>
            [SpedCampos(13, "NUM_REC", "C", 41, 0, false)]
            public string NumRec { get; set; }

            /// <summary>
            /// Indicador do tipo da ECF.
            /// </summary>
            [SpedCampos(14, "TIP_ECF", "N", 1, 0, true)]
            public int TipEcf { get; set; }

            /// <summary>
            /// Identificação da SCP
            /// </summary>
            [SpedCampos(15, "COD_SCP", "N", 14, 0, false)]
            public int CodScp { get; set; }
        }
    }
}

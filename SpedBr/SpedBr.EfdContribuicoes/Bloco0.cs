using System;
using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class Bloco0
    {
        public class Registro0000 : RegistroBaseSped
        {
            public Registro0000()
            {
                Reg = "0000";
            }

            [SpedCampos(2, "COD_VER", "N", 3, 0, true)]
            public int CodVer { get; set; }

            [SpedCampos(3, "TIPO_ESCRIT", "N", 1, 0, true)]
            public int TipoEscrit { get; set; }

            [SpedCampos(4, "IND_SIT_ESP", "N", 1, 0, false)]
            public int IndSitEsp { get; set; }

            [SpedCampos(5, "NUM_REC_ANTERIOR", "C", 41, 0, false)]
            public string NumRecAnterior { get; set; }

            [SpedCampos(6, "DT_INI", "N", 8, 0, true)]
            public DateTime DtIni { get; set; }

            [SpedCampos(7, "DT_FIN", "N", 8, 0, true)]
            public DateTime DtFin { get; set; }

            [SpedCampos(8, "NOME", "C", 100, 0, true)]
            public string Nome { get; set; }

            [SpedCampos(9, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }

            [SpedCampos(10, "UF", "C", 2, 0, true)]
            public string Uf { get; set; }

            [SpedCampos(11, "COD_MUN", "N", 7, 0, true)]
            public string CodMun { get; set; }

            [SpedCampos(12, "SUFRAMA", "C", 9, 0, false)]
            public string Suframa { get; set; }

            [SpedCampos(13, "IND_NAT_PJ", "N", 2, 0, false)]
            public int IndNatPj { get; set; }

            [SpedCampos(14, "IND_ATIV", "N", 1, 0, true)]
            public int IndAtiv { get; set; }
        }

        public class Registro0001 : RegistroBaseSped
        {
            public Registro0001()
            {
                Reg = "0001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

        public class Registro0035 : RegistroBaseSped
        {
            public Registro0035()
            {
                Reg = "0035";
            }

            [SpedCampos(2, "COD_SCP", "N", 14, 0, false)]
            public int CodScp { get; set; }

            [SpedCampos(3, "DESC_SCP", "C", 0, 0, false)]
            public string DescScp { get; set; }

            [SpedCampos(4, "INF_COMP", "C", 0, 0, false)]
            public string InfComp { get; set; }
        }

        public class Registro0100 : RegistroBaseSped
        {
            public Registro0100()
            {
                Reg = "0100";
            }

            [SpedCampos(2, "NOME", "C", 100, 0, true)]
            public string Nome { get; set; }

            [SpedCampos(3, "CPF", "N", 11, 0, true)]
            public int Cpf { get; set; }

            [SpedCampos(4, "CRC", "C", 15, 0, true)]
            public string Crc { get; set; }

            [SpedCampos(5, "CNPJ", "N", 14, 0, false)]
            public int Cnpj { get; set; }

            [SpedCampos(6, "CEP", "N", 8, 0, false)]
            public int Cep { get; set; }

            [SpedCampos(7, "END", "C", 60, 0, false)]
            public string End { get; set; }

            [SpedCampos(8, "NUM", "C", 0, 0, false)]
            public string Num { get; set; }

            [SpedCampos(9, "COMPL", "C", 60, 0, false)]
            public string Compl { get; set; }

            [SpedCampos(10, "BAIRRO", "C", 60, 0, false)]
            public string Bairro { get; set; }

            [SpedCampos(11, "FONE", "C", 11, 0, false)]
            public string Fone { get; set; }

            [SpedCampos(12, "FAX", "C", 11, 0, false)]
            public string Fax { get; set; }

            [SpedCampos(13, "EMAIL", "C", 0, 0, false)]
            public string Email { get; set; }

            [SpedCampos(14, "COD_MUN", "N", 7, 0, false)]
            public int CodMun { get; set; }
        }

        public class Registro0110 : RegistroBaseSped
        {
            public Registro0110()
            {
                Reg = "0110";
            }

            [SpedCampos(2, "COD_INC_TRIB", "N", 1, 0, true)]
            public int CodIncTrib { get; set; }

            [SpedCampos(3, "IND_APRO_CRED", "N", 1, 0, false)]
            public int IndAproCred { get; set; }

            [SpedCampos(4, "COD_TIPO_CONT", "N", 1, 0, false)]
            public int CodTipoCont { get; set; }

            [SpedCampos(5, "IND_REG_CUM", "N", 1, 0, false)]
            public int IndRegCum { get; set; }
        }

        public class Registro0140 : RegistroBaseSped
        {
            public Registro0140()
            {
                Reg = "0140";
            }

            [SpedCampos(2, "COD_EST", "C", 60, 0, false)]
            public string CodEst { get; set; }

            [SpedCampos(3, "NOME", "C", 100, 0, true)]
            public string Nome { get; set; }

            [SpedCampos(4, "CNPJ", "N", 14, 0, true)]
            public int Cnpj { get; set; }

            [SpedCampos(5, "UF", "C", 2, 0, true)]
            public string Uf { get; set; }

            [SpedCampos(6, "IE", "C", 14, 0, false)]
            public string Ie { get; set; }

            [SpedCampos(7, "COD_MUN", "N", 7, 0, true)]
            public int CodMun { get; set; }

            [SpedCampos(8, "IM", "C", 0, 0, false)]
            public string Im { get; set; }

            [SpedCampos(9, "SUFRAMA", "C", 9, 0, false)]
            public string Suframa { get; set; }
        }

        public class Registro0990 : RegistroBaseSped
        {
            public Registro0990()
            {
                Reg = "0990";
            }

            [SpedCampos(2, "QTD_LIN_0", "N", 0, 0, true)]
            public int QtdLin0 { get; set; }
        }
    }
}

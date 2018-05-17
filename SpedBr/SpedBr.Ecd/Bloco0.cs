using SpedBr.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpedBr.Ecd
{
    public class Bloco0
    {
        /// <summary>
        /// REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO DO EMPRESÁRIO OU DA SOCIEDADE EMPRESÁRIA
        /// </summary>
        public class Registro0000 : RegistroBaseSped
        {
            public Registro0000()
            {
                Reg = "0000";
            }

            /// <summary>
            /// Texto fixo contendo "LECD"
            /// </summary>
            [SpedCampos(2, "LECD", "C", 4, 0, true)]
            public string Lecd {
                get { return "LECD"; } }

            /// <summary>
            /// Data inicial das informações contidas no arquivo
            /// </summary>
            [SpedCampos(3, "DT_INI", "N", 8, 0, true)]
            public DateTime DtIni { get; set; }

            /// <summary>
            /// Data final das informações contidas no arquivo
            /// </summary>
            [SpedCampos(4, "DT_FIN", "N", 8, 0, true)]
            public DateTime DtFin { get; set; }

            /// <summary>
            /// Nome empresarial da pessoa jurídica
            /// </summary>
            [SpedCampos(5, "NOME", "C", Int16.MaxValue, 0, true)]
            public string Nome { get; set; }

            /// <summary>
            /// Número de inscrição da pessoa jurídica no CNPJ
            /// </summary>
            /// <remarks>
            /// Observação: Esse CNPJ é sempre da Sócia Ostensiva, no caso do arquivo da SCP.
            /// </remarks>
            [SpedCampos(6, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }

            /// <summary>
            /// Sigla da unidade da federação da pessoa jurídica
            /// </summary>
            [SpedCampos(7, "UF", "C", 2, 0, true)]
            public string Uf { get; set; }

            /// <summary>
            /// Inscrição Estadual da pessoa jurídica
            /// </summary>
            [SpedCampos(8, "IE", "C", Int16.MaxValue, 0, false)]
            public string Ie { get; set; }

            /// <summary>
            /// Código do município do domicílio fiscal da pessoa jurídica, conforme tabela do IBGE - Instituto Brasileiro de Geografia e Estatística
            /// </summary>
            [SpedCampos(9, "COD_MUN", "N", 7, 0, false)]
            public string CodMun { get; set; }

            /// <summary>
            /// Inscrição Municipal da pessoa jurídica
            /// </summary>
            [SpedCampos(10, "IM", "C", Int16.MaxValue, 0, false)]
            public string Im { get; set; }

            /// <summary>
            /// Indicador de situação especial
            /// </summary>
            [SpedCampos(11, "IND_SIT_ESP", "N", 1, 0, false)]
            public Int16? IndSitEsp { get; set; }

            /// <summary>
            /// Indicador de situação no início do período
            /// </summary>
            [SpedCampos(12, "IND_SIT_INI_PER", "N", 1, 0, true)]
            public Int16 IndSitIniPer { get; set; }

            /// <summary>
            /// Indicador de existência de NIRE
            /// </summary>
            /// <remarks>
            /// 0 - Empresa não possui registro na Junta Comercial (não possui NIRE); <para/>
            /// 1 - Empresa possui registro na Junta Comercial (possui NIRE)
            /// </remarks>
            [SpedCampos(13, "IND_NIRE", "N", 1, 0, true)]
            public Int16 IndNire { get; set; }

            /// <summary>
            /// Indicador de finalidade da escrituração
            /// </summary>
            /// <remarks>
            /// 0 - Original; <para/>
            /// 1 - Substituta
            /// </remarks>
            [SpedCampos(14, "IND_FIN_ESC", "N", 1, 0, true)]
            public IndCodFinalidadeArquivo IndFinEsc { get; set; }

            /// <summary>
            /// Hash da escrituração substituída
            /// </summary>
            [SpedCampos(15, "COD_HASH_SUB", "C", 40, 0, false)]
            public string CodHashSub { get; set; }

            /// <summary>
            /// Indicador de entidade sujeita a auditoria independente
            /// </summary>
            /// <remarks>
            /// 0 - Empresa não é entidade sujeita a auditoria independente; <para/>
            /// 1 - Empresa é entidade sujeita a auditoria independente - Ativo Total superior a R$ 240.000.000,00 ou Receita Bruta Anual superior a R$ 300.000.000,00
            /// </remarks>
            [SpedCampos(16, "IND_GRANDE_PORTE", "N", 1, 0, true)]
            public Int16 IndGrandePorte { get; set; }

            /// <summary>
            /// Indicador do tipo de ECD
            /// </summary>
            /// <remarks>
            /// 0 - ECD de empresa não participante de SCP como sócio ostensivo; <para/>
            /// 1 - ECD de empresa participante de SCP como sócio ostensivo; <para/>
            /// 2 - ECD da SCP
            /// </remarks>
            [SpedCampos(17, "TIP_ECD", "N", 1, 0, true)]
            public Int16 TipEcd { get; set; }

            /// <summary>
            /// CNPJ da SCP (Art. 4º, XVII, da IN RFB nº 1.634, de 6 de maio de 2016)
            /// </summary>
            /// <remarks>
            /// Observação: Só deve ser preenchido pela própria SCP com o CNPJ da SCP (Não é preenchido pelo sócio ostensivo)
            /// </remarks>
            [SpedCampos(18, "COD_SCP", "N", 14, 0, false)]
            public string CodScp { get; set; }

            /// <summary>
            /// Identificação de moeda funcional. Indica que a escrituração abrange valores com base na moeda funcional (art. 287 da IN RFB nº 1.700, de 14 de março de 2017)
            /// </summary>
            /// <remarks>
            /// Observação: Nessa situação, deverá ser utilizado o registro I020 para informação de campos adicionais
            /// </remarks>
            [SpedCampos(19, "IDENT_MF", "C", 1, 0, true)]
            public SimOuNao IdentMf { get; set; }

            /// <summary>
            /// Escrituração Contábeis Consolidadas <para/>
            /// Deve ser preenchido pela empresa controladora obrigada a informar demonstrações contábeis consolidadas, <para/>
            /// nos termos da Lei nº 6.404/76 e do Pronunciamento Técnico CPC 36 - Demonstrações Consolidadas
            /// </summary>
            /// <remarks>
            /// S - Sim; <para/>
            /// N - Não
            /// </remarks>
            [SpedCampos(20, "IND_ESC_CONS", "C", 1, 0, true)]
            public SimOuNao IndEscCons { get; set; }
        }
    }
}

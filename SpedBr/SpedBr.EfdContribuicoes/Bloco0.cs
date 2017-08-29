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
            public int? IndSitEsp { get; set; }

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
            public int? IndNatPj { get; set; }

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
            public IndMovimento IndMov { get; set; }
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
            public string Cpf { get; set; }

            [SpedCampos(4, "CRC", "C", 15, 0, true)]
            public string Crc { get; set; }

            [SpedCampos(5, "CNPJ", "N", 14, 0, false)]
            public string Cnpj { get; set; }

            [SpedCampos(6, "CEP", "N", 8, 0, false)]
            public string Cep { get; set; }

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

            [SpedCampos(5, "IND_REG_CUM", "BLANK", 1, 0, false)]
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
            public string Cnpj { get; set; }

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

        /// <summary>
        ///     REGISTRO 0150: TABELA DE CADASTRO DO PARTICIPANTE
        /// </summary>
        public class Registro0150 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="Registro0150" />.
            /// </summary>
            public Registro0150()
            {
                Reg = "0150";
            }

            /// <summary>
            ///     Código de identificação do participante no arquivo.
            /// </summary>
            [SpedCampos(2, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            ///     Nome pessoal ou empresarial do participante.
            /// </summary>
            [SpedCampos(3, "NOME", "C", 100, 0, true)]
            public string Nome { get; set; }

            /// <summary>
            ///     Código do país do participante, conforme a tabela indicada no item 3.2.1.
            /// </summary>
            [SpedCampos(4, "COD_PAIS", "N", 5, 0, true)]
            public string CodPais { get; set; }

            /// <summary>
            ///     CNPJ do participante.
            /// </summary>
            [SpedCampos(5, "CNPJ", "N", 14, 0, false)]
            public string Cnpj { get; set; }

            /// <summary>
            ///     CPF do participante.
            /// </summary>
            [SpedCampos(6, "CPF", "N", 11, 0, false)]
            public string Cpf { get; set; }

            /// <summary>
            ///     Inscrição Estadual do participante.
            /// </summary>
            [SpedCampos(7, "IE", "C", 14, 0, false)]
            public string Ie { get; set; }

            /// <summary>
            ///     Código do município, conforme a tabela IBGE.
            /// </summary>
            [SpedCampos(8, "COD_MUN", "N", 7, 0, false)]
            public string CodMun { get; set; }

            /// <summary>
            ///     Número de inscrição do participante na SUFRAMA
            /// </summary>
            [SpedCampos(9, "SUFRAMA", "C", 9, 0, false)]
            public string Suframa { get; set; }

            /// <summary>
            ///     Logradouro e endereço do imóvel.
            /// </summary>
            [SpedCampos(10, "END", "C", 60, 0, true)]
            public string End { get; set; }

            /// <summary>
            ///     Número do imóvel.
            /// </summary>
            [SpedCampos(11, "NUM", "C", 10, 0, false)]
            public string Num { get; set; }

            /// <summary>
            ///     Dados complementares do endereço.
            /// </summary>
            [SpedCampos(12, "COMPL", "C", 60, 0, false)]
            public string Compl { get; set; }

            /// <summary>
            ///     Bairro em que o imóvel está situado.
            /// </summary>
            [SpedCampos(13, "BAIRRO", "C", 60, 0, false)]
            public string Bairro { get; set; }
        }

        /// <summary>
        ///     REGISTRO 0190: IDENTIFICAÇÃO DAS UNIDADES DE MEDIDA
        /// </summary>
        public class Registro0190 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="Registro0190" />.
            /// </summary>
            public Registro0190()
            {
                Reg = "0190";
            }

            /// <summary>
            ///     Código da unidade de medida.
            /// </summary>
            [SpedCampos(2, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }

            /// <summary>
            ///     Descrição da unidade de medida.
            /// </summary>
            [SpedCampos(3, "DESCR", "C", int.MaxValue, 0, true)]
            public string Descr { get; set; }
        }

        /// <summary>
        ///     REGISTRO 0200: IDENTIFICAÇÃO DO ITEM (PRODUTOS E SERVIÇOS)
        /// </summary>
        public class Registro0200 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="Registro0200" />.
            /// </summary>
            public Registro0200()
            {
                Reg = "0200";
            }

            /// <summary>
            ///     Código do item.
            /// </summary>
            [SpedCampos(2, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Descrição do item.
            /// </summary>
            [SpedCampos(3, "DESCR_ITEM", "C", int.MaxValue, 0, true)]
            public string DescrItem { get; set; }

            /// <summary>
            ///     Representação alfanumérica do código de barra do produto, se houver.
            /// </summary>
            [SpedCampos(4, "COD_BARRA", "C", 0, 0, false)]
            public string CodBarra { get; set; }

            /// <summary>
            ///     Código anterior do item com relação à última informação apresentada.
            /// </summary>
            [SpedCampos(5, "COD_ANT_ITEM", "C", 60, 0, false)]
            public string CodAntItem => "";

            /// <summary>
            ///     Unidade de medida utilizada na quantificação de estoques.
            /// </summary>
            [SpedCampos(6, "UNID_INV", "C", 6, 0, true)]
            public string UnidInv { get; set; }

            /// <summary>
            ///     Tipo do item - Atividades Industriais, Comerciais e Serviços: 00 - Mercadoria para Revenda; 01 - Matéria-Prima; 02
            ///     - Embalagem; 03 - Produto em Processo; 04 - Produto Acabado; 05 - Subproduto; 06 - Produto Intermediário; 07 -
            ///     Material de Uso e Consumo; 08 - Ativo Imobilizado; 09 - Serviços; 10 - Outros insumos; 99 - Outras.
            /// </summary>
            [SpedCampos(7, "TIPO_ITEM", "N", 2, 0, true)]
            public string TipoItem { get; set; }

            /// <summary>
            ///     Código da Nomenclatura Comum do Mercosul
            /// </summary>
            [SpedCampos(8, "COD_NCM", "C", 8, 0, false)]
            public string CodNcm { get; set; }

            /// <summary>
            ///     Código EX, conforme a TIPI
            /// </summary>
            [SpedCampos(9, "EX_IPI", "C", 3, 0, false)]
            public string ExIpi { get; set; }

            /// <summary>
            ///     Código do gênero do item
            /// </summary>
            [SpedCampos(10, "COD_GEN", "N", 2, 0, false)]
            public string CodGen { get; set; }

            /// <summary>
            ///     Código do serviço conforme a lista do Anexo I da Lei Complementar Federal n 116/2003.
            /// </summary>
            [SpedCampos(11, "COD_LST", "C", 5, 0, false)]
            public string CodLst { get; set; }

            /// <summary>
            ///     Alíquota de ICMS aplicável ao item nas operações internas.
            /// </summary>
            [SpedCampos(12, "ALIQ_ICMS", "N", 6, 2, false)]
            public decimal AliqIcms { get; set; }
        }

        /// <summary>
        ///     REGISTRO 0400: TABELA DE NATUREZA DA OPERAÇÃO/PRESTAÇÃO
        /// </summary>
        public class Registro0400 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="Registro0400" />.
            /// </summary>
            public Registro0400()
            {
                Reg = "0400";
            }

            /// <summary>
            ///     Código da natureza da operação/prestação
            /// </summary>
            [SpedCampos(2, "COD_NAT", "C", 10, 0, true)]
            public string CodNat { get; set; }

            /// <summary>
            ///     Descrição da natureza da operação/prestação
            /// </summary>
            [SpedCampos(3, "DESCR_NAT", "C", 200, 0, true)]
            public string DescrNat { get; set; }
        }

        public class Registro0990 : RegistroBaseSped
        {
            public Registro0990()
            {
                Reg = "0990";
            }

            [SpedCampos(2, "QTD_LIN_0", "N", int.MaxValue, 0, true)]
            public int QtdLin0 { get; set; }
        }

    }
}

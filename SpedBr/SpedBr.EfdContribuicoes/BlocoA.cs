using SpedBr.Common;
using System;

namespace SpedBr.EfdContribuicoes
{
	/// <summary>
    /// BLOCO A: DOCUMENTOS FISCAIS - SERVIÇOS (NÃO SUJEITOS AO ICMS)
    /// </summary>
    public class BlocoA
    {
        /// <summary>
        /// REGISTRO A001: ABERTURA DO BLOCO A
        /// </summary>
        public class RegistroA001 : RegistroBaseSped
        {
            public RegistroA001()
            {
                Reg = "A001";
            }

			/// <summary>
            /// Indicador de movimento:
            /// 0 - Bloco com dados informados; 
            /// 1 - Bloco sem dados informados
            /// </summary>
            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public int IndMov { get; set; }
        }

		/// <summary>
        /// REGISTRO A010: IDENTIFICAÇÃO DO ESTABELECIMENTO
        /// </summary>
        public class RegistroA010 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroA010"/>.
            /// </summary>   
            public RegistroA010()
            {
                Reg = "A010";
            }

            /// <summary>
            /// Número de inscrição do estabelecimento no CNPJ
            /// </summary>
            [SpedCampos(2, "CNPJ", "N", 14, 0, true)]
            public string Cnpj { get; set; }
        }

        /// <summary>
        /// REGISTRO A100: DOCUMENTO - NOTA FISCAL DE SERVIÇO
        /// </summary>
        public class RegistroA100 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroA100"/>.
            /// </summary>   
            public RegistroA100()
            {
                Reg = "A100";
            }

            /// <summary>
            /// Indicador do tipo de operação: 
            /// 0 - Serviço Contratado pelo Estabelecimento
            /// 1 - Serviço Prestado pelo Estabelecimento
            /// </summary>
            [SpedCampos(2, "IND_OPER", "C", 1, 0, true)]
            public int Cnpj { get; set; }

            /// <summary>
            /// Indicador do emitente do documento fiscal: 
            /// 0 - Emissão própria
            /// 1 - Emissão de Terceiros
            /// </summary>
            [SpedCampos(3, "IND_EMIT", "C", 1, 0, true)]
            public int IndEmit { get; set; }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): 
            /// - do emitente do documento, no caso de emissão de terceiros; 
            /// - do adquirente, no caso de serviços prestados
            /// </summary>
            [SpedCampos(4, "COD_PART", "C", 60, 0, true)]
            public int CodPart { get; set; }

            /// <summary>
            /// Código da situação do documento fiscal:
            /// 00 - Documento regular
            /// 02 - Documento cancelado
            /// </summary>
            [SpedCampos(5, "COD_SIT", "N", 2, 0, true)]
            public int CodSit { get; set; }

            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            [SpedCampos(6, "SER", "C", 20, 0, false)]
            public string Ser { get; set; }

            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            [SpedCampos(7, "SUB", "C", 20, 0, false)]
            public string Sub { get; set; }

            /// <summary>
            /// Número do documento fiscal ou documento internacional equivalente
            /// </summary>
            [SpedCampos(8, "NUM_DOC", "C", 60, 0, true)]
            public string NumDoc { get; set; }

            /// <summary>
            /// Chave/Código de Verificação da nota fiscal de serviço eletrônica
            /// </summary>
            [SpedCampos(9, "CHV_NFSE", "C", 60, 0, false)]
            public string ChvNfse { get; set; }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            [SpedCampos(10, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Data de Execução / Conclusão do Serviço
            /// </summary>
            [SpedCampos(11, "DT_EXE_SERV", "N", 8, 0, false)]
            public DateTime DtExeServ { get; set; }

            /// <summary>
            /// Valor total do documento
            /// </summary>
            [SpedCampos(12, "VL_DOC", "N", 0, 2, true)]
            public decimal VlDoc { get; set; }

            /// <summary>
            /// Indicador do tipo de pagamento: 
            /// 0- À vista; 
            /// 1- A prazo; 
            /// 9- Sem pagamento
            /// </summary>
            [SpedCampos(13, "IND_PGTO", "C", 1, 0, true)]
            public int IndPagto { get; set; }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            [SpedCampos(14, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Valor da base de cálculo do PIS/PASEP
            /// </summary>
            [SpedCampos(15, "VL_BC_PIS", "N", 0, 2, true)]
            public decimal VlBcPis { get; set; }

            /// <summary>
            /// Valor total do PIS
            /// </summary>
            [SpedCampos(16, "VL_PIS", "N", 0, 2, true)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// Valor da base de cálculo da COFINS
            /// </summary>
            [SpedCampos(17, "VL_BC_COFINS", "N", 0, 2, true)]
            public decimal VlBcCofins { get; set; }

            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            [SpedCampos(18, "VL_COFINS", "N", 0, 2, true)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Valor total do PIS retido na fonte
            /// </summary>
            [SpedCampos(19, "VL_PIS_RET", "N", 0, 2, false)]
            public decimal VlPisRet { get; set; }

            /// <summary>
            /// Valor total da COFINS retido na fonte
            /// </summary>
            [SpedCampos(20, "VL_COFINS_RET", "N", 0, 2, false)]
            public decimal VlCofinsRet { get; set; }

            /// <summary>
            /// Valor do ISS
            /// </summary>
            [SpedCampos(21, "VL_ISS", "N", 0, 2, false)]
            public decimal VlIss { get; set; }
        }

        /// <summary>
        /// REGISTRO A170: COMPLEMENTO DO DOCUMENTO - ITENS DO DOCUMENTO
        /// </summary>
        public class RegistroA170 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroA170"/>.
            /// </summary>
            public RegistroA170()
            {
                Reg = "A170";
            }

            /// <summary>
            /// Número seqüencial do item no documento fiscal
            /// </summary>
            [SpedCampos(2, "NUM_ITEM", "N", 3, 0, true)]
            public int NumItem { get; set; }

            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            /// Valor total da COFINS retido na fonte
            /// </summary>
            [SpedCampos(4, "DESCR_COMPL", "C", 0, 0, false)]
            public string DescrCompl { get; set; }

            /// <summary>
            /// Valor total do item (mercadorias ou serviços)
            /// </summary>
            [SpedCampos(5, "VL_ITEM", "N", 0, 2, true)]
            public decimal VlItem { get; set; }

            /// <summary>
            /// Valor do desconto do item
            /// </summary>
            [SpedCampos(6, "VL_DESC", "N", 0, 2, false)]
            public decimal VlDesc { get; set; }

            /// <summary>
            /// Código da Base de Cálculo do Crédito, conforme a Tabela indicada no item 4.3.7, caso seja informado código representativo de crédito no Campo 09 (CST_PIS) ou no Campo 13 (CST_COFINS)
            /// </summary>
            [SpedCampos(7, "NAT_BC_CRED", "C", 2, 0, false)]
            public string NatBcCred { get; set; }

            /// <summary>
            /// Indicador da origem do crédito: 
            /// 0 - Operação no Mercado Interno 
            /// 1 - Operação de Importação
            /// </summary>
            [SpedCampos(8, "IND_ORIG_CRED", "C", 1, 0, false)]
            public string IndOrigCred { get; set; }

            /// <summary>
            /// Código da Situação Tributária referente ao PIS/PASEP - Tabela 4.3.3
            /// </summary>
            [SpedCampos(9, "CST_PIS", "N", 2, 0, true)]
            public int CstPis { get; set; }

            /// <summary>
            /// Valor da base de cálculo do PIS/PASEP
            /// </summary>
            [SpedCampos(10, "VL_BC_PIS", "N", 0, 2, false)]
            public decimal VlBcPis { get; set; }

            /// <summary>
            /// Valor da base de cálculo do PIS/PASEP
            /// </summary>
            [SpedCampos(11, "ALIQ_PIS", "N", 0, 2, false)]
            public decimal AliqPis { get; set; }

            /// <summary>
            /// Valor da base de cálculo do PIS/PASEP
            /// </summary>
            [SpedCampos(12, "VL_PIS", "N", 0, 2, false)]
            public decimal VlPis { get; set; }

            /// <summary>
            /// VCódigo da Situação Tributária referente ao COFINS - Tabela 4.3.4
            /// </summary>
            [SpedCampos(13, "CST_COFINS", "N", 2, 0, true)]
            public int CstCofins { get; set; }

            /// <summary>
            /// VCódigo da Situação Tributária referente ao COFINS - Tabela 4.3.4
            /// </summary>
            [SpedCampos(14, "VL_BC_COFINS", "N", 0, 2, false)]
            public decimal VlBcCofins { get; set; }

            /// <summary>
            /// Alíquota do COFINS (em percentual)
            /// </summary>
            [SpedCampos(15, "ALIQ_COFINS", "N", 6, 2, false)]
            public decimal AliqCofins { get; set; }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            [SpedCampos(16, "VL_COFINS", "N", 0, 2, false)]
            public decimal VlCofins { get; set; }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            [SpedCampos(17, "COD_CTA", "C", 60, 0, false)]
            public string CodCta { get; set; }

            /// <summary>
            /// Código do centro de custos
            /// </summary>
            [SpedCampos(18, "COD_CCUS", "C", 60, 0, false)]
            public string CodCcus { get; set; }
        }

        /// <summary>
        /// REGISTRO A990: ENCERRAMENTO DO BLOCO A
        /// </summary>
        public class RegistroA990 : RegistroBaseSped
        {
			/// <summary>
            /// Inicializa uma nova instância da classe <see cref="RegistroA990"/>.
            /// </summary>
            public RegistroA990()
            {
                Reg = "A990";
            }

			/// <summary>
            /// Quantidade total de linhas do Bloco 0.
            /// </summary>
            [SpedCampos(2, "QTD_LIN_A", "N", 0, 0, true)]
            public int QtdLinA { get; set; }
        }
    }
}

using System;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO 1: OUTRAS INFORMAÇÕES
    /// </summary>
    public class Bloco1
    {
        /// <summary>
        /// REGISTRO 1001: ABERTURA DO BLOCO 1
        /// </summary>
        public class Registro1001 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1001"/>.
            /// </summary>
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

        /// <summary>
        /// REGISTRO 1010: OBRIGATORIEDADE DE REGISTROS DO BLOCO 1
        /// </summary>
        public class Registro1010 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1010"/>.
            /// </summary>
            public Registro1010()
            {
                Reg = "1010";
            }

            /// <summary>
            /// Reg. 1100 - Ocorreu averbação (conclusão) de exportação no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(2, "IND_EXP", "C", 1, 0, true)]
            public string IndExp { get; set; }

            /// <summary>
            /// Reg. 1200 - Existem informações acerca de créditos de ICMS a serem controlados, definidos pela Sefaz: S - Sim; N - Não
            /// </summary>
            [SpedCampos(3, "IND_CCRF", "C", 1, 0, true)]
            public string IndCcrf { get; set; }

            /// <summary>
            /// Reg. 1300 – É comercio varejista de combustíveis com movimentação e/ou estoque no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(4, "IND_COMB", "C", 1, 0, true)]
            public string IndComb { get; set; }

            /// <summary>
            /// Reg. 1390 – Usinas de açúcar e/álcool – O estabelecimento é produtor de açúcar e/ou álcool carburante com movimentação e/ou estoque no período: S - Sim; N - Não
            /// </summary>
            [SpedCampos(5, "IND_USINA", "C", 1, 0, true)]
            public string IndUsina { get; set; }

            /// <summary>
            /// Reg 1400 – Sendo o registro obrigatório em sua Unidade de Federação, existem informações a serem prestadas neste registro: S - Sim; N - Não
            /// </summary>
            [SpedCampos(6, "IND_VA", "C", 1, 0, true)]
            public string IndVa { get; set; }

            /// <summary>
            /// Reg 1500 - A empresa é distribuidora de energia e ocorreu fornecimento de energia elétrica para consumidores de outra UF: S - Sim; N - Não
            /// </summary>
            [SpedCampos(7, "IND_EE", "C", 1, 0, true)]
            public string IndEe { get; set; }

            /// <summary>
            /// Reg 1600 - Realizou vendas com Cartão de Crédito ou de débito: S - Sim; N - Não
            /// </summary>
            [SpedCampos(8, "IND_CART", "C", 1, 0, true)]
            public string IndCart { get; set; }

            /// <summary>
            /// Reg. 1700 – Foram emitidos documentos fiscais em papel no período em unidade da federação que exija o controle de utilização de documentos fiscais: S - Sim; N - Não
            /// </summary>
            [SpedCampos(9, "IND_FORM", "C", 1, 0, true)]
            public string IndForm { get; set; }

            /// <summary>
            /// Reg 1800 – A empresa prestou serviços de transporte aéreo de cargas e de passageiros: S - Sim; N - Não
            /// </summary>
            [SpedCampos(10, "IND_AER", "C", 1, 0, true)]
            public string IndAer { get; set; }
        }

        /// <summary>
        /// REGISTRO 1100: REGISTRO DE INFORMAÇÕES SOBRE EXPORTAÇÃO
        /// </summary>
        public class Registro1100 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1100"/>.
            /// </summary>
            public Registro1100()
            {
                Reg = "1100";
            }

            /// <summary>
            /// 0 - Declaração de Exportação; 1 - Declaração Simplificada de Exportação
            /// </summary>
            [SpedCampos(2, "IND_DOC", "N", 1, 0, true)]
            public int IndDoc { get; set; }

            /// <summary>
            /// Número da declaração
            /// </summary>
            [SpedCampos(3, "NRO_DE", "N", 11, 0, true)]
            public int NroDe { get; set; }

            /// <summary>
            /// Data da declaração
            /// </summary>
            [SpedCampos(4, "DT_DE", "N", 8, 0, true)]
            public DateTime DtDe { get; set; }

            /// <summary>
            /// 0 - Exportação Direta; 1 - Exportação Indireta
            /// </summary>
            [SpedCampos(5, "NAT_EXP", "N", 1, 0, true)]
            public int NatExp { get; set; }

            /// <summary>
            /// Nro do registro de exportação
            /// </summary>
            [SpedCampos(6, "NRO_RE", "N", 12, 0, false)]
            public int NroRe { get; set; }

            /// <summary>
            /// Data do registro de exportação
            /// </summary>
            [SpedCampos(7, "DT_RE", "N", 8, 0, false)]
            public DateTime DtRe { get; set; }

            /// <summary>
            /// Nro do conhecimento de embarque
            /// </summary>
            [SpedCampos(8, "CHC_EMB", "C", 18, 0, false)]
            public string ChcEmb { get; set; }

            /// <summary>
            /// Data do conhecimento de embarque
            /// </summary>
            [SpedCampos(9, "DT_CHC", "N", 8, 0, false)]
            public DateTime DtChc { get; set; }

            /// <summary>
            /// Data da averbação da declaração de exportação
            /// </summary>
            [SpedCampos(10, "DT_AVB", "N", 8, 0, true)]
            public DateTime DtAvb { get; set; }

            /// <summary>
            /// Tipo de conhecimento de embarque
            /// </summary>
            [SpedCampos(11, "TP_CHC", "N", 1, 0, true)]
            public int TpChc { get; set; }

            /// <summary>
            /// Código do país de destino da mercadoria (conforme tabela do SISCOMEX)
            /// </summary>
            [SpedCampos(12, "PAIS", "N", 3, 0, true)]
            public int Pais { get; set; }
        }

        /// <summary>
        /// REGISTRO 1105: DOCUMENTOS FISCAIS DE EXPORTAÇÃO
        /// </summary>
        public class Registro1105 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1105"/>.
            /// </summary>
            public Registro1105()
            {
                Reg = "1105";
            }

            /// <summary>
            /// Código do modelo da NF
            /// </summary>
            [SpedCampos(2, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Série da nota fiscal
            /// </summary>
            [SpedCampos(3, "SERIE", "C", 3, 0, false)]
            public string Serie { get; set; }

            /// <summary>
            /// Nro da nota fiscal de exportação emitida pelo exportador
            /// </summary>
            [SpedCampos(4, "NUM_DOC", "N", 9, 0, true)]
            public int NumDoc { get; set; }

            /// <summary>
            /// Chave da nota fiscal eletrônica
            /// </summary>
            [SpedCampos(5, "CHV_NFE", "N", 44, 0, false)]
            public string ChvNfe { get; set; }

            /// <summary>
            /// Data da emissão da NF de exportação
            /// </summary>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Código do item
            /// </summary>
            [SpedCampos(7, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }
        }

        /// <summary>
        /// REGISTRO 1110: OPERAÇÕES DE EXPORTAÇÃO INDIRETA - MERCADORIAS DE TERCEIROS
        /// </summary>
        public class Registro1110 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1110"/>.
            /// </summary>
            public Registro1110()
            {
                Reg = "1110";
            }

            /// <summary>
            /// Código do participante-fornecedor da mercadoria destinada à exportação
            /// </summary>
            [SpedCampos(2, "COD_PART", "C", 60, 0, true)]
            public string CodPart { get; set; }

            /// <summary>
            /// Código do modelo da NF
            /// </summary>
            [SpedCampos(3, "COD_MOD", "C", 2, 0, true)]
            public string CodMod { get; set; }

            /// <summary>
            /// Série da nota fiscal
            /// </summary>
            [SpedCampos(4, "SERIE", "C", 3, 0, false)]
            public string Serie { get; set; }

            /// <summary>
            /// Nro da nota fiscal recebida com fins específicos de exportação
            /// </summary>
            [SpedCampos(5, "NUM_DOC", "N", 9, 0, true)]
            public int NumDoc { get; set; }

            /// <summary>
            /// Data da emissão da NF de exportação
            /// </summary>
            [SpedCampos(6, "DT_DOC", "N", 8, 0, true)]
            public DateTime DtDoc { get; set; }

            /// <summary>
            /// Chave da nota fiscal eletrônica
            /// </summary>
            [SpedCampos(7, "CHV_NFE", "N", 44, 0, false)]
            public string ChvNfe { get; set; }

            /// <summary>
            /// Nro do memorando de exportação
            /// </summary>
            [SpedCampos(8, "NR_MEMO", "N", 0, 0, false)]
            public string CodItem { get; set; }

            /// <summary>
            /// Quantidade do item efetivamente exportado
            /// </summary>
            [SpedCampos(9, "QTD", "N", 0, 3, true)]
            public int Qtd { get; set; }

            /// <summary>
            /// Unidade do item
            /// </summary>
            [SpedCampos(10, "UNID", "C", 6, 0, true)]
            public string Unid { get; set; }
        }

        /// <summary>
        /// REGISTRO 1200: CONTROLE DE CRÉDITOS FISCAIS - ICMS
        /// </summary>
        public class Registro1200 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1200"/>.
            /// </summary>
            public Registro1200()
            {
                Reg = "1200";
            }

            /// <summary>
            /// Código de ajuste
            /// </summary>
            [SpedCampos(2, "COD_AJ_APUR", "C", 8, 0, true)]
            public string CodAjApur { get; set; }

            /// <summary>
            /// Saldo de créditos fiscais de períodos anteriores
            /// </summary>
            [SpedCampos(3, "SLD_CRED", "N", 0, 2, true)]
            public decimal SldCred { get; set; }

            /// <summary>
            /// Total de credito apropriado no mês
            /// </summary>
            [SpedCampos(4, "CRED_APR", "N", 0, 2, true)]
            public decimal CredApr { get; set; }

            /// <summary>
            /// Total de créditos recebidos por transferência
            /// </summary>
            [SpedCampos(5, "CRED_RECEB", "N", 0, 2, true)]
            public decimal CredReceb { get; set; }

            /// <summary>
            /// Total de créditos utilizados no período
            /// </summary>
            [SpedCampos(6, "CRED_UTIL", "N", 0, 2, true)]
            public decimal CredUtil { get; set; }

            /// <summary>
            /// Saldo de crédito fiscal acumulado a transportar para o período seguinte
            /// </summary>
            [SpedCampos(7, "SLD_CRED_FIM", "N", 0, 2, true)]
            public decimal SldCredFim { get; set; }
        }

        /// <summary>
        /// REGISTRO 1210: UTILIZAÇÃO DE CRÉDITOS FISCAIS - ICMS
        /// </summary>
        public class Registro1210 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1210"/>.
            /// </summary>
            public Registro1210()
            {
                Reg = "1210";
            }

            /// <summary>
            /// Tipo de utilização do crédito
            /// </summary>
            [SpedCampos(2, "TIPO_UTIL", "C", 4, 0, true)]
            public string TipoUtil { get; set; }

            /// <summary>
            /// Nro do documento utilizado na baixa de créditos
            /// </summary>
            [SpedCampos(3, "NR_DOC", "C", 0, 0, false)]
            public string NrDoc { get; set; }

            /// <summary>
            /// Total de crédito utilizado
            /// </summary>
            [SpedCampos(4, "VL_CRED_UTIL", "N", 0, 2, true)]
            public decimal VlCredUtil { get; set; }
        }

        /// <summary>
        /// REGISTRO 1300: MOVIMENTAÇÃO DIÁRIA DE COMBUSTÍVEIS
        /// </summary>
        public class Registro1300 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1300"/>.
            /// </summary>
            public Registro1300()
            {
                Reg = "1300";
            }

            /// <summary>
            /// Código do produto
            /// </summary>
            [SpedCampos(2, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            /// Data do fechamento da movimentação
            /// </summary>
            [SpedCampos(3, "DT_FECH", "N", 8, 0, true)]
            public DateTime DtFech { get; set; }

            /// <summary>
            /// Estoque no início do dia (em litros)
            /// </summary>
            [SpedCampos(4, "ESTQ_ABERT", "N", 0, 3, true)]
            public decimal EstqAbert { get; set; }

            /// <summary>
            /// Volume recebido no dia (em litros)
            /// </summary>
            [SpedCampos(5, "VOL_ENTR", "N", 0, 3, true)]
            public decimal VolEntr { get; set; }

            /// <summary>
            /// Volume disponível no dia (em litros)
            /// </summary>
            [SpedCampos(6, "VOL_DISP", "N", 0, 3, true)]
            public decimal VolDisp { get; set; }

            /// <summary>
            /// Volume total das saídas (em litros)
            /// </summary>
            [SpedCampos(7, "VOL_SAIDAS", "N", 0, 3, true)]
            public decimal VolSaidas { get; set; }

            /// <summary>
            /// Estoque escritural (em litros)
            /// </summary>
            [SpedCampos(8, "ESTQ_ESCR", "N", 0, 3, true)]
            public decimal EstqEscr { get; set; }

            /// <summary>
            /// Valor da perda (em litros)
            /// </summary>
            [SpedCampos(9, "VAL_AJ_PERDA", "N", 0, 3, true)]
            public decimal ValAjPerda { get; set; }

            /// <summary>
            /// Valor do ganho (em litros)
            /// </summary>
            [SpedCampos(10, "VAL_AJ_GANHO", "N", 0, 3, true)]
            public decimal ValAjGanho { get; set; }

            /// <summary>
            /// Estoque de fechamento (em litros)
            /// </summary>
            [SpedCampos(11, "FECH_FISICO", "N", 0, 3, true)]
            public decimal FechFisico { get; set; }
        }

        /// <summary>
        /// REGISTRO 1310: MOVIMENTAÇÃO DIÁRIA DE COMBUSTÍVEIS POR TANQUE
        /// </summary>
        public class Registro1310 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1310"/>.
            /// </summary>
            public Registro1310()
            {
                Reg = "1310";
            }

            /// <summary>
            /// Tanque que armazena o combustível
            /// </summary>
            [SpedCampos(2, "NUM_TANQUE", "C", 3, 0, true)]
            public string NumTanque { get; set; }

            /// <summary>
            /// Estoque no início do dia (em litros)
            /// </summary>
            [SpedCampos(3, "ESTQ_ABERT", "N", 0, 3, true)]
            public decimal EstqAbert { get; set; }

            /// <summary>
            /// Volume recebino no dia (em litros)
            /// </summary>
            [SpedCampos(4, "VOL_ENTR", "N", 0, 3, true)]
            public decimal VolEntr { get; set; }

            /// <summary>
            /// Volume disponível (em litros)
            /// </summary>
            [SpedCampos(5, "VOL_DISP", "N", 0, 3, true)]
            public decimal VolDisp { get; set; }

            /// <summary>
            /// Volume total das saídas (em litros)
            /// </summary>
            [SpedCampos(6, "VOL_SAIDAS", "N", 0, 3, true)]
            public decimal VolSaidas { get; set; }

            /// <summary>
            /// Estoque escritural (em litros)
            /// </summary>
            [SpedCampos(7, "ESTQ_ESCR", "N", 0, 3, true)]
            public decimal EstqEscr { get; set; }

            /// <summary>
            /// Valor da perda (em litros)
            /// </summary>
            [SpedCampos(8, "VAL_AJ_PERDA", "N", 0, 3, true)]
            public decimal ValAjPerda { get; set; }

            /// <summary>
            /// Valor do ganho (em litros)
            /// </summary>
            [SpedCampos(9, "VAL_AJ_GANHO", "N", 0, 3, true)]
            public decimal VlAjGanho { get; set; }

            /// <summary>
            /// Volume aferido no tanque, em litros. Estoque de fechamento físico do tanque
            /// </summary>
            [SpedCampos(10, "FECH_FISICO", "N", 0, 3, true)]
            public decimal FechFisico { get; set; }
        }

        /// <summary>
        /// REGISTRO 1320: VOLUME DE VENDAS
        /// </summary>
        public class Registro1320 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1320"/>.
            /// </summary>
            public Registro1320()
            {
                Reg = "1320";
            }

            /// <summary>
            /// Bico ligado à bomba
            /// </summary>
            [SpedCampos(2, "NUM_BICO", "N", 0, 0, true)]
            public long NumBico { get; set; }

            /// <summary>
            /// Número da intervenção
            /// </summary>
            [SpedCampos(3, "NR_INTERV", "N", 0, 0, false)]
            public long? NrInterv { get; set; }

            /// <summary>
            /// Motivo da intervenção
            /// </summary>
            [SpedCampos(4, "MOT_INTERV", "C", 50, 0, false)]
            public string MotInterv { get; set; }

            /// <summary>
            /// Nome do interventor
            /// </summary>
            [SpedCampos(5, "NOM_INTERV", "C", 30, 0, false)]
            public string NomInterv { get; set; }

            /// <summary>
            /// CNPJ da empresa responsável pela intervenção
            /// </summary>
            [SpedCampos(6, "CNPJ_INTERV", "N", 14, 0, false)]
            public string CnpjInterv { get; set; }

            /// <summary>
            /// CPF do técnico responsável pela intervenção
            /// </summary>
            [SpedCampos(7, "CPF_INTERV", "N", 11, 0, false)]
            public string CpfInterv { get; set; }

            /// <summary>
            /// Valor da leitura final do contador, no fechamento do bico
            /// </summary>
            [SpedCampos(8, "VAL_FECHA", "N", 0, 3, true)]
            public decimal ValFecha { get; set; }

            /// <summary>
            /// Valor da leitura inicial do contador, na abertura do bico
            /// </summary>
            [SpedCampos(9, "VAL_ABERT", "N", 0, 3, true)]
            public decimal ValAbert { get; set; }

            /// <summary>
            /// Aferições da bomba (em litros)
            /// </summary>
            [SpedCampos(10, "VOL_AFERI", "N", 0, 3, false)]
            public decimal VolAferi { get; set; }

            /// <summary>
            /// Vendas do bico (em litros)
            /// </summary>
            [SpedCampos(11, "VOL_VENDAS", "N", 0, 3, true)]
            public decimal VolVendas { get; set; }
        }

        /// <summary>
        /// REGISTRO 1350: BOMBAS
        /// </summary>
        public class Registro1350 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1350"/>.
            /// </summary>
            public Registro1350()
            {
                Reg = "1350";
            }

            /// <summary>
            /// Número de série da bomba
            /// </summary>
            [SpedCampos(2, "SERIE", "C", 0, 0, true)]
            public string Serie { get; set; }

            /// <summary>
            /// Nome do fabricante da bomba
            /// </summary>
            [SpedCampos(3, "FABRICANTE", "C", 60, 0, true)]
            public string Fabricante { get; set; }

            /// <summary>
            /// Modelo da bomba
            /// </summary>
            [SpedCampos(4, "MODELO", "C", 0, 0, true)]
            public string Modelo { get; set; }

            /// <summary>
            /// Identificador de medição: 0 - analógico; 1 - digital
            /// </summary>
            [SpedCampos(5, "TIPO_MEDICAO", "C", 1, 0, true)]
            public string TipoMedicao { get; set; }
        }

        /// <summary>
        /// REGISTRO 1360: LACRES DA BOMBA
        /// </summary>
        public class Registro1360 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1360"/>.
            /// </summary>
            public Registro1360()
            {
                Reg = "1360";
            }

            /// <summary>
            /// Número do lacre associado na bomba
            /// </summary>
            [SpedCampos(2, "NUM_LACRE", "C", 20, 0, true)]
            public string NumLacre { get; set; }

            /// <summary>
            /// Data de aplicação do lacre
            /// </summary>
            [SpedCampos(3, "DT_APLICACAO", "N", 8, 0, true)]
            public DateTime DtAplicacao { get; set; }
        }

        /// <summary>
        /// REGISTRO 1370: BICOS DA BOMBA
        /// </summary>
        public class Registro1370 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1370"/>.
            /// </summary>
            public Registro1370()
            {
                Reg = "1370";
            }

            /// <summary>
            /// Número sequencial do bico ligado a bomba
            /// </summary>
            [SpedCampos(2, "NUM_BICO", "N", 3, 0, true)]
            public int NumBico { get; set; }

            /// <summary>
            /// Código do produto
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            /// Tanque que armazena o combustível
            /// </summary>
            [SpedCampos(4, "NUM_TANQUE", "C", 3, 0, true)]
            public string NumTanque { get; set; }
        }

        /// <summary>
        /// REGISTRO 1390: CONTROLE DE PRODUÇÃO DE USINA
        /// </summary>
        public class Registro1390 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1390"/>.
            /// </summary>
            public Registro1390()
            {
                Reg = "1390";
            }

            /// <summary>
            /// 01 - Alc. Etil. Hidratado Carburante; 02 - Alc. Etil. Anidro Carburante; 03 - Açúcar
            /// </summary>
            [SpedCampos(2, "COD_PROD", "N", 2, 0, true)]
            public int CodProd { get; set; }
        }

        /// <summary>
        /// REGISTRO 1391: PRODUÇÃO DIÁRIA DA USINA
        /// </summary>
        public class Registro1391 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1391"/>.
            /// </summary>
            public Registro1391()
            {
                Reg = "1391";
            }

            /// <summary>
            /// Data de produção
            /// </summary>
            [SpedCampos(2, "DT_REGISTRO", "C", 8, 0, true)]
            public DateTime DtRegistro { get; set; }

            /// <summary>
            /// Quantidade de cana esmagada (toneladas)
            /// </summary>
            [SpedCampos(3, "QTD_MOID", "N", 0, 2, false)]
            public double? QtdMoid { get; set; }

            /// <summary>
            /// Estoque inicial (litros / Kg)
            /// </summary>
            [SpedCampos(4, "ESTQ_INI", "N", 0, 2, true)]
            public double EstqIni { get; set; }

            /// <summary>
            /// Quantidade produziada (litros / Kg)
            /// </summary>
            [SpedCampos(5, "QTD_PRODUZ", "N", 0, 2, false)]
            public double? QtdProduz { get; set; }

            /// <summary>
            /// Entrada de álcool anidro/hidratado decorrente da transformação do álcool hidratado/anidro
            /// </summary>
            [SpedCampos(6, "ENT_ANID_HID", "N", 0, 2, false)]
            public double? EntAnidHid { get; set; }

            /// <summary>
            /// Outras entradas (litros / Kg)
            /// </summary>
            [SpedCampos(7, "OUTR_ENTR", "N", 0, 2, false)]
            public double? OutrEntr { get; set; }

            /// <summary>
            /// Evaporação (litros) ou quebra de peso (Kg)
            /// </summary>
            [SpedCampos(8, "PERDA", "N", 0, 2, false)]
            public double? Perda { get; set; }

            /// <summary>
            /// Consumo (litros)
            /// </summary>
            [SpedCampos(9, "CONS", "N", 0, 2, false)]
            public double? Cons { get; set; }

            /// <summary>
            /// Saída para transformação (litros)
            /// </summary>
            [SpedCampos(10, "SAI_ANI_HID", "N", 0, 2, false)]
            public double? SaiAniHid { get; set; }

            /// <summary>
            /// Saídas (litros / Kg)
            /// </summary>
            [SpedCampos(11, "SAIDAS", "N", 0, 2, false)]
            public double? Saidas { get; set; }

            /// <summary>
            /// Estoque final (litros / Kg)
            /// </summary>
            [SpedCampos(12, "ESTQ_FIN", "N", 0, 2, true)]
            public double EstqFin { get; set; }

            /// <summary>
            /// Estoque inicial de mel residual (Kg)
            /// </summary>
            [SpedCampos(13, "ESTQ_INI_MEL", "N", 0, 2, false)]
            public double? EstqIniMel { get; set; }

            /// <summary>
            /// Produção de mel residual (Kg) e entradas de mel (Kg)
            /// </summary>
            [SpedCampos(14, "PROD_DIA_MEL", "N", 0, 2, false)]
            public double? ProdDiaMel { get; set; }

            /// <summary>
            /// Mel residual utilizado (Kg) e saídas de mel (Kg)
            /// </summary>
            [SpedCampos(15, "UTIL_MEL", "N", 0, 2, false)]
            public double? UtilMel { get; set; }

            /// <summary>
            /// Produção de álcool (litros) ou açúcar (Kg) proveniente do mel residual
            /// </summary>
            [SpedCampos(16, "PROD_ALC_MEL", "N", 0, 2, false)]
            public double? ProdAlcMel { get; set; }

            /// <summary>
            /// Observações
            /// </summary>
            [SpedCampos(17, "OBS", "C", 0, 0, false)]
            public string Obs { get; set; }
        }

        /// <summary>
        /// REGISTRO 1400: INFORMAÇÃO SOBRE VALORES AGREGADOS
        /// </summary>
        public class Registro1400 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1400"/>.
            /// </summary>
            public Registro1400()
            {
                Reg = "1400";
            }

            /// <summary>
            /// Código do item - próprio IPM ou campo 02 do Registro 0200
            /// </summary>
            [SpedCampos(2, "COD_ITEM_IPM", "C", 60, 0, true)]
            public string CodItemIpm { get; set; }

            /// <summary>
            /// Código IBGE do Município de origem/destino
            /// </summary>
            [SpedCampos(3, "MUN", "N", 7, 0, true)]
            public string Mun { get; set; }

            /// <summary>
            /// Valor mensal correspondente ao município
            /// </summary>
            [SpedCampos(4, "VALOR", "N", 0, 2, true)]
            public decimal Valor { get; set; }
        }

        /// <summary>
        /// REGISTRO 1990: ENCERRAMENTO DO BLOCO 1
        /// </summary>
        public class Registro1990 : RegistroBaseSped
        {
            /// <summary>
            /// Inicializa uma nova instância da classe <see cref="Registro1990"/>.
            /// </summary>
            public Registro1990()
            {
                Reg = "1990";
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 1.
            /// </summary>
            [SpedCampos(2, "QTD_LIN_1", "N", 0, 0, true)]
            public int QtdLin1 { get; set; }
        }
    }
}

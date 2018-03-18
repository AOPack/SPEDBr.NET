using System;
using System.Collections.Generic;
using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    ///     BLOCO K: CONTROLE DA PRODUÇÃO E DO ESTOQUE
    /// </summary>
    public class BlocoK
    {
        public RegistroK001 RegK001 { get; set; }

        /// <summary>
        ///     REGISTRO K001: ABERTURA DO BLOCO K
        /// </summary>
        public class RegistroK001 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK001" />.
            /// </summary>
            public RegistroK001()
            {
                Reg = "K001";
            }

            /// <summary>
            ///     Indicador de movimento
            /// </summary>
            /// <remarks>
            ///     0 - Bloco com dados informados
            ///     <para />
            ///     1 - Bloco sem dados informados
            /// </remarks>
            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public IndMovimento IndMov { get; set; }

            public List<RegistroK100> RegK100s { get; set; }
        }

        /// <summary>
        ///     REGISTRO K100: PERÍODO DE APURAÇÃO DO ICMS/IPI
        /// </summary>
        public class RegistroK100 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK100" />.
            /// </summary>
            public RegistroK100()
            {
                Reg = "K100";
            }

            /// <summary>
            ///     Data inicial a que a apuração se refere
            /// </summary>
            [SpedCampos(2, "DT_INI", "N", 8, 0, true)]
            public DateTime DtIni { get; set; }

            /// <summary>
            ///     Data final a que a apuração se refere
            /// </summary>
            [SpedCampos(3, "DT_FIN", "N", 8, 0, true)]
            public DateTime DtFin { get; set; }

            public List<RegistroK200> RegK200s { get; set; }
            public List<RegistroK210> RegK210s { get; set; }
            public List<RegistroK220> RegK220s { get; set; }
            public List<RegistroK230> RegK230s { get; set; }        
            public List<RegistroK250> RegK250s { get; set; }
            public List<RegistroK260> RegK260s { get; set; }
            public List<RegistroK270> RegK270s { get; set; }
            public List<RegistroK280> RegK280s { get; set; }
        }

        /// <summary>
        ///     REGISTRO K200: ESTOQUE ESCRITURADO
        /// </summary>
        public class RegistroK200 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK200" />.
            /// </summary>
            public RegistroK200()
            {
                Reg = "K200";
            }

            /// <summary>
            ///     Data do estoque final
            /// </summary>
            [SpedCampos(2, "DT_EST", "N", 8, 0, true)]
            public DateTime DtEst { get; set; }

            /// <summary>
            ///     Código do item
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Quantidade em estoque
            /// </summary>
            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            /// <summary>
            ///     Indicador do tipo de estoque
            /// </summary>
            /// <remarks>
            ///     0 - Estoque de propriedade do informante e em seu poder
            ///     <para />
            ///     1 - Estoque de propriedade do informante e em posse de terceiros
            ///     <para />
            ///     2 - Estoque de propriedade de terceiros e em posse do informante
            /// </remarks>
            [SpedCampos(5, "IND_EST", "C", 1, 0, true)]
            public int IndEst { get; set; }

            /// <summary>
            ///     Código do participante
            /// </summary>
            /// <remarks>
            ///     - proprietário/possuidor que não seja o informante do arquivo
            /// </remarks>
            [SpedCampos(6, "COD_PART", "C", 60, 0, false)]
            public string CodPart { get; set; }
        }

        public class RegistroK210 : RegistroBaseSped
        {

            public List<RegistroK215> RegK215s { get; set; }
        }

        public class RegistroK215: RegistroBaseSped
        {

        }

        /// <summary>
        ///     REGISTRO K220: OUTRAS MOVIMENTAÇÕES INTERNAS ENTRE MERCADORIAS
        /// </summary>
        public class RegistroK220 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK220" />.
            /// </summary>
            public RegistroK220()
            {
                Reg = "K220";
            }

            /// <summary>
            ///     Data da movimentação interna
            /// </summary>
            [SpedCampos(2, "DT_MOV", "N", 8, 0, true)]
            public DateTime DtMov { get; set; }

            /// <summary>
            ///     Código do item de origem
            /// </summary>
            [SpedCampos(3, "COD_ITEM_ORI", "C", 60, 0, true)]
            public string CodItemOri { get; set; }

            /// <summary>
            ///     Código do item de destino
            /// </summary>
            [SpedCampos(4, "COD_ITEM_DEST", "C", 60, 0, true)]
            public string CodItemDest { get; set; }

            /// <summary>
            ///     Quantidade movimentada
            /// </summary>
            [SpedCampos(5, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            /// <summary>
            ///     Quantidade movimentada do item de destino
            ///     Guia Prático EFD-ICMS/IPI – Versão 2.0.21
            ///     Atualização: 22/08/2017
            /// </summary>
            [SpedCampos(6, "QTD_DEST", "N", 3, 0, false)]
            public string QtdDest { get; set; }
        }

        /// <summary>
        ///     REGISTRO K230: ITENS PRODUZIDOS
        /// </summary>
        public class RegistroK230 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK230" />.
            /// </summary>
            public RegistroK230()
            {
                Reg = "K230";
            }

            /// <summary>
            ///     Data de início da ordem de produção
            /// </summary>
            [SpedCampos(2, "DT_INI_OP", "N", 8, 0, false)]
            public DateTime DtIniOp { get; set; }

            /// <summary>
            ///     Data de conclusão da ordem de produção
            /// </summary>
            [SpedCampos(3, "DT_FIN_OP", "N", 8, 0, false)]
            public DateTime DtFinOp { get; set; }

            /// <summary>
            ///     Código de identificação da ordem de produção
            /// </summary>
            [SpedCampos(4, "COD_DOC_OP", "C", 30, 0, false)]
            public string CodDocOp { get; set; }

            /// <summary>
            ///     Código do item produzido
            /// </summary>
            [SpedCampos(5, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Quantidade de produção acabada
            /// </summary>
            [SpedCampos(6, "QTD_ENC", "N", 0, 3, true)]
            public decimal QtdEnc { get; set; }

            public List<RegistroK235> RegK235s { get; set; }
        }

        /// <summary>
        ///     REGISTRO K235: INSUMOS CONSUMIDOS
        /// </summary>
        public class RegistroK235 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK235" />.
            /// </summary>
            public RegistroK235()
            {
                Reg = "K235";
            }

            /// <summary>
            ///     Data de saída do estoque para alocação ao produto
            /// </summary>
            [SpedCampos(2, "DT_SAÍDA", "N", 8, 0, true)]
            public DateTime DtSaida { get; set; }

            /// <summary>
            ///     Código do item componente/insumo
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Quantidade consumida do item
            /// </summary>
            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            /// <summary>
            ///     Código do insumo que foi substituído, caso ocorra a substituição
            /// </summary>
            [SpedCampos(5, "COD_INS_SUBST", "C", 60, 0, false)]
            public string CodInsSubst { get; set; }
        }

        /// <summary>
        ///     REGISTRO K250: INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS - ITENS PRODUZIDOS
        /// </summary>
        public class RegistroK250 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK250" />.
            /// </summary>
            public RegistroK250()
            {
                Reg = "K250";
            }

            /// <summary>
            ///     Data do reconhecimento da produção ocorrida no terceiro
            /// </summary>
            [SpedCampos(2, "DT_PROD", "N", 8, 0, true)]
            public DateTime DtProd { get; set; }

            /// <summary>
            ///     Código do item produzido
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Quantidade produzida
            /// </summary>
            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            public List<RegistroK250> RegK255s { get; set; }
        }

        /// <summary>
        ///     REGISTRO K255: INDUSTRIALIZAÇÃO EM TERCEIROS - INSUMOS CONSUMIDOS
        /// </summary>
        public class RegistroK255 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK255" />.
            /// </summary>
            public RegistroK255()
            {
                Reg = "K255";
            }

            /// <summary>
            ///     Data do reconhecimento do consumo do insumo referente ao produto informado no campo 04 do Registro K250
            /// </summary>
            [SpedCampos(2, "DT_CONS", "N", 8, 0, true)]
            public DateTime DtCons { get; set; }

            /// <summary>
            ///     Código do insumo
            /// </summary>
            [SpedCampos(3, "COD_ITEM", "C", 60, 0, true)]
            public string CodItem { get; set; }

            /// <summary>
            ///     Quantidade de consumo do insumo
            /// </summary>
            [SpedCampos(4, "QTD", "N", 0, 3, true)]
            public decimal Qtd { get; set; }

            /// <summary>
            ///     Código do insumo que foi substituído, caso ocorra a substituição
            /// </summary>
            [SpedCampos(5, "COD_INS_SUBST", "C", 60, 0, false)]
            public string CodInsSubst { get; set; }
        }

        public class RegistroK260 : RegistroBaseSped
        {
            public List<RegistroK265> RegK265s { get; set; }
        }

        public class RegistroK265 : RegistroBaseSped
        {

        }

        public class RegistroK270 : RegistroBaseSped
        {
            public List<RegistroK275> RegK265s { get; set; }
        }

        public class RegistroK275 : RegistroBaseSped
        {

        }

        public class RegistroK280 : RegistroBaseSped
        {

        }

        /// <summary>
        ///     REGISTRO K990: ENCERRAMENTO DO BLOCO K
        /// </summary>
        public class RegistroK990 : RegistroBaseSped
        {
            /// <summary>
            ///     Inicializa uma nova instância da classe <see cref="RegistroK990" />.
            /// </summary>
            public RegistroK990()
            {
                Reg = "K990";
            }

            /// <summary>
            ///     Quantidade total de linhas do Bloco K
            /// </summary>
            [SpedCampos(2, "QTD_LIN_K", "N", int.MaxValue, 0, true)]
            public int QtdLinK { get; set; }
        }
    }
}
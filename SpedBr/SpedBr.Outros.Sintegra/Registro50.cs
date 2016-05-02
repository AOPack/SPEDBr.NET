using System;
using System.Collections.Generic;
using System.Linq;
using SpedBr.Common;

namespace SpedBr.Outros.Sintegra
{
    public class Registro50
    {
        #region Propriedades

        private string TIPO
        {
            get { return "50"; }
        }

        public string CNPJ { get; set; }

        public string IE { get; set; }

        public DateTime DATA_EMISSAO_RECEBIMENTO { get; set; }

        public string UF { get; set; }

        public string MODELO { get; set; }

        public string SERIE { get; set; }

        public int NUMERO_NOTA_FISCAL { get; set; }

        public int CFOP { get; set; }

        /// <summary>
        /// P - Próprio ou T - Terceiros
        /// </summary>
        public string EMITENTE { get; set; }

        public decimal VALOR_TOTAL { get; set; }

        public decimal BASE_CALC_ICMS { get; set; }

        public decimal VALOR_ICMS { get; set; }

        public decimal VALOR_ISENTA_NTRIBUT { get; set; }

        public decimal OUTRAS { get; set; }

        public decimal ALIQUOTA { get; set; }

        public string SITUACAO { get; set; }

        #endregion

        /// <summary>
        /// Efetua a escrita dos Registros Tipo 50 do arquivo.
        /// </summary>
        /// <param name="notasFiscais"></param>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <param name="validarCampos">true ou false para realizar a validação dos dados.</param>
        /// <returns>String</returns>
        public List<string> EscreverRegistro50(List<Registro50> notasFiscais, DateTime dtInicial, DateTime dtFinal,bool validarCampos = true)
        {
            if (validarCampos)
            {
                // Validar campos
            }

            notasFiscais =
                notasFiscais
                .Where(wh => wh.DATA_EMISSAO_RECEBIMENTO >= dtInicial && wh.DATA_EMISSAO_RECEBIMENTO <= dtFinal)
                .OrderBy(ob => ob.DATA_EMISSAO_RECEBIMENTO)
                .ThenBy(tb => tb.MODELO)
                .ThenBy(tb => tb.SERIE)
                .ThenBy(tb => tb.NUMERO_NOTA_FISCAL)
                .ToList();

            var listRet = new List<string>();

            foreach (var nf in notasFiscais)
            {
                var r50 = new string(' ', 126);
                try
                {
                    r50 = r50.PreencherValorNaLinha(1, 2, nf.TIPO);
                    r50 = r50.PreencherValorNaLinha(3, 16, nf.CNPJ.PadLeft(14, '0'));
                    r50 = r50.PreencherValorNaLinha(17, 30, nf.IE.PadRight(14, ' '));
                    r50 = r50.PreencherValorNaLinha(31, 38, nf.DATA_EMISSAO_RECEBIMENTO.ToString("yyyyMMdd"));
                    r50 = r50.PreencherValorNaLinha(39, 40, nf.UF.PadLeft(2, '0'));
                    r50 = r50.PreencherValorNaLinha(41, 42, nf.MODELO.PadLeft(2, '0'));
                    r50 = r50.PreencherValorNaLinha(43, 45, nf.SERIE.PadRight(3, ' '));
                    r50 = r50.PreencherValorNaLinha(46, 51, nf.NUMERO_NOTA_FISCAL.ToString().Length > 6 
                        ? nf.NUMERO_NOTA_FISCAL.ToString().Substring(nf.NUMERO_NOTA_FISCAL.ToString().Length - 6, 6) 
                        : nf.NUMERO_NOTA_FISCAL.ToString().PadLeft(6, '0'));
                    r50 = r50.PreencherValorNaLinha(52, 55, nf.CFOP.ToString());
                    r50 = r50.PreencherValorNaLinha(56, 56, nf.EMITENTE);
                    r50 = r50.PreencherValorNaLinha(57, 69, Math.Round(nf.VALOR_TOTAL, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r50 = r50.PreencherValorNaLinha(70, 82, Math.Round(nf.BASE_CALC_ICMS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r50 = r50.PreencherValorNaLinha(83, 95, Math.Round(nf.VALOR_ICMS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r50 = r50.PreencherValorNaLinha(96, 108, Math.Round(nf.VALOR_ISENTA_NTRIBUT, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r50 = r50.PreencherValorNaLinha(109, 121, Math.Round(nf.OUTRAS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r50 = r50.PreencherValorNaLinha(122, 125, nf.ALIQUOTA.ToString("f").Replace(".", "").Replace(",", "").PadRight(4, '0'));
                    r50 = r50.PreencherValorNaLinha(126, 126, nf.SITUACAO);

                    listRet.Add(r50);
                }
                catch (Exception e)
                {
                    throw new Exception("Falha ao gerar registro tipo 50." + Environment.NewLine + e.Message);
                }
            }

            return listRet;
        }
    }
}

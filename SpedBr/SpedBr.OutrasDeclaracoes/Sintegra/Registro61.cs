using System;
using System.Collections.Generic;
using System.Linq;
using SpedBr.Common;

namespace SpedBr.OutrasDeclaracoes.Sintegra
{
    public class Registro61
    {
        #region Propriedades

        private string TIPO
        {
            get { return "61"; }
        }

        public DateTime DATA_EMISSAO { get; set; }

        public string MODELO { get; set; }

        public string SERIE { get; set; }

        public string SUBSERIE { get; set; }

        public int NRO_ORDEM { get; set; }

        public int NRO_INICIAL_ORDEM { get; set; }

        public int NRO_FINAL_ORDEM { get; set; }

        public decimal VALOR_TOTAL { get; set; }

        public decimal BASE_CALC_ICMS { get; set; }

        public decimal VALOR_ICMS { get; set; }

        public decimal VALOR_ISENTA_NTRIBUT { get; set; }

        public decimal OUTRAS { get; set; }

        public decimal ALIQUOTA { get; set; }

        #endregion

        /// <summary>
        /// Efetua a escrita dos Registros Tipo 61 do arquivo.
        /// </summary>
        /// <param name="notasConsumidor"></param>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <param name="agruparNumerosDocumento"></param>
        /// <param name="validarCampos">true ou false para realizar a validação dos dados.</param>
        /// <returns>String</returns>
        public List<string> EscreverRegistro61(List<Registro61> notasConsumidor, DateTime dtInicial, DateTime dtFinal, bool agruparNumerosDocumento = true, bool validarCampos = true)
        {
            if (validarCampos)
            {
                // Validar campos
            }

            notasConsumidor =
                notasConsumidor
                .Where(wh => wh.DATA_EMISSAO >= dtInicial && wh.DATA_EMISSAO <= dtFinal)
                .OrderBy(ob => ob.DATA_EMISSAO)
                .ThenBy(tb => tb.MODELO)
                .ThenBy(tb => tb.SERIE)
                .ThenBy(tb => tb.NRO_ORDEM)
                .ToList();

            var notasConsumidorUtilizar = new List<Registro61>();

            if (agruparNumerosDocumento)
            {
                foreach (var nfc in notasConsumidor)
                {
                    var dataAtual = nfc.DATA_EMISSAO;
                    var modeloAtual = nfc.MODELO;
                    var serieAtual = nfc.SERIE;
                    var aliquotaAtual = nfc.ALIQUOTA;
                    
                    var listaSomenteLancamentosDms = notasConsumidor
                        .Where(wh => wh.DATA_EMISSAO == dataAtual)
                        .Where(wh => wh.MODELO == modeloAtual)
                        .Where(wh => wh.SERIE == serieAtual)
                        .Where(wh => wh.ALIQUOTA == aliquotaAtual)
                        .ToList();

                    bool contemRegistroAtual = notasConsumidorUtilizar
                        .Count(ct => ct.DATA_EMISSAO == nfc.DATA_EMISSAO) > 0;

                    // TODO: Voltar aqui depois...
                    if (contemRegistroAtual)
                        Console.WriteLine("Registro 61 já adicionado...");
                    else
                        notasConsumidorUtilizar.Add(new Registro61()
                        {
                            DATA_EMISSAO = nfc.DATA_EMISSAO,
                            MODELO = nfc.MODELO,
                            SERIE = nfc.SERIE,
                            SUBSERIE = nfc.SUBSERIE,
                            NRO_INICIAL_ORDEM = listaSomenteLancamentosDms.Min(min => min.NRO_ORDEM),
                            NRO_FINAL_ORDEM = listaSomenteLancamentosDms.Max(max => max.NRO_ORDEM),
                            VALOR_TOTAL = listaSomenteLancamentosDms.Sum(sum => sum.VALOR_TOTAL),
                            BASE_CALC_ICMS = listaSomenteLancamentosDms.Sum(sum => sum.BASE_CALC_ICMS),
                            VALOR_ICMS = listaSomenteLancamentosDms.Sum(sum => sum.VALOR_ICMS),
                            VALOR_ISENTA_NTRIBUT = listaSomenteLancamentosDms.Sum(sum => sum.VALOR_ISENTA_NTRIBUT),
                            OUTRAS = listaSomenteLancamentosDms.Sum(sum => sum.OUTRAS),
                            ALIQUOTA = nfc.ALIQUOTA,
                        });
                }
            }
            else
            {
                notasConsumidorUtilizar = notasConsumidor;
            }

            var listRet = new List<string>();

            foreach (var nfc in notasConsumidorUtilizar)
            {
                var r61 = new string(' ', 126);
                try
                {
                    r61 = r61.PreencherValorNaLinha(1, 2, nfc.TIPO);
                    r61 = r61.PreencherValorNaLinha(3, 16, new string(' ', 14));
                    r61 = r61.PreencherValorNaLinha(17, 30, new string(' ', 14));
                    r61 = r61.PreencherValorNaLinha(31, 38, nfc.DATA_EMISSAO.ToString("yyyyMMdd"));
                    r61 = r61.PreencherValorNaLinha(39, 40, nfc.MODELO.PadLeft(2, '0'));
                    r61 = r61.PreencherValorNaLinha(41, 43, nfc.SERIE.PadRight(3, ' '));
                    r61 = r61.PreencherValorNaLinha(44, 45, nfc.SUBSERIE.PadRight(2, ' '));
                    r61 = r61.PreencherValorNaLinha(46, 51, agruparNumerosDocumento ? nfc.NRO_INICIAL_ORDEM.ToString().PadLeft(6, '0') : nfc.NRO_ORDEM.ToString().PadLeft(6, '0'));
                    r61 = r61.PreencherValorNaLinha(52, 57, agruparNumerosDocumento ? nfc.NRO_FINAL_ORDEM.ToString().PadLeft(6, '0') : nfc.NRO_ORDEM.ToString().PadLeft(6, '0'));
                    r61 = r61.PreencherValorNaLinha(58, 70, Math.Round(nfc.VALOR_TOTAL, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r61 = r61.PreencherValorNaLinha(71, 83, Math.Round(nfc.BASE_CALC_ICMS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r61 = r61.PreencherValorNaLinha(84, 95, Math.Round(nfc.VALOR_ICMS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(12, '0'));
                    r61 = r61.PreencherValorNaLinha(96, 108, Math.Round(nfc.VALOR_ISENTA_NTRIBUT, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r61 = r61.PreencherValorNaLinha(109, 121, Math.Round(nfc.OUTRAS, 2).ToString("f").Replace(".", "").Replace(",", "").PadLeft(13, '0'));
                    r61 = r61.PreencherValorNaLinha(122, 125, nfc.ALIQUOTA.ToString("f").Replace(".", "").Replace(",", "").PadRight(4, '0'));
                    r61 = r61.PreencherValorNaLinha(126, 126, new string(' ', 1));

                    listRet.Add(r61);
                }
                catch (Exception e)
                {
                    throw new Exception("Falha ao gerar registro tipo 61." + Environment.NewLine + e.Message);
                }
            }

            return listRet;
        }
    }
}

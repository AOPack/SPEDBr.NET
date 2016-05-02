using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpedBr.Outros.Dimob;

namespace SpedBr.Tests
{
    [TestClass]
    public class DimobUnitTest
    {
        [TestMethod]
        public void EscreverR01()
        {
            var anoAtual = DateTime.Now.Year;

            var linhaDimobR01 = new List<string>();

            var r01 = new DimobR01
            {
                CnpjDeclarante = "01.234.567/0008-99",
                AnoCalendario = anoAtual,
                DeclaracaoRetificadora = 0,
                SituacaoEspecial = 0,
                NomeEmpresarial = "EMPRESA TESTE 123 LTDA",
                CpfResponsavelEmpresa = "012.345.678-90",
                EnderecoCompleto = "R 01 NRO 1001 DISTRITO NOVO MUNDO",
                UfContribuinte = "GO",
                CodigoMunicipio = 9289
            };

            linhaDimobR01.Add(r01.EscreverCampos());

            //var nomeArquivo =
            //    $"{"DIMOB_"}" +
            //    $"{DateTime.Now.Year.ToString("00")}" +
            //    $"{DateTime.Now.Month.ToString("00")}" +
            //    $"{DateTime.Now.Day.ToString("00")}_" +
            //    $"{DateTime.Now.Hour.ToString("00")}" +
            //    $"{DateTime.Now.Minute.ToString("00")}" +
            //    $"{DateTime.Now.Second.ToString("00")}" +
            //    $"{DateTime.Now.Millisecond.ToString("000")}.txt";

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //var pathArquivo = Path.Combine(path, nomeArquivo);

            //File.WriteAllLines(pathArquivo, linhaDimobR01.ToArray());
        }
    }
}

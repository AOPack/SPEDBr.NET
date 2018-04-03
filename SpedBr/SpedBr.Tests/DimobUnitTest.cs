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
        public void EscreverDimob()
        {
            var listaContratos =
                new List<Tuple<string, int, int, string, string, string, DateTime>>();

            var tuple1 = new Tuple<string, int, int, string, string, string, DateTime>("29358139000193", 2017, 99999,
                "01234567890", "Samuel Oliveira", "201799", new DateTime(2017, 02, 15));

            listaContratos.Add(tuple1);

            var tuple2 = new Tuple<string, int, int, string, string, string, DateTime>("29358139000193", 2017, 00001,
                "01234567890", "Samuel Oliveira", "201701", new DateTime(2017, 05, 25));

            listaContratos.Add(tuple2);

            var anoAtual = DateTime.Now.AddYears(-1).Year;

            var linhasDimob = new List<string>();

            var header = new DimobHeader();

            linhasDimob.Add(header.EscreverCampos());

            var r01 = new DimobR01
            {
                CnpjDeclarante = "29358139000193",
                AnoCalendario = anoAtual,
                DeclaracaoRetificadora = 0,
                SituacaoEspecial = 0,
                NomeEmpresarial = "EMPRESA TESTE 123 LTDA",
                CpfResponsavelEmpresa = "01234567890",
                EnderecoCompleto = "R 01 NRO 1001 DISTRITO NOVO MUNDO",
                UfContribuinte = "GO",
                CodigoMunicipio = 9289
            };

            linhasDimob.Add(r01.EscreverCampos());


            //var linhasDimobR03 = new List<string>();

            foreach (var contrato in listaContratos)
            {
                var r03 = new DimobR03
                {
                    CnpjDeclarante = contrato.Item1,
                    AnoCalendario = contrato.Item2,
                    SequencialLocacao = contrato.Item3,
                    CpfCnpjComprador = contrato.Item4,
                    NomeComprador = contrato.Item5,
                    NumeroContrato = contrato.Item6,
                    DataContrato = contrato.Item7,
                    ValorOperacao = 20000m,
                    ValorPagoAno = 20000m,
                    TipoImovel = "U",
                    EnderecoImovel = "221B Baker Street",
                    Cep = "75690000",
                    CodigoMunicipio = 9289,
                    Uf = "GO",
                };

                linhasDimob.Add(r03.EscreverCampos());
            }

            var t9 = new DimobT9();

            linhasDimob.Add(t9.EscreverCampos());

            Assert.IsNotNull(linhasDimob);

            var nomeArquivo =
                string.Format(
                    "DIMOB_" +
                    "{0}" +
                    "{1}" +
                    "{2}_" +
                    "{3}" +
                    "{4}" +
                    "{5}" +
                    "{6}.txt",
                    DateTime.Now.Year.ToString("00"),
                    DateTime.Now.Month.ToString("00"),
                    DateTime.Now.Day.ToString("00"),
                    DateTime.Now.Hour.ToString("00"),
                    DateTime.Now.Minute.ToString("00"),
                    DateTime.Now.Second.ToString("00"),
                    DateTime.Now.Millisecond.ToString("000"));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var pathArquivo = Path.Combine(path, nomeArquivo);

            File.WriteAllLines(pathArquivo, linhasDimob.ToArray());
        }
    }
}

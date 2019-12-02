using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpedBr.Common;
using SpedBr.EfdContribuicoes;

namespace SpedBr.Tests.EfdContribuicoes
{
    [TestClass]
    public class EfdContribuicoesUnitTest
    {
        [TestMethod]
        public void Escrever0110()
        {
            var reg0110 = new Bloco0.Registro0110
            {
                CodIncTrib = 2, // Lucro Presumido
                IndRegCum = 1 // Regime Caixa
            };

            var expected = "|0110|2|||1|";

            var result = reg0110.EscreverCampos(true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Escrever1800()
        {
            var reg1800 = new Bloco1.Registro1800();

            reg1800.IncImob = "";
        }

        [TestMethod]
        public void EscreverF600()
        {

            var regF600 = new BlocoF.RegistroF600();

            regF600.IndNatRet = 3;
            regF600.DtRet = DateTime.Today;
            regF600.Cnpj = "00394460005887"; // CNPJ da Receita Federal do Brasil (Filial de Brasília)

            var todayToString = DateTime.Today.ToShortDateString().Replace("/", string.Empty);
            var expected = string.Format("|F600|03|{0}|0,0000|0,00|||00394460005887|0,00|0,00|0|", todayToString);

            var result = regF600.EscreverCampos(true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EscreverM400()
        {
            var regM400 = new BlocoM.RegistroM400
            {
                CstPis = 1,
                VlTotRec = 1358.13M,
                CodCta = "2.01.01.05.01", // PIS A RECOLHER
                DescCompl = "[TESTE] REGISTRO M400"
            };

            var expected = "|M400|01|1358,13|2.01.01.05.01|[TESTE] REGISTRO M400|";

            var result = regM400.EscreverCampos(true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EscreverM800()
        {
            var regM800 = new BlocoM.RegistroM800
            {
                CstCofins = 1,
                VlTotRec = 6268.29M,
                CodCta = "2.01.01.05.02", // COFINS A RECOLHER
                DescCompl = "[TESTE] REGISTRO M800"
            };

            var expected = "|M800|01|6268,29|2.01.01.05.02|[TESTE] REGISTRO M800|";

            var result = regM800.EscreverCampos(true);

            Assert.AreEqual(expected, result);
        }
    }
}

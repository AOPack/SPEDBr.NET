using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpedBr.Common;

namespace SpedBr.Tests
{
    [TestClass]
    public class SpedFiscalUnitTest
    {
        [TestMethod]
        public void EscreverBloco0()
        {
            // SPED Fiscal
            var reg0000 = new SpedFiscal.Bloco0.Registro0000();

            reg0000.Cnpj = "01.234.567/0008-99";
            
            var result = reg0000.EscreverCampos(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
        }

        [TestMethod]
        public void EscreverBloco0ComIndMov()
        {
            var reg0001 = new SpedFiscal.Bloco0.Registro0001();

            reg0001.IndMov = IndMovimento.BlocoSemDados;

            var result = reg0001.EscreverCampos(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));

            Assert.AreEqual("|0001|1|", result.ToStringSafe());
        }

        [TestMethod]
        public void EscreverBloco1ComEnum()
        {
            var reg1001 = new SpedFiscal.Bloco1.Registro1001();

            reg1001.IndMov = IndMovimento.BlocoComDados;

            var result = reg1001.EscreverCampos(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));

            Assert.AreEqual("|1001|0|", result.ToStringSafe());
        }

        [TestMethod]
        public void EscreverBloco1ComEnumLiteral()
        {
            var reg1010 = new SpedFiscal.Bloco1.Registro1010();

            reg1010.IndAer = SimOuNao.N;
            reg1010.IndExp = SimOuNao.S;

            var result = reg1010.EscreverCampos(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));

            Assert.AreEqual("|1010|S|N|N|N|N|N|N|N|N|", result.ToStringSafe());
        }
    }
}

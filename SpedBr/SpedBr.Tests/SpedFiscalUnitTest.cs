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

            reg0000.CodVer = 1;
            reg0000.CodFin = IndCodFinalidadeArquivo.RemessaArquivoOriginal;
            reg0000.DtIni = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            reg0000.DtFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ObterUltimoDiaMesAtual();
            reg0000.Nome = "EMPRESA ABC LTDA - ME";
            reg0000.Cnpj = "01.234.567/0008-99";
            reg0000.Uf = "GO";
            // I.E.
            reg0000.CodMun = "5204508"; // Caldas Novas
            reg0000.Im = "";
            // Suframa
            reg0000.IndPerfil = IndPerfilArquivo.A;
            reg0000.IndAtiv = IndTipoAtividade.Outros;

            string errosEncontrados = string.Empty;

            var result = reg0000.EscreverCampos(out errosEncontrados);
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

        [TestMethod]
        public void EscreverBlocoDRegistro100CTeCancelada()
        {
            var regd100 = new SpedFiscal.BlocoD.RegistroD100
            {
                IndOper = 1,
                IndEmit = 0,
                CodMod = "57",
                CodSit = 02,
                Ser = "2",
                Sub = "2",
                NumDoc = "49",
                ChvCte = "35180102102588000110570020000000491284782639"
            };

            
            var result = regd100.EscreverCampos();
            
            Assert.AreEqual("|D100|1|0||57|02|2|2|49|35180102102588000110570020000000491284782639||||||||||||||||", result.ToStringSafe());
        }

        [TestMethod]
        public void EscreverBlocoDRegistro100CTeInutilizacao()
        {
            var regd100 = new SpedFiscal.BlocoD.RegistroD100
            {
                IndOper = 1,
                IndEmit = 0,
                CodMod = "57",
                CodSit = 02,
                Ser = "2",
                Sub = "2",
                NumDoc = "999"
            };


            var result = regd100.EscreverCampos();
            Assert.AreEqual("|D100|1|0||57|02|2|2|999|||||||||||||||||", result.ToStringSafe());
        }

        [TestMethod]
        public void EscreverBlocoERegistro116()
        {
            var regE116 = new SpedFiscal.BlocoE.RegistroE116
            {
                CodOr = "9",
                VlOr = 999.99m,
                DtVcto = new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, 10),
                CodRec = "1234",
                MesRef = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };

            var result = regE116.EscreverCampos();
            //Assert.AreEqual("|D100|1|0||57|02|2|2|999|||||||||||||||||", result.ToStringSafe());
        }
    }
}

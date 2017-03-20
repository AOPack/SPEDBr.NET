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
        public void EscreverF600()
        {

            var regF600 = new BlocoF.RegistroF600();

            regF600.Cnpj = "00394460005887"; // CNPJ da Receita Federal do Brasil (Filial de Brasília)

            var result = regF600.EscreverCampos(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
        }
    }
}

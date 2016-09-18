using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpedBr.Common;
using SpedBr.SpedFiscal;

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
    }
}

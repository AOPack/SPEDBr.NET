using SpedBr.Common;

namespace SpedBr.SpedFiscal
{
    public static class LerCamposSpedFiscal
    {
        public static SpedFiscalFile ParserSpedFiscalFile(string filePath)
        {
            var linesToProcess = LerCamposSped.DecodeSpedFile(filePath);

            var spedToReturn = new SpedFiscalFile { Lines = linesToProcess };

            var count = 0;

            // Lê linha por linha
            foreach (var actualLine in spedToReturn.Lines)
            {
                count++;

                var blockCode = SpedBr.Common.LerCamposSped.ReturnPosition(actualLine, 1);
                /*
                switch (blockCode)
                {
                    //case "0000":
                    //    spedToReturn.R0000 = new SpedFiscal.Bloco0.Registro0000(actualLine);
                    //    break;
                    case "C100":
                        spedToReturn.C100s.Add(new SpedFiscal.BlocoC.RegistroC100(actualLine));
                        break;
                }
                */
            }

            return spedToReturn;
        }
    }
}

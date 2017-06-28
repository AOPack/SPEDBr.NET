﻿using SpedBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoI
    {
        public class RegistroI001 : RegistroBaseSped
        {
            public RegistroI001()
            {
                Reg = "I001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public IndMovimento IndMov { get; set; }
        }

        public class RegistroI990 : RegistroBaseSped
        {
            public RegistroI990()
            {
                Reg = "I990";
            }

            [SpedCampos(2, "QTD_LIN_I", "N", 0, 0, true)]
            public int QtdLinI { get; set; }
        }
    }
}

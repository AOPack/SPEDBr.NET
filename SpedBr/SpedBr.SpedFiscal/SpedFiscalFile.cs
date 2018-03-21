using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpedBr.SpedFiscal
{
    public class SpedFiscalFile
    {
        public SpedFiscalFile()
        {
            Lines = new List<string>();
            C100s = new List<BlocoC.RegistroC100>();
        }

        public List<string> Lines { get; set; }

        public Bloco0.Registro0000 R0000 { get; set; }

        public List<BlocoC.RegistroC100> C100s { get; set; }
    }

    #region Maybe...

    public class DocumentoFiscal1
    {
        public BlocoC.RegistroC100 C100 { get; set; }

        public BlocoC.RegistroC101 C101 { get; set; }

        public BlocoC.RegistroC105 C105 { get; set; }

        public List<BlocoC.RegistroC110> C110 { get; set; }

        public List<BlocoC.RegistroC111> C111 { get; set; }

        public List<BlocoC.RegistroC112> C112 { get; set; }

        public List<BlocoC.RegistroC113> C113 { get; set; }

        public List<BlocoC.RegistroC114> C114 { get; set; }

        public List<BlocoC.RegistroC115> C115 { get; set; }

        public List<BlocoC.RegistroC116> C116 { get; set; }

        public List<BlocoC.RegistroC120> C120 { get; set; }

        public BlocoC.RegistroC130 C130 { get; set; }

        public BlocoC.RegistroC140 C140 { get; set; }

        public List<BlocoC.RegistroC141> C141 { get; set; }

        public BlocoC.RegistroC160 C160 { get; set; }

        public List<BlocoC.RegistroC165> C165 { get; set; }

        public List<BlocoC.RegistroC170> C170 { get; set; }

        public List<BlocoC.RegistroC171> C171 { get; set; }

        public BlocoC.RegistroC172 C172 { get; set; }

        public List<BlocoC.RegistroC173> C173 { get; set; }

        public List<BlocoC.RegistroC174> C174 { get; set; }

        public List<BlocoC.RegistroC175> C175 { get; set; }

        public List<BlocoC.RegistroC176> C176 { get; set; }

        public BlocoC.RegistroC177 C177 { get; set; }

        public BlocoC.RegistroC178 C178 { get; set; }

        public BlocoC.RegistroC179 C179 { get; set; }

        public List<BlocoC.RegistroC190> C190 { get; set; }

        public List<BlocoC.RegistroC195> C195 { get; set; }

        public List<BlocoC.RegistroC197> C197 { get; set; }
    }

    #endregion Maybe...
}

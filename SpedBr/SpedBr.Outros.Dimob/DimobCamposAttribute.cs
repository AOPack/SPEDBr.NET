using System;

namespace SpedBr.Outros.Dimob
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DimobCamposAttribute : Attribute
    {
        public DimobCamposAttribute(int ordem, string campo, int inicio, int fim, int tamanho, string formato)
        {
            OrdemAtt = ordem;
            CampoAtt = campo;
            InicioAtt = inicio;
            FimAtt = fim;
            TamanhoAtt = tamanho;
            FormatoAtt = formato;
        }

        protected int OrdemAtt;

        public int Ordem => OrdemAtt;

        protected string CampoAtt;

        public string Campo => CampoAtt;

        protected int InicioAtt;

        public int Inicio => InicioAtt;

        protected int FimAtt;

        public int Fim => FimAtt;

        protected int TamanhoAtt;

        public int Tamanho => TamanhoAtt;

        protected string FormatoAtt;

        public string Formato => FormatoAtt;
    }
}

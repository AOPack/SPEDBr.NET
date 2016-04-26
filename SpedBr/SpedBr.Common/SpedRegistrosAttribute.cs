using System;

namespace SpedBr.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SpedRegistrosAttribute : Attribute
    {
        public SpedRegistrosAttribute(string obrigatoriedadeInicial, string obrigatoriedadeFinal)
        {
            ObrigatoriedadeInicialAtt = obrigatoriedadeInicial;
            ObrigatoriedadeFinalAtt = obrigatoriedadeFinal;
        }

        protected string ObrigatoriedadeInicialAtt;

        public string ObrigatoriedadeInicial => ObrigatoriedadeInicialAtt;

        protected string ObrigatoriedadeFinalAtt;

        public string ObrigatoriedadeFinal => ObrigatoriedadeFinalAtt;
    }
}

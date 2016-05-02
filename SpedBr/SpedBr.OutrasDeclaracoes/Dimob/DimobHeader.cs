﻿
namespace SpedBr.OutrasDeclaracoes.Dimob
{
    /// <summary>
    /// Header da Declaração
    /// </summary>
    public class DimobHeader
    {
        public DimobHeader()
        {
            Sistema = "DIMOB";
        }

        [DimobCampos(1, "Sistema", 1, 5, 5, "X")]
        public string Sistema { get; }

        [DimobCampos(2, "Reservado", 6, 374, 369, "Branco(s)")]
        public string Reservado { get; }
    }
}

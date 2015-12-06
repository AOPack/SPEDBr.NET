using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    public enum FinalidadeArquivo
    {
        RemessaArquivoOriginal = 0,
        RemessaArquivoSubstituto = 1
    }

    public enum PerfilArquivo
    {
        PerfilA,
        PerfilB,
        PerfilC
    }

    public enum IndicadorTipoAtividade
    {
        Industrial = 0,
        Outros = 1
    }

    public enum IndicadorMovimento
    {
        BlocoComDados = 0,
        BlocoSemDados = 1
    }

    public enum TipoItem
    {
        MercadoriaRevenda = 00,
        MateriaPrima = 01,
        Embalagem = 02,
        ProdutoProcesso = 03,
        ProdutoAcabado = 04,
        Subproduto = 05,
        ProdutoIntermediario = 06,
        MaterialUsoConsumo = 07,
        AtivoImobilizado = 08,
        Servicos = 09,
        OutrosInsumos = 10,
        Outras = 99
    }
}

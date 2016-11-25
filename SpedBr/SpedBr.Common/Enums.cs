namespace SpedBr.Common
{
    public enum SimOuNao
    {
        /// <summary>
        /// Não
        /// </summary>
        N,
        /// <summary>
        /// Sim
        /// </summary>
        S
    }

    public enum FinalidadeArquivo
    {
        RemessaArquivoOriginal = 0,
        RemessaArquivoSubstituto = 1
    }

    public enum PerfilArquivo
    {
        A,
        B,
        C
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

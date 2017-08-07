namespace SpedBr.Common
{
    public enum SimOuNao
    {
        /// <summary>
        ///     Não
        /// </summary>
        N,

        /// <summary>
        ///     Sim
        /// </summary>
        S
    }

    public enum IndMovimento
    {
        /// <summary>
        ///     Bloco com dados informados
        /// </summary>
        BlocoComDados = 0,

        /// <summary>
        ///     Bloco sem dados informados
        /// </summary>
        BlocoSemDados = 1
    }

    /// <summary>
    ///     Código da finalidae do arquivo
    /// </summary>
    public enum IndCodFinalidadeArquivo
    {
        /// <summary>
        ///     Remessa do arquivo original
        /// </summary>
        RemessaArquivoOriginal = 0,

        /// <summary>
        ///     Remessa do arquivo substituto
        /// </summary>
        RemessaArquivoSubstituto = 1
    }

    /// <summary>
    ///     Perfil de apresentação do arquivo fiscal
    /// </summary>
    public enum IndPerfilArquivo
    {
        /// <summary>
        ///     Perfil A
        /// </summary>
        A,

        /// <summary>
        ///     Perfil B
        /// </summary>
        B,

        /// <summary>
        ///     Perfil C
        /// </summary>
        C
    }

    /// <summary>
    ///     Indicador do tipo de atividade
    /// </summary>
    public enum IndTipoAtividade
    {
        /// <summary>
        ///     Industrial ou equiparado a industrial
        /// </summary>
        IndustrialOuEquiparado = 0,

        /// <summary>
        ///     Outros
        /// </summary>
        Outros = 1
    }

    /// <summary>
    ///     Tipo do item - Atividades industriais, comerciais e serviços
    /// </summary>
    public enum IndTipoItem
    {
        /// <summary>
        ///     Mercadoria para revenda: produto adquirido para comercialização
        /// </summary>
        MercadoriaRevenda = 00,

        /// <summary>
        ///     Matéria-prima: a mercadoria que componha, física e/ou quimicamente, um produto em processo  ou  produto acabado e
        ///     que não seja oriunda do processo produtivo.  A mercadoria recebida para industrialização é classificada como Tipo
        ///     01, pois  não decorre do processo produtivo, mesmo que no processo de  produção se produza mercadoria similar
        ///     classificada como Tipo 03;
        /// </summary>
        MateriaPrima = 01,

        /// <summary>
        ///     Embalagem
        /// </summary>
        Embalagem = 02,

        /// <summary>
        ///     Produto em processo: o  produto  que  possua  as  seguintes  características,  cumulativamente:  oriundo  do
        ///     processo  produtivo; e, preponderantemente, consumido  no  processo  produtivo.  Dentre  os  produtos  em  processo
        ///     está  incluído  o  produto  resultante  caracterizado  como   retorno  de  produção.  Um  produto  em  processo  é
        ///     caracterizado  como  retorno  de  produção  quando  é  resultante  de  uma  fase  de  produção  e  é  destinado,
        ///     rotineira  e exclusivamente, a uma fase de produção anterior à qual o mesmo foi gerado. No “retorno de produção”, o
        ///     produto retorna (é consumido) a uma fase de produção anterior à qual ele foi gerado. Isso é uma excepcionalidade,
        ///     pois o normal  é  o  produto  em  processo  ser  consumido  em  uma  fase  de  produção  posterior  à  qual  ele
        ///     foi  gerado, e acontece, portanto, em poucos processos produtivos.
        /// </summary>
        ProdutoProcesso = 03,

        /// <summary>
        ///     Produto acabado: o  produto  que  possua  as  seguintes  características,  cumulativamente:  oriundo  do  processo
        ///     produtivo; produto  final  resultante  do  objeto  da    atividade  econômica  do    contribuinte; e  pronto  para
        ///     ser comercializado;
        /// </summary>
        ProdutoAcabado = 04,

        /// <summary>
        ///     Subproduto: o  produto  que  possua  as  seguintes    características,  cumulativamente:  oriundo  do  processo
        ///     produtivo  e  não  é  objeto  da  produção  principal  do  estabelecimento; tem    aproveitamento  econômico; não
        ///     se enquadre no conceito de produto  em  processo (Tipo 03) ou de produto acabado (Tipo 04);
        /// </summary>
        Subproduto = 05,

        /// <summary>
        ///     Produto intermediário: aquele que, embora não se integrando ao novo produto, for consumido no processo de
        ///     industrialização.
        /// </summary>
        ProdutoIntermediario = 06,

        /// <summary>
        ///     Material de uso e consumo
        /// </summary>
        MaterialUsoConsumo = 07,

        /// <summary>
        ///     Ativo imobilizado
        /// </summary>
        AtivoImobilizado = 08,

        /// <summary>
        ///     Serviços
        /// </summary>
        Servicos = 09,

        /// <summary>
        ///     Outros insumos
        /// </summary>
        OutrosInsumos = 10,

        /// <summary>
        ///     Outras
        /// </summary>
        Outras = 99
    }

    /// <summary>
    ///     Identificação do tipo de mercadoria
    /// </summary>
    public enum IndTipoMercadoria
    {
        /// <summary>
        ///     Bem: uma mercadoria será considerada "bem" quando possua todas as condições necessárias para ser utilizado nas
        ///     atividades do estabelecimento.
        /// </summary>
        Bem = 1,

        /// <summary>
        ///     Componente: uma mercadoria será considerada "componente" quando fizer parte de um bem móvel que estiver sendo
        ///     construído no estabelecimento do contribuinte, onde somente o bem móvel resultante é que possuirá as condições
        ///     necessárias para ser utilizado nas atividades do estabelecimento.
        /// </summary>
        Componente = 2
    }

    /// <summary>
    ///     Código da Natureza da conta/grupo de contas
    /// </summary>
    public enum IndNaturezaConta
    {
        /// <summary>
        ///     Contas de ativo
        /// </summary>
        ContasAtivo = 01,

        /// <summary>
        ///     Contas de passivo
        /// </summary>
        ContasPassivo = 02,

        /// <summary>
        ///     Patrimônio líquido
        /// </summary>
        PatrimonioLiquido = 03,

        /// <summary>
        ///     Contas de resultado
        /// </summary>
        ContasResultado = 04,

        /// <summary>
        ///     Contas de compensação
        /// </summary>
        ContasCompensacao = 05,

        /// <summary>
        ///     Outras
        /// </summary>
        Outras = 09
    }

    /// <summary>
    ///     Indicador do tipo de conta
    /// </summary>
    public enum IndTipoConta
    {
        /// <summary>
        ///     Sintética (grupo de contas)
        /// </summary>
        S,

        /// <summary>
        ///     Analítica (conta)
        /// </summary>
        A
    }

    /// <summary>
    ///     Indicador do tipo de operação
    /// </summary>
    public enum IndTipoOperacaoProduto
    {
        /// <summary>
        ///     Entrada
        /// </summary>
        Entrada = 0,

        /// <summary>
        ///     Saída
        /// </summary>
        Saida = 1
    }

    /// <summary>
    ///     Indicador do tipo de operação
    /// </summary>
    public enum IndTipoOperacaoServico
    {
        /// <summary>
        ///     Aquisição
        /// </summary>
        Aquisicao = 0,

        /// <summary>
        ///     Prestação
        /// </summary>
        Prestacao = 1
    }

    /// <summary>
    ///     Indicador do emitente do documento fiscal/título
    /// </summary>
    public enum IndEmitente
    {
        /// <summary>
        ///     Emissão própria
        /// </summary>
        EmissaoPropria = 0,

        /// <summary>
        ///     Terceiros
        /// </summary>
        Terceiros = 1
    }

    /// <summary>
    ///     Código da situação do documento fiscal
    /// </summary>
    public enum IndCodSitDoc
    {
        DocumentoRegular = 00,
        DocumentoRegularExtemporaneo = 01,
        DocumentoCancelado = 02,
        DocumentoCanceladoExtemporaneo = 03,
        DFeDenegado = 04,
        DFeInutilizado = 05,
        DocumentoFiscalComplementar = 06,
        DocumentoFiscalComplementarExtemporaneo = 07,
        DocumentoFiscalRegimeEspecial = 08
    }

    /// <summary>
    ///     Indicador do tipo de pagamento
    /// </summary>
    public enum IndTipoPagamento
    {
        /// <summary>
        ///     À vista
        /// </summary>
        AVista = 0,

        /// <summary>
        ///     A prazo
        /// </summary>
        APrazo = 1,

        /// <summary>
        ///     Outros
        /// </summary>
        Outros = 2,

        /// <summary>
        ///     Sem pagamento
        /// </summary>
        SemPagamento = 9
    }

    /// <summary>
    ///     Indicador do tipo de frete
    /// </summary>
    public enum IndTipoFrete
    {
        ContaEmitente = 0,
        ContaDestinatarioRemetente = 1,
        ContaTerceiros = 2,
        SemCobrancaFrete = 9
    }

    /// <summary>
    ///     Indicador do tipo de operação
    /// </summary>
    public enum IndTipoOperacaoStUfDiversa
    {
        /// <summary>
        ///     0 - Combustíveis e lubrificantes;
        /// </summary>
        CombustiveisLubrificantes = 0,

        /// <summary>
        ///     1 - Leasing de veículos ou faturamento direto.
        /// </summary>
        LeasingVeiculosFaturamentoDireto = 1
    }

    /// <summary>
    ///     Indicador da origem do processo
    /// </summary>
    public enum IndOrigemProcesso
    {
        /// <summary>
        ///     0 - SEFAZ
        /// </summary>
        Sefaz = 0,

        /// <summary>
        ///     1 - Justiça Federal
        /// </summary>
        JusticaFederal = 1,

        /// <summary>
        ///     2 - Justiça Estadual
        /// </summary>
        JusticaEstadual = 2,

        /// <summary>
        ///     3 - SECEX/SRF
        /// </summary>
        Secexsrf = 3,

        /// <summary>
        ///     9 - Outros
        /// </summary>
        Outros = 9
    }

    /// <summary>
    ///     Código do modelo do documento de arrecadação
    /// </summary>
    public enum IndCodModDocArrecadacao
    {
        /// <summary>
        ///     Documento estadual de arrecadação
        /// </summary>
        DocumentoEstadual = 0,

        /// <summary>
        ///     GNRE
        /// </summary>
        Gnre = 1
    }

    /// <summary>
    ///     Indicador do tipo de transporte
    /// </summary>
    public enum IndTipoTransporte
    {
        /// <summary>
        ///     Rodoviário
        /// </summary>
        Rodoviario = 0,

        /// <summary>
        ///     Ferroviário
        /// </summary>
        Ferroviario = 1,

        /// <summary>
        ///     Rodo-Ferroviário
        /// </summary>
        RodoFerroviario = 2,

        /// <summary>
        ///     Aquaviário
        /// </summary>
        Aquaviario = 3,

        /// <summary>
        ///     Dutoviário
        /// </summary>
        Dutoviario = 4,

        /// <summary>
        ///     Aéreo
        /// </summary>
        Aereo = 5,

        /// <summary>
        ///     Outros
        /// </summary>
        Outros = 9
    }

    /// <summary>
    ///     Documento de importação
    /// </summary>
    public enum IndDocumentoImportacao
    {
        /// <summary>
        ///     Declaração de Importação
        /// </summary>
        DeclaracaoImportacao = 0,

        /// <summary>
        ///     Declaração Simplificada de Importação
        /// </summary>
        DeclaracaoSimplificadaImportacao = 1
    }

    /// <summary>
    ///     Indicador do tipo de título de crédito
    /// </summary>
    public enum IndTipoTituloCred
    {
        /// <summary>
        ///     Duplicata
        /// </summary>
        Duplicata = 00,

        /// <summary>
        ///     Cheque
        /// </summary>
        Cheque = 01,

        /// <summary>
        ///     Promissória
        /// </summary>
        Promissoria = 02,

        /// <summary>
        ///     Recibo
        /// </summary>
        Recibo = 03,

        /// <summary>
        ///     Outros
        /// </summary>
        Outros = 99
    }

    /// <summary>
    ///     Indicador de período de apuração do IPI
    /// </summary>
    public enum IndPeriodoApuracaoIpi
    {
        /// <summary>
        ///     Mensal
        /// </summary>
        Mensal = 0,

        /// <summary>
        ///     Decendial
        /// </summary>
        Decendial = 1
    }

    /// <summary>
    ///     Movimentação física do ITEM/PRODUTO
    /// </summary>
    public enum IndMovFisicaItem
    {
        /// <summary>
        ///     Sim
        /// </summary>
        Sim = 0,

        /// <summary>
        ///     Não
        /// </summary>
        Nao = 1
    }

    /// <summary>
    ///     Indicador de tipo de referência da base de cálculo do ICMS (ST) do produto farmacêutico
    /// </summary>
    public enum IndBaseProdFarmaceutico
    {
        /// <summary>
        ///     Base de cálculo referente ao preço tabelado ou preço máximo sugerido
        /// </summary>
        BcPrecoTabeladoOuPrecoMaximo = 0,

        /// <summary>
        ///     Base de cálculo - Margem de valor agregado
        /// </summary>
        BcMargemValorAgregado = 1,

        /// <summary>
        ///     Base de cálculo referente à Lista Negativa
        /// </summary>
        BcListaNegativa = 2,

        /// <summary>
        ///     Base de cálculo referente à Lista Positiva
        /// </summary>
        BcListaPositiva = 3,

        /// <summary>
        ///     Base de cálculo referente à Lista Neutra
        /// </summary>
        BcListaNeutra = 4
    }

    /// <summary>
    ///     Tipo de produto farmacêutico
    /// </summary>
    public enum IndTipoProdFarmaceutico
    {
        /// <summary>
        ///     Similar
        /// </summary>
        Similar = 0,

        /// <summary>
        ///     Genérico
        /// </summary>
        Generico = 1,

        /// <summary>
        ///     Ético ou de marca
        /// </summary>
        EticoOuMarca = 2
    }

    /// <summary>
    ///     Indicador do tipo de arma de fogo
    /// </summary>
    public enum IndTipoArmaFogo
    {
        /// <summary>
        ///     Uso permitido
        /// </summary>
        UsoPermitido,

        /// <summary>
        ///     Uso restrito
        /// </summary>
        UsoRestrito
    }

    /// <summary>
    ///     Indicador do tipo de operação com veículo
    /// </summary>
    public enum IndTipoOperacaoVeiculo
    {
        /// <summary>
        ///     Venda para concessionária
        /// </summary>
        VendaParaConcessionaria = 0,

        /// <summary>
        ///     Faturamento direto
        /// </summary>
        FaturamentoDireto = 1,

        /// <summary>
        ///     Venda direta
        /// </summary>
        VendaDireta = 2,

        /// <summary>
        ///     Venda da concessionária
        /// </summary>
        VendaDaConcessionaria = 3,

        /// <summary>
        ///     Outros
        /// </summary>
        Outros = 9
    }

    /// <summary>
    ///     Código de classe de consumo de energia elétrica
    /// </summary>
    public enum IndClasseConsumoEnergia
    {
        /// <summary>
        ///     Comercial
        /// </summary>
        Comercial = 01,

        /// <summary>
        ///     Consumo Próprio
        /// </summary>
        ConsumoProprio = 02,

        /// <summary>
        ///     Iluminação Pública
        /// </summary>
        IluminacaoPublica = 03,

        /// <summary>
        ///     Industrial
        /// </summary>
        Industrial = 04,

        /// <summary>
        ///     Poder Público
        /// </summary>
        PoderPublico = 05,

        /// <summary>
        ///     Residencial
        /// </summary>
        Residencial = 06,

        /// <summary>
        ///     Rural
        /// </summary>
        Rural = 07,

        /// <summary>
        ///     Serviço Público
        /// </summary>
        ServicoPublico = 08
    }

    /// <summary>
    ///     Código de classe de consumo de água canalizada
    /// </summary>
    public enum IndClasseConsumoAgua
    {
        ConsResidencialAte50 = 00,
        ConsResidencialDe50A100 = 01,
        ConsResidencialDe100A200 = 02,
        ConsResidencialDe200A300 = 03,
        ConsResidencialDe300A400 = 04,
        ConsResidencialDe400A500 = 05,
        ConsResidencialDe500A1000 = 06,
        ConsResidencialAcima1000 = 07,
        ConsComercialIndustrialAte50 = 20,
        ConsComercialIndustrialDe50A100 = 21,
        ConsComercialIndustrialDe100A200 = 22,
        ConsComercialIndustrialDe200A300 = 23,
        ConsComercialIndustrialDe300A400 = 24,
        ConsComercialIndustrialDe400A500 = 25,
        ConsComercialIndustrialDe500A1000 = 26,
        ConsComercialIndustrialAcima1000 = 27,
        ConsOrgaoPublico = 80,
        OutrosTiposConsumoAte50 = 90,
        OutrosTiposConsumoDe50A100 = 91,
        OutrosTiposConsumoDe100A200 = 92,
        OutrosTiposConsumoDe200A300 = 93,
        OutrosTiposConsumoDe300A400 = 94,
        OutrosTiposConsumoDe400A500 = 95,
        OutrosTiposConsumoDe500A1000 = 96,
        OutrosTiposConsumoAcima1000 = 97,
        RegPorDocumentoFiscalEmitido = 99
    }

    /// <summary>
    ///     Código de classe de consumo de gás canalizado
    /// </summary>
    public enum IndClasseConsumoGas
    {
        ConsResidencialAte50 = 00,
        ConsResidencialDe50A100 = 01,
        ConsResidencialDe100A200 = 02,
        ConsResidencialDe200A300 = 03,
        ConsResidencialDe300A400 = 04,
        ConsResidencialDe400A500 = 05,
        ConsResidencialDe500A1000 = 06,
        ConsResidencialAcima1000 = 07,
        ConsComercialIndustrialAte50 = 20,
        ConsComercialIndustrialDe50A100 = 21,
        ConsComercialIndustrialDe100A200 = 22,
        ConsComercialIndustrialDe200A300 = 23,
        ConsComercialIndustrialDe300A400 = 24,
        ConsComercialIndustrialDe400A500 = 25,
        ConsComercialIndustrialDe500A1000 = 26,
        ConsComercialIndustrialAcima1000 = 27,
        ConsOrgaoPublico = 80,
        OutrosTiposConsumoAte50 = 90,
        OutrosTiposConsumoDe50A100 = 91,
        OutrosTiposConsumoDe100A200 = 92,
        OutrosTiposConsumoDe200A300 = 93,
        OutrosTiposConsumoDe300A400 = 94,
        OutrosTiposConsumoDe400A500 = 95,
        OutrosTiposConsumoDe500A1000 = 96,
        OutrosTiposConsumoAcima1000 = 97,
        RegPorDocumentoFiscalEmitido = 99
    }

    /// <summary>
    ///     Código do tipo de ligação
    /// </summary>
    public enum IndCodTipoLigacao
    {
        /// <summary>
        ///     Monofásico
        /// </summary>
        Monofasico = 1,

        /// <summary>
        ///     Bifásico
        /// </summary>
        Bifasico = 2,

        /// <summary>
        ///     Trifásico
        /// </summary>
        Trifasico = 3
    }

    public enum IndCodGrupoTensao
    {
        A1 = 01,
        A2 = 02,
        A3 = 03,
        A3a = 04,
        A4 = 05,
        AS = 06,
        B1 = 07,
        B1BaixaRenda = 08,
        B2Rural = 09,
        B2Cooperativa = 10,
        B2ServicoPublico = 11,
        B3DemaisClasses = 12,
        B4a = 13,
        B4b = 14
    }
}
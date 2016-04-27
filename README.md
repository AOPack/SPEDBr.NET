# SPEDBr
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias para o cenário contábil/fiscal brasileiro.

**EXEMPLOS**

**- EFD CONTRIBUIÇÕES**

- EXEMPLO DE PREENCHIMENTO DO BLOCO F - REGISTRO 200

```cs

var listaLinhasArquivo = new List<string>();

var competencia = new DateTime(dataInicial.Year, dataInicial.Month, 1);

var listaContratos = ObtemListaContratosNoPeriodo(dataInicial, dataFinal);

var totalLinhasF200 = 0;

/* Cada contrato imobiliário gera um registro F200 */
foreach (var objContrato in listaContratos)
{
  var registroF200 = new BlocoF.EfdContribRegF200
  {
    // Preenche informações
  };

  /* adiciona nas linhas do arquivo */
  listaLinhasArquivo.Add(registroF200.EscreverCampos(competencia));
  totalLinhasF200++;
}

```

**DÚVIDAS?**

Abra um issue na página do projeto aqui mesmo no GitHub.

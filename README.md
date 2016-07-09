#[SPEDBr] (http://samuelroliveira.github.io/SPEDBr/)
######SITE OFICIAL DO SPED: http://sped.rfb.gov.br/
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias no cenário contábil/fiscal brasileiro.

##Sumário

- [Declarações] (#declaracoes)
- [Exemplos](#exemplos)
- [Screenshots](#screenshots)
- [Dúvidas?](#dúvidas)

##Declarações

######Projeto SPED

- [ ] FCONT
- [ ] EFD Reinf
- [ ] EFD ICMS/IPI
- [ ] EFD Contribuições
- [ ] Escrituração Contábil Fiscal (ECF)
- [ ] Escrituração Contábil Digital (ECD)

######Outras

- [ ] DACON
- [ ] DCTF
- [x] DIMOB (02/05/2016 - @samuelroliveira)
- [ ] DIPJ
- [ ] DIRF
- [ ] GFIP/SEFIP
- [ ] SINTEGRA

##Exemplos

######EFD Contribuições

- Exemplo de Preenchimento do Bloco F - Registro 200

```cs
var listaLinhasArquivo = new List<string>();

var competencia = new DateTime(dataInicial.Year, dataInicial.Month, 1);

var listaContratos = ObtemListaContratosNoPeriodo(dataInicial, dataFinal);

var totalLinhasF200 = 0;

/* Cada contrato imobiliário gera um registro F200 */
foreach (var objContrato in listaContratos) {
  var registroF200 = new BlocoF.EfdContribRegF200 {
    // Preenche informações
  };

  /* adiciona nas linhas do arquivo */
  listaLinhasArquivo.Add(registroF200.EscreverCampos(competencia));
  totalLinhasF200++;
}
```

##Screenshots

######Tela inicial
![](https://github.com/samuelroliveira/SPEDBr/blob/master/capture_1.PNG)

##Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui] (https://github.com/samuelroliveira/SPEDBr/issues).

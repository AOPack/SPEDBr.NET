# SPEDBr [![Donate](https://img.shields.io/badge/Donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FDBYCQDQ368KA)
###### SITE OFICIAL DO SPED: http://sped.rfb.gov.br/
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias no cenário contábil/fiscal brasileiro.

![#f03c15](https://placehold.it/15/f03c15/000000?text=+) <b>AVISO IMPORTANTE</b>

Esta biblioteca será atualizada até 30/06/2018, após esse prazo será descontinuada e novas atualizações serão feitas em um novo repositório, para acessar [clique aqui](https://github.com/samuelrochaoliveira/SPEDBr).

## Sumário

- [Declarações](#declaracoes)
- [Outros](#outros)
- [Exemplos](#exemplos)
- [Dúvidas?](#dúvidas)
- [Colaboradores](#colaboradores)

## Declarações

###### Projeto SPED

- [x] EFD ICMS/IPI
- [x] EFD Contribuições
- [ ] Escrituração Contábil Fiscal (ECF)
- [ ] Escrituração Contábil Digital (ECD)

###### Outras

- [x] DIMOB (Concluído em 02/05/2016)

## Outros
- [x] [SINTEGRABr](https://github.com/samuelroliveira/SINTEGRABr)
- [ ] [FISCALBr](https://github.com/samuelroliveira/FiscalBr)

## TODO

- [ ] Mapear enums restantes do SPED.
- [ ] Mapear registros restantes da EFD Contribuições. [#28](https://github.com/samuelrochaoliveira/SPEDBr/issues/28)
- [ ] Melhorar performance na geração das linhas, monitorar tempo da geração.

## Exemplos

###### EFD Contribuições

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

## Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui](https://github.com/samuelroliveira/SPEDBr/issues).

## Colaboradores

AutoCom - Microplan Automação Comercial Ltda - MG
- Eduardo Moreira
- Bruno Novaes - (33) 3331-5808
- Whashington Reis

# [SPEDBr](http://samuelroliveira.github.io/SPEDBr/) [![Donate](https://img.shields.io/badge/Donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FDBYCQDQ368KA)
###### SITE OFICIAL DO SPED: http://sped.rfb.gov.br/
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias no cenário contábil/fiscal brasileiro.

## Sumário

- [Declarações](#declaracoes)
- [Exemplos](#exemplos)
- [Screenshots](#screenshots)
- [Dúvidas?](#dúvidas)
- [Colaboradores](#colaboradores)

## Declarações

###### Projeto SPED

- [x] EFD ICMS/IPI
- [ ] EFD Contribuições
- [ ] Escrituração Contábil Fiscal (ECF)
- [ ] Escrituração Contábil Digital (ECD)

###### Outras

- [ ] DCTF
- [x] DIMOB (02/05/2016 - @samuelroliveira)
- [x] [SINTEGRA](https://github.com/samuelroliveira/SINTEGRABr) (Outro projeto)

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

## Screenshots

###### Tela inicial
![](https://github.com/samuelroliveira/SPEDBr/blob/master/capture_1.PNG)

## Dúvidas?

Abra um issue na página do projeto no GitHub ou [clique aqui](https://github.com/samuelroliveira/SPEDBr/issues).

## Colaboradores

AutoCom - Microplan Automação Comercial Ltda - MG
- Eduardo Moreira
- Bruno Novaes - (33) 3331-5808
- Whashington Reis

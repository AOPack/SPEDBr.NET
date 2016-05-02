#[SPEDBr] (http://samuelroliveira.github.io/SPEDBr/)
###### SITE OFICIAL DO SPED: http://sped.rfb.gov.br/
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias no cenário contábil/fiscal brasileiro.

##Sumário

- [TODO] (#todo)
- [Exemplos](#exemplos)
- [Dúvidas?](#dúvidas)

##TODO

###### EFD Contribuições

- [ ] Bloco 0
- [ ] Bloco A
- [ ] Bloco C
- [ ] Bloco D
- [ ] Bloco F
- [ ] Bloco I
- [ ] Bloco M
- [ ] Bloco P
- [ ] Bloco 1
- [ ] Bloco 9

###### SPED Fiscal ICMS/IPI

- [x] Bloco 0
- [ ] Bloco C
- [ ] Bloco D
- [ ] Bloco E
- [ ] Bloco G
- [ ] Bloco H
- [ ] Bloco K
- [ ] Bloco 1
- [ ] Bloco 9

###### DIMOB

- [x] Header
- [x] R01
- [x] R02
- [x] R03
- [x] R04
- [x] Trailler

###### SINTEGRA

- [x] Registro Tipo 10
- [x] Registro Tipo 11
- [x] Registro Tipo 50
- [ ] Registro Tipo 51
- [ ] Registro Tipo 53
- [ ] Registro Tipo 54
- [ ] Registro Tipo 55
- [ ] Registro Tipo 56
- [ ] Registro Tipo 60
- [x] Registro Tipo 61
- [ ] Registro Tipo 70
- [ ] Registro Tipo 71
- [ ] Registro Tipo 74
- [ ] Registro Tipo 75
- [ ] Registro Tipo 76
- [ ] Registro Tipo 77
- [ ] Registro Tipo 85
- [ ] Registro Tipo 86
- [x] Registro Tipo 90

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

##Dúvidas?

Abra um issue na página do projeto aqui mesmo no GitHub ou [clique aqui] (https://github.com/samuelroliveira/SPEDBr/issues).

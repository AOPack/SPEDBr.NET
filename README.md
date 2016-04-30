# SPEDBr
###### SITE OFICIAL DO SPED: http://sped.rfb.gov.br/
Biblioteca gratuita  - desenvolvida com Visual Studio Community 2015 - para geração dos arquivos SPED e demais declarações necessárias no cenário contábil/fiscal brasileiro.

##Sumário

- [TODO] (#todo)
- [Exemplos](#exemplos)
- [Dúvidas?](#dúvidas)

##TODO

###### EFD Contribuições

- :x: Bloco 0
- :x: Bloco A
- :x: Bloco C
- :x: Bloco D
- :x: Bloco F
- :x: Bloco I
- :x: Bloco M
- :x: Bloco P
- :x: Bloco 1
- :x: Bloco 9

###### SPED Fiscal ICMS/IPI

- :white_check_mark: Bloco 0
- :x: Bloco C
- :x: Bloco D
- :x: Bloco E
- :x: Bloco G
- :x: Bloco H
- :x: Bloco K
- :x: Bloco 1
- :x: Bloco 9

###### SINTEGRA

- :white_check_mark: Registro Tipo 10
- :white_check_mark: Registro Tipo 11
- :white_check_mark: Registro Tipo 50
- :x: Registro Tipo 51
- :x: Registro Tipo 53
- :x: Registro Tipo 54
- :x: Registro Tipo 55
- :x: Registro Tipo 56
- :x: Registro Tipo 60
- :white_check_mark: Registro Tipo 61
- :x: Registro Tipo 70
- :x: Registro Tipo 71
- :x: Registro Tipo 74
- :x: Registro Tipo 75
- :x: Registro Tipo 76
- :x: Registro Tipo 77
- :x: Registro Tipo 85
- :x: Registro Tipo 86
- :white_check_mark: Registro Tipo 90

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

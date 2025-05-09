# Desafio 3 - Análise de Faturamento

## Descrição do Problema

Dado um arquivo JSON contendo dados de faturamento diário de uma distribuidora, o programa deve calcular:
- O menor valor de faturamento ocorrido em um dia do mês
- O maior valor de faturamento ocorrido em um dia do mês
- Número de dias no mês em que o valor de faturamento diário foi superior à média mensal

## Solução

A solução implementada em C# oferece:
- Leitura e processamento de arquivo JSON
- Cálculo de estatísticas de faturamento
- Tratamento de dias sem faturamento (valor = 0)
- Exibição detalhada dos resultados

### Como Executar

1. Certifique-se de ter o .NET SDK instalado
2. Navegue até a pasta do projeto
3. Execute o comando:
```bash
dotnet run
```

### Funcionalidades

- Lê dados de faturamento do arquivo `dados.json`
- Ignora dias sem faturamento (valor = 0) no cálculo da média
- Exibe o menor e maior valor de faturamento com seus respectivos dias
- Calcula e exibe a média mensal
- Lista todos os dias com faturamento acima da média

### Estrutura do Arquivo JSON

O arquivo `dados.json` deve conter um array de objetos com a seguinte estrutura:
```json
[
  {
    "dia": 1,
    "valor": 22174.1664
  },
  ...
]
```

### Exemplo de Saída

```
Análise de Faturamento Mensal
----------------------------

Menor valor de faturamento: R$ 373.78 (Dia 14)
Maior valor de faturamento: R$ 48924.24 (Dia 16)
Média mensal: R$ 20865.37
Número de dias com faturamento acima da média: 10

Dias com faturamento acima da média:
Dia 1: R$ 22174.17
Dia 2: R$ 24537.67
...
``` 
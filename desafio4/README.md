# Desafio 4 - Percentual de Representação por Estado

## Descrição do Problema

Dado o valor de faturamento mensal de uma distribuidora por estado:
- SP – R$67.836,43
- RJ – R$36.678,66
- MG – R$29.229,88
- ES – R$27.165,48
- Outros – R$19.849,53

O programa deve calcular o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

## Solução

A solução implementada em C# oferece:
- Cálculo do total de faturamento
- Cálculo do percentual de representação por estado
- Exibição ordenada dos resultados (do maior para o menor faturamento)
- Formatação adequada dos valores monetários e percentuais

### Como Executar

1. Certifique-se de ter o .NET SDK instalado
2. Navegue até a pasta do projeto
3. Execute o comando:
```bash
dotnet run
```

### Funcionalidades

- Calcula o total de faturamento de todos os estados
- Calcula o percentual de representação de cada estado
- Exibe os resultados ordenados por valor de faturamento
- Formata os valores monetários e percentuais com duas casas decimais

### Exemplo de Saída

```
Percentual de Representação por Estado
-------------------------------------

Total de Faturamento: R$ 180.759,98

Distribuição por Estado:
----------------------
SP:
  Faturamento: R$ 67.836,43
  Percentual: 37,53%

RJ:
  Faturamento: R$ 36.678,66
  Percentual: 20,29%

MG:
  Faturamento: R$ 29.229,88
  Percentual: 16,17%

ES:
  Faturamento: R$ 27.165,48
  Percentual: 15,03%

Outros:
  Faturamento: R$ 19.849,53
  Percentual: 10,98%
``` 
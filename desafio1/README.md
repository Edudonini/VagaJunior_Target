# Desafio 1 - Cálculo de SOMA

## Descrição do Problema

Dado o trecho de código:
```csharp
int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça {
    K = K + 1;
    SOMA = SOMA + K;
}
Imprimir(SOMA);
```

## Solução

A solução implementada em C# calcula o valor final da variável SOMA através de um loop while.

### Como Executar

1. Certifique-se de ter o .NET SDK instalado
2. Navegue até a pasta do projeto
3. Execute o comando:
```bash
dotnet run
```

### Explicação do Resultado

O valor final da variável SOMA será 91, pois:
- O loop executa 13 vezes (de K = 1 até K = 13)
- A cada iteração, o valor de K é somado à variável SOMA
- Portanto: SOMA = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 = 91 
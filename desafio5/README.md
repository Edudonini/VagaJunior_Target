# Desafio 5 - Inversão de String

## Descrição do Problema

Implementar um programa que inverte os caracteres de uma string, sem utilizar funções prontas como `reverse`.

## Solução

A solução implementada em C# oferece:
- Interface interativa via console
- Inversão de string usando algoritmo próprio
- Tratamento de strings vazias ou nulas
- Opção de sair do programa

### Como Executar

1. Certifique-se de ter o .NET SDK instalado
2. Navegue até a pasta do projeto
3. Execute o comando:
```bash
dotnet run
```

### Funcionalidades

- Digite uma string para inverter
- Digite 'sair' para encerrar o programa
- O programa mostrará a string original e a invertida
- Tratamento de erros de entrada

### Algoritmo de Inversão

O algoritmo implementado:
1. Converte a string em um array de caracteres
2. Utiliza dois índices (início e fim) que se movem em direções opostas
3. Troca os caracteres nas posições dos índices
4. Continua até que os índices se encontrem no meio da string

### Exemplo de Uso

```
Inversor de String
-----------------

Digite uma string para inverter (ou 'sair' para encerrar): Target Sistemas

String original: Target Sistemas
String invertida: sametiS tegraT
``` 
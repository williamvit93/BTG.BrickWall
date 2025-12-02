# Brick Wall Problem – C# Solution

Este repositório contém a solução em **C#** para o desafio de lógica de programação do BTG Pactual, cujo objetivo é encontrar a posição ideal para traçar uma linha vertical que corte o menor número possível de tijolos em uma parede representada como listas de inteiros.

---

## Problema

Dada uma parede composta por várias linhas de tijolos, cada uma representada por um array de larguras, o objetivo é determinar onde desenhar uma linha vertical (exceto nas extremidades) que atravessa o menor número de tijolos.

Sempre que a linha passa exatamente pela borda entre dois tijolos, nenhum tijolo é cortado naquela linha.

### Exemplo:

`Input:
[[1,2,2,1],
[3,1,2],
[1,3,2],
[2,4],
[3,1,2],
[1,3,1,1]]`


`Output:
2`

---

## Abordagem da Solução

A estratégia consiste em:

1. Percorrer cada linha da parede.
2. Calcular as posições das bordas internas dos tijolos.
3. Utilizar um dicionário (`Dictionary<int, int>`) para contar quantas linhas possuem bordas na mesma posição.
4. A melhor posição para desenhar a linha é aquela com mais bordas alinhadas.
5. O mínimo de tijolos cortados é:

`tijolos cortados = número total de linhas - maior quantidade de bordas alinhadas`


---

## Tecnologias Utilizadas

- C# / .NET
- xUnit para testes unitários

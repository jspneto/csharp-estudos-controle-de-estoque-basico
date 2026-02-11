# Controle de Estoque Básico

Projeto de estudo em C# com o objetivo de modelar e manipular os dados de um produto em estoque, permitindo consultar informações, registrar entradas e saídas e calcular o valor total armazenado.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Leitura e exibição de dados via console
- Modelagem de entidades simples
- Encapsulamento de dados e comportamentos
- Criação de métodos para regras de negócio
- Cálculo de valores derivados a partir de atributos
- Organização e versionamento de código com Git

## Enunciado do Problema

Ler e armazenar os dados de um **produto em estoque**, contendo informações básicas como nome, preço e quantidade disponível.

A aplicação permite:
- Exibir os dados atuais do produto
- Atualizar a quantidade por meio de entradas no estoque
- Atualizar a quantidade por meio de saídas no estoque
- Calcular automaticamente o valor total do estoque com base nos dados do produto

O foco está na **organização do código** e na separação clara entre dados e comportamentos.

## Estrutura do Projeto

```bash
|- ControleEstoqueBasico
   |- ControleEstoqueBasico.csproj
   |- ControleEstoqueBasico.sln
   |- Produto.cs
   |- Program.cs
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

- [**v0.1**][1] — Implementação da classe `Produto` com atributos públicos
- [**v0.2**][2] — Sobrescrita do método ToString e melhoria de encapsulamento da exibição
- [**v0.3**][3] — Introdução de construtor na classe Produto
- [**v0.4**][4] — Sobrecarga de construtores na classe Produto
- [**v0.5**][5] — Aplicação de encapsulamento na classe Produto

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de
aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto/csharp-estudos-controle-de-estoque-basico/tree/v0.1/ControleEstoqueBasico "v0.1"

[2]: https://github.com/jspneto/csharp-estudos-controle-de-estoque-basico/tree/v0.2/ControleEstoqueBasico "v0.2"

[3]: https://github.com/jspneto/csharp-estudos-controle-de-estoque-basico/tree/v0.3/ControleEstoqueBasico "v0.3"

[4]: https://github.com/jspneto/csharp-estudos-controle-de-estoque-basico/tree/v0.4/ControleEstoqueBasico "v0.4"

[5]: https://github.com/jspneto/csharp-estudos-controle-de-estoque-basico/tree/v0.5/ControleEstoqueBasico "v0.5"

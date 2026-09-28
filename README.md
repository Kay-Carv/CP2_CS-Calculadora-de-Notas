# Calculadora de Notas - CP2 (Lógica com Estruturas em C#)

Este projeto é uma aplicação Console em C# desenvolvida como requisito para o Checkpoint 2 da disciplina de Lógica de Programação. 
O sistema atua como um gerenciador simplificado de notas, permitindo o cadastro de alunos, lançamento de notas, cálculo de médias e verificação do status de aprovação.

## Funcionalidades

Menu interativo com as opções disponíveis:

1. **Cadastrar aluno:** Permite registrar o nome de múltiplos alunos no sistema.
2. **Lançar notas:** Possibilita registrar 3 notas (de 0 a 10) para um aluno específico, buscando através do seu ID para evitar conflitos com nomes repetidos.
3. **Calcular média:** Calcula a média aritmética das 3 notas e exibe a situação final do aluno com base nos seguintes critérios:
   - **Aprovado:** Média >= 7.0
   - **Recuperação:** Média >= 5.0 e < 7.0
   - **Reprovado:** Média < 5.0
4. **Sair:** Encerra a aplicação.

## Requisitos Técnicos Aplicados

O código foi estruturado utilizando boas práticas e os conceitos de C#:
- Uso de `Console.ReadLine()` e `double.TryParse()`/`int.TryParse()` para entrada e validação segura de dados.
- Estruturas de controle de fluxo: `if/else`, `switch` e `do/while`.
- Uso de `List` e `Arrays` para armazenamento de dados em memória.
- Divisão de responsabilidades em métodos dedicados (ex: `CadastrarAluno()`, `LancarNotas()`, `CalcularMedia()`, `ExibirSituacao()`).
- Utilização de constantes (`const double`) para os critérios de aprovação.

## Implementações Extras

- **Switch Expression:** Utilizado no método `ExibirSituacao()` 
- Prevenção contra o cálculo de médias de alunos que ainda não tiveram suas notas lançadas (inicialização com valor `-1`).
- Busca de alunos no lançamento de notas/médias através de um ID dinâmico, resolvendo a vulnerabilidade de alunos com nomes homônimos.

## Autor

Desenvolvido por **Kayque Carvalho** (RM561189).

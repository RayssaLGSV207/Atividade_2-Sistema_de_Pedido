---

# 🧮 Sistema de Cálculo de Pedido

## 📋 Descrição

Um sistema em C# para cálculo de pedidos que aplica descontos progressivos e calcula frete de forma inteligente. O programa recebe o preço unitário e a quantidade de um produto, calcula o subtotal, aplica desconto conforme o valor da compra, adiciona frete quando necessário e exibe o total final.

## ✨ Funcionalidades

- ✅ Cálculo de subtotal (preço × quantidade)
- ✅ Validação de valores negativos
- ✅ Desconto de 10% para compras acima de R$ 100,00
- ✅ Frete grátis para compras acima de R$ 200,00
- ✅ Frete fixo de R$ 20,00 para compras abaixo de R$ 200,00
- ✅ Exibição detalhada de cada etapa do cálculo
- ✅ Método extra com parâmetro `out` para múltiplos retornos

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Descrição |
|------------|--------|-----------|
| .NET | 10.0 | Framework de desenvolvimento |
| C# | 10.0+ | Linguagem de programação |
| Console Application | - | Aplicação de linha de comando |

## 📁 Estrutura do Projeto

```
Console-Atividade2/
├── Atividade2.cs              # Código fonte principal
├── Console-Atividade2.csproj  # Arquivo de configuração do projeto
└── README.md                  # Documentação
```

## 🚀 Como Executar

### Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) instalado
- VS Code, Visual Studio ou qualquer editor de código

### Passos para execução

1. **Clone ou acesse o diretório do projeto**
   ```bash
   cd Console-Atividade2
   ```

2. **Execute o programa**
   ```bash
   dotnet run
   ```

3. **Siga as instruções no console**
   - Digite o preço unitário do produto
   - Digite a quantidade desejada
   - Veja o cálculo detalhado

## 📊 Exemplo de Uso

### Cenário 1: Compra com desconto e frete
```
=== SISTEMA DE CÁLCULO DE PEDIDO ===

Digite os dados do pedido:

Digite o preço unitário do produto: R$50
Digite a quantidade desejada: 3

--- PROCESSANDO PEDIDO ---
Subtotal: R$150,00
Desconto (10%): -R$15,00
Total após desconto: R$135,00
Frete: R$20,00

=== TOTAL FINAL: R$155,00 ===
```

### Cenário 2: Compra com frete grátis
```
Digite o preço unitário do produto: R$100
Digite a quantidade desejada: 3

--- PROCESSANDO PEDIDO ---
Subtotal: R$300,00
Desconto (10%): -R$30,00
Total após desconto: R$270,00
Frete: Grátis (R$0,00)

=== TOTAL FINAL: R$270,00 ===
```

### Cenário 3: Compra sem desconto
```
Digite o preço unitário do produto: R$30
Digite a quantidade desejada: 2

--- PROCESSANDO PEDIDO ---
Subtotal: R$60,00
Desconto: R$0,00
Total após desconto: R$60,00
Frete: R$20,00

=== TOTAL FINAL: R$80,00 ===
```

## 🔧 Métodos do Sistema

| Método | Descrição | Parâmetros | Retorno |
|--------|-----------|------------|---------|
| `Main()` | Ponto de entrada do programa | - | - |
| `CalcularSubtotal()` | Calcula o subtotal e valida entradas | `preco`, `quantidade` | `double` |
| `AplicarDesconto()` | Aplica 10% de desconto se subtotal > 100 | `subtotal` | `double` |
| `CalcularFrete()` | Calcula frete (R$20 ou grátis) | `subtotal` | `double` |
| `CalcularTotal()` | Orquestra todo o fluxo de cálculo | `preco`, `quantidade` | `double` |
| `CalcularTotalComOut()` | Versão usando parâmetros `out` | `preco`, `quantidade`, `total`, `desconto` | `void` |

## 📝 Regras de Negócio

| Condição | Desconto | Frete |
|----------|----------|-------|
| Subtotal ≤ R$ 100,00 | 0% | R$ 20,00 |
| R$ 100,00 < Subtotal < R$ 200,00 | 10% | R$ 20,00 |
| Subtotal ≥ R$ 200,00 | 10% | Grátis |

## 💻 Comandos Úteis

| Comando | Descrição |
|---------|-----------|
| `dotnet run` | Executa o programa |
| `dotnet build` | Compila o projeto |
| `dotnet clean` | Limpa os arquivos gerados |
| `dotnet build --verbosity detailed` | Compila com detalhes |

## 🎯 Aprendizados

Este projeto demonstra conceitos fundamentais de C#:

- **Métodos** - Organização do código em funções
- **Parâmetros e retornos** - Passagem de dados entre métodos
- **Estruturas condicionais** - `if/else` para regras de negócio
- **Entrada/saída** - `Console.ReadLine()` e `Console.WriteLine()`
- **Validação** - Tratamento de valores negativos
- **Parâmetros `out`** - Retorno de múltiplos valores

## 🔄 Melhorias Futuras

- [ ] Adicionar tratamento de exceções com `try-catch`
- [ ] Implementar diferentes tipos de desconto por categoria
- [ ] Permitir múltiplos produtos no mesmo pedido
- [ ] Salvar histórico de pedidos em arquivo
- [ ] Interface gráfica com Windows Forms ou WPF

## 👨‍💻 Autor

Desenvolvido para atividades práticas de programação em C#.

## 📅 Versão

**Versão 1.0** - 25 de março de 2026

## 📄 Licença

Este projeto é de uso educacional e pode ser livremente utilizado para aprendizado.

---

### 🏷️ Badges

![.NET Version](https://img.shields.io/badge/.NET-10.0-blue)
![C# Version](https://img.shields.io/badge/C%23-10.0-green)
![Console App](https://img.shields.io/badge/Console-App-orange)

---

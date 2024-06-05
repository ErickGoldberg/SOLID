# Princípios SOLID

Os princípios SOLID são um conjunto de diretrizes de design que visam criar software mais compreensível, flexível e de fácil manutenção. SOLID é um acrônimo que representa cinco princípios:

## 1. Single Responsibility Principle (SRP)
**Princípio da Responsabilidade Única**

Uma classe deve ter uma, e apenas uma, razão para mudar. Em outras palavras, uma classe deve ter apenas uma responsabilidade ou propósito.

## 2. Open/Closed Principle (OCP)
**Princípio do Aberto/Fechado**

Entidades de software (classes, módulos, funções, etc.) devem estar abertas para extensão, mas fechadas para modificação. Isso significa que o comportamento de uma classe pode ser estendido sem alterar seu código fonte.

## 3. Liskov Substitution Principle (LSP)
**Princípio da Substituição de Liskov**

Objetos de uma classe base devem poder ser substituídos por objetos de uma classe derivada sem afetar o comportamento do programa. As subclasses devem manter o comportamento esperado da superclasse.

## 4. Interface Segregation Principle (ISP)
**Princípio da Segregação de Interfaces**

Os clientes não devem ser forçados a depender de interfaces que não utilizam. É melhor criar interfaces mais específicas e pequenas do que uma interface única e abrangente.

## 5. Dependency Inversion Principle (DIP)
**Princípio da Inversão de Dependência**

Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações (interfaces). Além disso, abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

---

## Benefícios dos Princípios SOLID

- **Manutenibilidade**: Código mais fácil de manter e evoluir.
- **Reusabilidade**: Componentes de software que podem ser reutilizados em diferentes contextos.
- **Flexibilidade**: Facilidade para adicionar novas funcionalidades.
- **Testabilidade**: Código mais fácil de testar devido ao desacoplamento entre os componentes.

Seguir os princípios SOLID ajuda a evitar código espaguete, promovendo um design de software mais limpo e robusto.

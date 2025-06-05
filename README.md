# Design Patterns with C#  
**Padrões de Projeto com C#**

Este repositório foi criado para organizar e compartilhar implementações de **padrões de projeto** usando **C#**.  
This repository was created to organize and share implementations of **design patterns** using **C#**.

Atualmente, inclui exemplos dos padrões **Abstract Factory** e **Factory Method**, com planos para adicionar mais futuramente.  
Currently, it includes examples of the **Abstract Factory** and **Factory Method** patterns, with plans to add more soon.

---

## 🧱 Padrões Implementados | Implemented Patterns

### 1. Abstract Factory

🇧🇷 O padrão **Abstract Factory** fornece uma interface para criar famílias de objetos relacionados, sem especificar suas classes concretas.  
🇺🇸 The **Abstract Factory** pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

#### 💡 Exemplo / Example:
- 🇧🇷 Simula **métodos de pagamento**, como cartão de crédito e boleto.
- 🇺🇸 Simulates **payment methods**, such as credit card and bank slip.
- 🇧🇷 Aplica **taxas** ou **descontos** conforme o tipo de pagamento.
- 🇺🇸 Applies **fees** or **discounts** depending on the payment type.
- 🇧🇷 Cria objetos relacionados de forma encapsulada.
- 🇺🇸 Encapsulates the creation of related objects.

---

### 2. Factory Method

🇧🇷 O padrão **Factory Method** define uma interface para criação de objetos, permitindo que subclasses decidam qual classe instanciar.  
🇺🇸 The **Factory Method** pattern defines an interface for creating objects, letting subclasses decide which class to instantiate.

#### 💡 Exemplo / Example:
- 🇧🇷 Simula o envio de mensagens via **SMS** ou **E-mail**.  
- 🇺🇸 Simulates sending messages via **SMS** or **Email**.
- 🇧🇷 Criação desacoplada dos tipos de envio com base em uma condição.  
- 🇺🇸 Decoupled creation of message sender types based on a condition.

---

### 3. Builder

🇧🇷 O padrão **Builder** separa a construção de um objeto complexo da sua representação, permitindo que o mesmo processo de construção crie diferentes representações.  
🇺🇸 The **Builder** pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

#### 💡 Exemplo / Example:
- 🇧🇷 Simula a geração de um **relatório personalizado**, com partes opcionais como:
  - Título
  - Cabeçalho
  - Rodapé
  - Gráficos (charts)
- 🇺🇸 Simulates the generation of a **custom report**, with optional parts such as:
  - Title
  - Header
  - Footer
  - Charts

🇧🇷 A construção é realizada passo a passo por um objeto construtor, permitindo flexibilidade e reutilização da lógica.  
🇺🇸 The construction is performed step by step by a builder object, allowing flexibility and reuse of the logic.

### 4. Prototype

🇧🇷 O padrão **Prototype** permite criar novos objetos copiando uma instância existente, em vez de criar do zero. Isso é útil quando a criação de um objeto é custosa ou complexa.  
🇺🇸 The **Prototype** pattern allows you to create new objects by copying an existing instance, rather than building one from scratch. It's useful when object creation is expensive or complex.

#### 💡 Exemplo / Example:
- 🇧🇷 Simula a **clonagem de um documento de fatura** (`InvoiceDocument`) com os dados:
  - `InvoiceNumber`
  - `Amount`
- 🇺🇸 Simulates **cloning an invoice document** (`InvoiceDocument`) with data:
  - `InvoiceNumber`
  - `Amount`

🧾 Saída esperada / Expected output:  
`[Invoice] Number: 12345, Amount: $1,000.00`

🇧🇷 A interface `IPrototype` define o contrato para clonagem, garantindo a criação de cópias independentes.  
🇺🇸 The `IPrototype` interface defines the contract for cloning, ensuring the creation of independent copies.


## 🚧 Em breve | Coming Soon

- Strategy  
- Singleton  
- Adapter  
- Observer  
- E outros... | And more...

---

## 📌 Requisitos | Requirements

- .NET 8 ou superior | .NET 8 or higher  
- Visual Studio 2022 ou compatível | Visual Studio 2022 or compatible

---

## 👨‍💻 Autor | Author

Desenvolvido por / Developed by [Erik Sena](https://github.com/eriksena16)

📬 Fique à vontade para clonar, estudar, adaptar e contribuir com melhorias!  
📬 Feel free to clone, explore, adapt, and contribute to the project!

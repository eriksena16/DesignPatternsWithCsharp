# Design Patterns with C#

This repository was created to organize and share implementations of **design patterns** using **C#**.

At the moment, it includes examples of the **Abstract Factory** and **Factory Method** patterns, with plans to add more patterns in the future.

---

## 🧱 Implemented Patterns

### 1. Abstract Factory

The **Abstract Factory** pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

#### 💡 Implemented Example:
In this project, the Abstract Factory pattern is used to simulate **payment methods**, where different types (such as credit card, pix, or bank slip) have distinct behaviors:

- Application of **fees** or **discounts** depending on the payment type.
- Encapsulated creation of related objects (e.g., payment processors and validators).

This pattern makes it easy to introduce new payment options while maintaining code flexibility and cohesion.

---

### 2. Factory Method

The **Factory Method** pattern defines an interface for creating objects but allows subclasses to alter the type of objects that will be created. It promotes loose coupling and flexibility.

#### 💡 Implemented Example:
The example in this project simulates a **message sending system**, which can operate via:

- **SMS**
- **Email**

A factory class is responsible for creating the appropriate message sender depending on a condition (like user preference or system configuration), keeping the logic decoupled and easy to extend.

---

## 🚧 Coming Soon

- Strategy  
- Singleton  
- Adapter  
- Observer  
- And more...

---

## 📌 Requirements

- .NET 8 or higher  
- Visual Studio 2022 (or any editor compatible with `.sln` files)

---

## 👨‍💻 Author

Developed by [Erik Sena](https://github.com/eriksena16)

Feel free to clone, explore, adapt, and contribute to the project!

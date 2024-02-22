# OOP and SOLID Principles Paint Application

This project is a C#.NET implementation of a basic paint application restructured to follow Object-Oriented Programming (OOP) and SOLID design principles, offering a foundation that is open for extension and modification.

## Overview

The application serves as a digital canvas where users can draw, choose custom colors, and use basic tools like a pen and eraser. Adhering to the SOLID principles ensures that each class and module is designed to be maintainable, scalable, and easily understandable.

## Features

- **Canvas**: A drawable area that registers user input and displays the resulting graphics.
- **Color Picker**: An RGBA color selection tool for custom color creation.
- **Tool Selection**: Switch between drawing and erasing on the canvas.
- **Menu Options**:
  - **Import**: Load existing images onto the canvas for editing.
  - **Save**: Save the current canvas state as an image file.
  - **New Canvas**: Reset the canvas for a new drawing.

## OOP and SOLID Design

- **Single Responsibility Principle**: Each class is designed with a single responsibility, modularizing the code for clarity and maintainability.
- **Open/Closed Principle**: The application is open for extension but closed for modification, allowing new features and tools to be added without altering existing code.
- **Liskov Substitution Principle**: Derived classes can be used interchangeably with their base classes or interfaces.
- **Interface Segregation Principle**: Interfaces are specific to client requirements, ensuring that classes only implement what is necessary.
- **Dependency Inversion Principle**: High-level modules depend on abstractions, not on low-level module details, facilitating decoupling and easier testing.

## Getting Started

Clone the repository to your local machine, and open the solution in Visual Studio. Ensure that .NET Framework is installed on your system.

```bash
git clone https://github.com/YourUsername/OOP-SOLID-Paint-App.git
cd OOP-SOLID-Paint-App
```

![image](https://github.com/AngAnda/PaintApplication/assets/61116472/e52ce4f2-eae4-4ffd-a166-df0da77b9c3a)


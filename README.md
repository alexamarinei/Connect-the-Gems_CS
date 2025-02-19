# Connect the Gems

A puzzle game inspired by classic match-3 games, built with C# in Visual Studio. Connect gems of the same color to score points in this beginner-friendly gaming experience.

## Overview

"Connect the Gems" is a simplified take on the match-3 genre, designed for beginners and puzzle enthusiasts. The game challenges players to create connections between same-colored gems using strategic moves to achieve the highest possible score.

Try the original inspiration here: [Puzzle Playground - Connect the Gems](https://www.puzzleplayground.com/g/connect-the-gems)

## Game Features

- Simple and intuitive gameplay mechanics
- Color-matching puzzle elements
- Score-based progression
- Beginner-friendly interface

## Technical Implementation

The project demonstrates the use of several design patterns to create a maintainable and scalable codebase:

### Singleton Pattern
- Implements randomization functionality
- Ensures single instance management
- Optimizes database connections
- Improves runtime efficiency in larger implementations

### Observer Pattern
- Manages communication between game components
- Implements subscription-based notification system
- Handles color change validations
- Facilitates scoring mechanism updates

### Factory Method Pattern
- Creates game area objects through a unified interface
- Manages three square types:
  - CyanSquare
  - RedSquare
  - LimeSquare
- Enables flexible color customization
- Maintains code readability

## Project Structure

The game is built with a modular architecture:
- Main class handling graphical components and core functionality
- Separate template implementation files
- Organized component hierarchy

### Technical Details

- **Programming Language**: C#
- **Development Environment**: Visual Studio
- **Design Patterns**:
  - Singleton
  - Observer
  - Factory Method



## UML Diagram

[UML diagram to be added]

## References

- [Refactoring Guru - Design Patterns](https://refactoring.guru/design-patterns)
- [DoFactory - Factory Method Pattern](https://www.dofactory.com/net/factory-method-design-pattern)
- [DoFactory - Observer Pattern](https://www.dofactory.com/net/observer-design-pattern)
- [DoFactory - Decorator Pattern](https://www.dofactory.com/net/decorator-design-pattern)
- [DoFactory - Builder Pattern](https://www.dofactory.com/net/builder-design-pattern)



# Classes-Practice-Zoo



This project is a zoo simulation where different animal classes are implemented. The goal is to demonstrate the use of interfaces in object-oriented programming.

## Interfaces

An interface is a programming construct that defines a set of methods or properties that a class must implement. It acts as a contract, specifying the behavior that a class should have. In other words, an interface defines what a class can do, without specifying how it should do it.

In this zoo simulation, the following interfaces are defined:

### 1. `Animal`

This class represents the common behavior of animals in the zoo. It defines methods such as `Eat()`, `Sleep()`, and `Sound()` that any animal should implement.

This interface is implemented by the following classes:

- `Rhino`: Implements `Animal` to define the behavior of a rhinoceros.
- `Monkey`: Implements `Animal & IWalk` to define the behavior of a monkey.
- `Shark`: Implements `Animal & ISwimming` to define the behavior of a shark.
- `Flamingo`: Implements `Animal` to define the behavior of a flamingo.
- `Eagle`: Implements `Animal` to define the behavior of an eagle.



### 2. `IWalk`

This interface represents the behavior of animals that can climb trees. It defines the `ClimbingTree()` method.

This interface is implemented by the `Monkey` class.

### 3. `ISwimmable`

This interface represents the behavior of animals that can swim. It defines the `Swimming()` method.

This interface is implemented by the `Shark` class.

## Diagram

Here is an updated diagram showcasing the interfaces and their implementations in the `Classes_Practice_Zoo` namespace:

```
            +-------------------+
            |     Animal       |
            +-------------------+
            | + Eat()           |
            | + Sleep()         |
            | + Sound()         |
            +-------------------+
                     ^
                     |
                     |
         
 
                     ^
                     |
                     |
            +-------------------+
            |    ISwimmable     |
            +-------------------+
            | + Swimming()      |
            +-------------------+
```
Walk

```
            +-------------------+
            |     Animal       |
            +-------------------+
            | + Eat()           |
            | + Sleep()         |
            | + Sound()         |
            +-------------------+
                     ^
                     |
                     |
            +-------------------+
            |     Monkey        |
            +-------------------+
            | + Eat()           |
            | + Sleep()         |
            | + Sound()         |
            +-------------------+
 
                     ^
                     |
                     |
            +-------------------+
            |      IWalk        |
            +-------------------+
            | +    Walk()       |
            +-------------------+
```




By implementing these interfaces, the classes ensure that they provide the necessary functionality required by the zoo simulation. For example, the `Rhino` class implements `IChargeable` to provide the charging behavior, while the `Monkey` class implements `IClimbable` to allow climbing trees.

The interfaces help in defining a common contract for different animal classes, allowing flexibility and extensibility in the design of the zoo simulation.
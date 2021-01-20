# Lab06/7- Inheritance and Interfaces
401 .Net/C# Review of OOP, Inheritance and Interfaces
### *Authors* David Dicken and Krystian Francuz-Harris *Version*: 1.0.0
## Overview
This lab is a review of OOP in Visual Studio using C#. We created a Zoo that has several layers of inheritance and implements two interfaces across multiple classes.
## Getting Started
Clone down this repo into your terminal, and run the Program.cs and test files in Visual Studio to see how each concrete class has inherited properties and methods from the base class as well as from the implementations.
## Architecture
### OOP Principles
Inheritance: Each child can only directly inherit from its parent class.
Implementation: Allows for properties and methods to be implemented across multiple “generations” and classes.
Abstract Classes and Methods: Define that a class or method exists with required properties and methods.
Concrete Classes: Can be instantiated and are required to inherit abstract properties and methods unless they are overridden.
Virtual methods and properties: Define that a method/property is required, AND what that property or method does.
Override: allows a class to define what an inherited abstract or virtual property/method does.
## Example
	- Inheritance: The Whale class extends the Mammal class. The Mammal class extends the Animal Class. 
	- Implementation: The Penguin class implements the ISwim and IBirdShow implementations, which allow a Penguin to carry out the Swim(); and Routine(); methods.
	- Abstract Classes/Methods: The base class is the Animal class which has required methods and properties. The class, required methods and required properties are all labeled as abstract.
	- Concrete Classes: The Whale class can be instantiated to create new Whales. It is not an abstract class, but must implement abstract/virtual properties and methods unless they are overridden.
	- Virtual Properties/Methods: The BreathesAir property is set to virtual in the Animal class with a required value of true. The Fish class overrides this property and defaults the value to false for the decendants of all Fish.
## UML
[Zoo Lab UML](Zoo.PNG)
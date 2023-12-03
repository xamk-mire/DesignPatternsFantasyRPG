This is a rudamentary implementation of Fantasy RPG game template to illustrate how to use multiple desing patterns in single program

1. Singleton Pattern - Game World
Task: Implement the game world as a Singleton. This ensures that there is only one instance of the game world in the application.
Elements to Include:
- A world map
- A list of NPCs (Non-Player Characters)
- Global game state variables (e.g., time of day)

2. Abstract Factory / Factory Method Pattern - Character Creation
Task: Use the Factory Method pattern to create different character types (e.g., Warrior, Mage, Archer).
Elements to Include:
Base character class with common attributes (health, mana, strength, etc.)
- Specific character classes inheriting from the base class
- Factory class to instantiate characters based on type

3. Observer Pattern - Quest Notification System
Task: Implement the Observer pattern to create a quest notification system.
Elements to Include:
- Quest subjects that players can subscribe to
- Notification system to update players on quest changes (e.g., quest completion, updates)

4. Strategy Pattern - Combat System
Task: Use the Strategy pattern for implementing different combat strategies.
Elements to Include:
- Different combat strategies (e.g., aggressive, defensive, balanced)
- Mechanism to switch strategies during combat

5. Decorator Pattern - Item Enhancements
Task: Implement the Decorator pattern to add enhancements or abilities to items.
Elements to Include:
- Base item class
- Decorators for item enhancements (e.g., fire damage, increased durability)

6. Command Pattern - Action Controls
Task: Use the Command pattern for character actions (e.g., attack, cast spell, use item, movement).
Elements to Include:
- Command interface with execute method
- Concrete command classes for different actions
- Invoker class to process commands

7. State Pattern - Character States
Task: Implement the State pattern to manage character states (e.g., Normal, Poisoned, Paralyzed).
Elements to Include:
- State interface
- Concrete state classes
- Context class to manage state transitions

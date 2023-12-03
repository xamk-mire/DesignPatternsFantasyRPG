namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    // Concrete character classes
    public class Warrior : Character
    {
        public Warrior(string name, int health, int mana) : base(name, health, mana) { }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Warrior with high health and strength.");
        }
    }

    public class Mage : Character
    {
        public Mage(string name, int health, int mana) : base(name, health, mana) { }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Mage with high mana and spell power.");
        }
    }

    public class Archer : Character
    {
        public Archer(string name, int health, int mana) : base(name, health, mana) { }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Archer with high dexterity");
        }
    }
}

namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    // Base NPC class
    public class NPC : Character
    {
        public NPC(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a NPC");
        }
    }

    public class Villager : NPC
    {
        public Villager(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a villager NPC");
        }
    }

    public class Merchant : NPC
    {
        public Merchant(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Merchant NPC");
        }
    }
}

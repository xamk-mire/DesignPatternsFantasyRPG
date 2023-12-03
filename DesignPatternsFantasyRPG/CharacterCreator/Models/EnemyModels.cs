namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    public class Enemy : Character
    {
        public Enemy(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a NPC");
        }
    }

    public class Slime : Enemy
    {
        public Slime(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a slime enemy");
        }
    }

    public class Goblin : Enemy
    {
        public Goblin(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Goblin enemy");
        }
    }

    public class Orc : Enemy
    {
        public Orc(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} is a Orc enemy");
        }
    }

    public class Dragon : Enemy
    {
        public Dragon(string name, int health, int mana) : base(name, health, mana)
        {
        }

        public override void DisplayCharacterInfo()
        {
            Console.WriteLine($"{Name} current health: {Health}");
        }
    }
}

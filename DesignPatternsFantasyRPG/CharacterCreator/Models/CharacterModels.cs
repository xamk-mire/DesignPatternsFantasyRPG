using DesignPatternsFantasyRPG.CharacterStateHandler.Models;
using DesignPatternsFantasyRPG.StatusHandler.Models;

namespace DesignPatternsFantasyRPG.CharacterCreator.Models
{
    // Character base class
    public abstract class Character
    {
        // Hack to generate unique Id's for each character
        private static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        private ICharacterState CharacterState;

        // Constructor
        protected Character(string name, int health = 100, int mana = 100)
        {
            Id = nextId++;
            Name = name;
            Health = health;
            Mana = mana;
            CharacterState = new NormalState();
        }

        // Abstract method for character-specific initialization
        public abstract void DisplayCharacterInfo();

        public void SetState(ICharacterState state)
        {
            CharacterState = state;
        }
        public void ApplyState()
        {
            CharacterState.Handle(this);
        }
    }
}

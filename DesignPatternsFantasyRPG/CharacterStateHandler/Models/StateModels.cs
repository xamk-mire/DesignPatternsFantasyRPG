using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.StatusHandler.Models;

namespace DesignPatternsFantasyRPG.CharacterStateHandler.Models
{
    public class NormalState : ICharacterState
    {
        public void Handle(Character character)
        {
            Console.WriteLine($"{character.Name} is in normal state, fully operational.");
        }
    }

    public class PoisonedState : ICharacterState
    {
        public void Handle(Character character)
        {
            Console.WriteLine($"{character.Name} is poisoned and losing health.");
            // Reducing health over time
        }
    }

    public class ParalyzedState : ICharacterState
    {
        public void Handle(Character character)
        {
            Console.WriteLine($"{character.Name} is paralyzed and cannot move.");
            // Disabling actions
        }
    }
}

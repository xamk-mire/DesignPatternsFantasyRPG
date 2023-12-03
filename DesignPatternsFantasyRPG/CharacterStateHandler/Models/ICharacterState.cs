using DesignPatternsFantasyRPG.CharacterCreator.Models;

namespace DesignPatternsFantasyRPG.StatusHandler.Models
{
    public interface ICharacterState
    {
        void Handle(Character character);
    }
}

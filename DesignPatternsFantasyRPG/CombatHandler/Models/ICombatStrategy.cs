using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.PlayerHandler.Models;

namespace DesignPatternsFantasyRPG.CombatHandler.Models
{
    public interface ICombatStrategy
    {
        void ExecuteStrategy(Player player, Character opponent);
    }
}

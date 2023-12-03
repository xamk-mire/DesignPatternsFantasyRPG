using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.PlayerHandler.Models;

namespace DesignPatternsFantasyRPG.CombatHandler.Models
{
    // Concrete Strategies
    public class AggressiveStrategy : ICombatStrategy
    {
        public void ExecuteStrategy(Player player, Character opponent)
        {
            Console.WriteLine($"{player.Character.Name} attacks {opponent.Name} aggressively!");

            opponent.Health -= player.GetWeaponDamage();

            player.CheckAndCompleteQuest(opponent);
        }
    }

    public class DefensiveStrategy : ICombatStrategy
    {
        public void ExecuteStrategy(Player player, Character opponent)
        {
            Console.WriteLine($"{player.Character.Name} defends against {opponent.Name}'s attacks.");
        }
    }

    public class BalancedStrategy : ICombatStrategy
    {
        public void ExecuteStrategy(Player player, Character opponent)
        {
            Console.WriteLine($"{player.Character.Name} fights {opponent.Name} with a balanced approach.");
        }
    }
}

using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.PlayerHandler.Models;

namespace DesignPatternsFantasyRPG.CommandHandler.Models
{
    public class AttackCommand : ICommand
    {
        private Character opponent;

        public AttackCommand(Character opponent)
        {
            this.opponent = opponent;
        }

        public void Execute(Player player)
        {
            player.EngageCombat(opponent);
        }
    }

    public class CastSpellCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.CastSpell();
        }
    }

    public class UseItemCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.UseItem();
        }
    }
}

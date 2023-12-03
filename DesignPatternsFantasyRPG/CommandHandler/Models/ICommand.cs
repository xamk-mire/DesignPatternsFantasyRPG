using DesignPatternsFantasyRPG.PlayerHandler.Models;

namespace DesignPatternsFantasyRPG.CommandHandler.Models
{
    public interface ICommand
    {
        void Execute(Player player);
    }
}

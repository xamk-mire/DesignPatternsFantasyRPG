using DesignPatternsFantasyRPG.CommandHandler.Models;
using DesignPatternsFantasyRPG.PlayerHandler.Models;

namespace DesignPatternsFantasyRPG.CommandHandler
{
    public class GameController
    {
        private Dictionary<char, ICommand> Commands = new();

        public void SetCommand(char key, ICommand command)
        {
            Commands.Add(key, command);
        }

        public void ExecuteAction(Player player, char key)
        {
            if (Commands != null)
            {
                Commands[key].Execute(player);
            }
        }
    }
}

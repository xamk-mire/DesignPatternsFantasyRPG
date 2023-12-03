using DesignPatternsFantasyRPG.CharacterCreator.Models;

namespace DesignPatternsFantasyRPG.GameWorldModels.Models
{
    public class GameWorld
    {
        // Static variable that holds the single instance
        private static GameWorld _instance;

        // Object used for locking to avoid threading issues
        private static readonly object lockObj = new object();

        // Other attributes of the game world
        private string worldName;
        private Dictionary<string, object> gameMap;
        private List<Character> WorldCharacters;

        // Private constructor to prevent direct instantiation
        private GameWorld()
        {
            worldName = "FantasyLand RPG";
            gameMap = new Dictionary<string, object>();
            WorldCharacters = new List<Character>();
        }

        // Static method to provide global access point
        public static GameWorld Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new GameWorld();
                    }
                    return _instance;
                }
            }
        }

        // Methods to manipulate game world attributes

        // Add new character to the world
        public void AddCharacter(Character character)
        {
            WorldCharacters.Add(character);
        }

        // Remove character from the world
        public void RemoveCharacter(Character character)
        {
            if (WorldCharacters.Any(wc => wc.Id == character.Id))
            {
                WorldCharacters.Remove(character);
            }
        }
    }
}

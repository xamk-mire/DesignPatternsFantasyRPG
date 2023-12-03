using DesignPatternsFantasyRPG.GameWorldModels.Models;
using DesignPatternsFantasyRPG.QuestHandler.Models;
using DesignPatternsFantasyRPG.CharacterCreator;
using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.CombatHandler.Models;
using DesignPatternsFantasyRPG.Enums;
using DesignPatternsFantasyRPG.PlayerHandler.Models;
using DesignPatternsFantasyRPG.Items.Models;
using DesignPatternsFantasyRPG.Items;
using DesignPatternsFantasyRPG.CommandHandler;
using DesignPatternsFantasyRPG.CommandHandler.Models;
using DesignPatternsFantasyRPG.CharacterStateHandler.Models;

namespace DesignPatternsFantasyRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new gameworld
            GameWorld gameWorld = GameWorld.Instance;
            
            CharacterFactory characterCreator = new CharacterCreatorFactory();

            // Create npc
            Character villager = characterCreator.CreateNPC(NPCTypeEnum.Villager, "Farmer", 50, 0);
            gameWorld.AddCharacter(villager);

            // Create player
            Character warrior = characterCreator.CreatePlayerCharacter(CharacterTypeEnum.Warrior, "Conan", 400, 50);
            Player playerOne = new Player(warrior);

            // Create item and add it to the player
            ItemFactory itemFactory = new ItemFactory();
            Item sword = itemFactory.CreateItem(ItemTypeEnum.Weapon, "Steel sword", 100);
            Item enhancedSword = new EnchantedItem(sword);
            playerOne.AddItem(enhancedSword);

            // Create new enemy
            Character dragon = characterCreator.CreateEnemy(EnemyTypeEnum.Dragon, "Silver dragon", 1000, 2000);
            dragon.DisplayCharacterInfo();
            gameWorld.AddCharacter(dragon);

            // Create new quest
            Quest dragonQuest = new Quest("Dragon Hunt", "Defeat the mighty dragon!", dragon);

            // Add new quest to playerOne
            dragonQuest.Subscribe(playerOne);

            // Set combat strategy
            playerOne.SetCombatStrategy(new AggressiveStrategy());

            // Engage combat
            playerOne.EngageCombat(dragon);

            dragon.DisplayCharacterInfo();

            // Controller engagement
            GameController controller = new GameController();
            controller.SetCommand('x', new AttackCommand(dragon));
            controller.ExecuteAction(playerOne, 'x');

            dragon.DisplayCharacterInfo();

            // Simulate ParalyzedState state
            playerOne.Character.SetState(new ParalyzedState());
            playerOne.Character.ApplyState();

            // Needs better combat handler/service
            // Needs enemy interaction / turn base combat
        }
    }
}
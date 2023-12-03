using DesignPatternsFantasyRPG.CharacterCreator.Models;
using DesignPatternsFantasyRPG.CombatHandler.Models;
using DesignPatternsFantasyRPG.Enums;
using DesignPatternsFantasyRPG.Items.Models;
using DesignPatternsFantasyRPG.QuestHandler.Models;

namespace DesignPatternsFantasyRPG.PlayerHandler.Models
{
    public class Player : IQuestObserver
    {
        public Character Character { get; private set; }

        private List<Quest> Quests = new List<Quest>();
        private ICombatStrategy CombatStrategy { get; set; }
        private Loadout Loadout { get; set; }

        public Player(Character character)
        {
            Character = character;
            Loadout = new Loadout();
        }

        public void AddItem(Item item)
        {
            Loadout.Items.Add(item);
        }

        public int GetWeaponDamage()
        {
            return Loadout.Items.FirstOrDefault(item => item.ItemType == ItemTypeEnum.Weapon)?.Value ?? 0;
        }


        public void SetCombatStrategy(ICombatStrategy strategy)
        {
            CombatStrategy = strategy;
        }

        public void EngageCombat(Character opponent)
        {
            if (CombatStrategy == null)
            {
                Console.WriteLine($"{Character.Name} has no combat strategy set.");
                return;
            }
            CombatStrategy.ExecuteStrategy(this, opponent);
        }

        public void AddQuest(Quest quest)
        {
            Quests.Add(quest);
            quest.Subscribe(this);
        }

        public void CheckAndCompleteQuest(Character opponent)
        {
            // Example condition to complete a quest
            if (opponent.Health <= 0)
            {
                if (Quests.Count > 0)
                {
                    Quests.FirstOrDefault(quest => quest.Opponent == opponent)?.CompleteQuest();
                }
            }
        }

        public void Update(Quest quest)
        {
            Console.WriteLine($"{Character.Name} notified about quest '{quest.Name}': Completed - {quest.IsCompleted}");
        }

        public void CastSpell()
        {
            Console.WriteLine($"Cast a spell");
            // Spell casting logic
        }

        public void UseItem()
        {
            Console.WriteLine($"Use an item");
        }
    }
}

using DesignPatternsFantasyRPG.Enums;
using DesignPatternsFantasyRPG.Items.Models;

namespace DesignPatternsFantasyRPG.Items
{
    // Item factory
    public class ItemFactory
    {
        public Item CreateItem(ItemTypeEnum type, string name, int value)
        {
            switch (type)
            {
                case ItemTypeEnum.Weapon:
                    return new Weapon(name, value);
                case ItemTypeEnum.Defence:
                     throw new NotImplementedException();
                case ItemTypeEnum.Health:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentException("Invalid character type.");
            }
        }
    }
}

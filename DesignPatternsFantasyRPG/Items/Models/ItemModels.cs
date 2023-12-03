using DesignPatternsFantasyRPG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFantasyRPG.Items.Models
{
    public abstract class Item
    {
        public abstract string Name { get; set; }
        public abstract ItemTypeEnum ItemType { get; }
        public abstract int Value { get; set; }
        public abstract void Display();
    }

    public class Weapon : Item
    {
        public Weapon(string name, int value) 
        {
            Name = name;
            Value = value;
        }
        public override string Name { get; set; }
        public override ItemTypeEnum ItemType => ItemTypeEnum.Weapon;
        public override int Value { get; set; } = 100;

        public override void Display()
        {
            Console.WriteLine($"Item name {Name}");
        }
    }

    public abstract class ItemDecorator : Item
    {
        protected Item item;

        public ItemDecorator(Item item)
        {
            this.item = item;
        }

        public override string Name
        {
            get => item.Name;
            set => item.Name = value;
        }
        public override ItemTypeEnum ItemType => item.ItemType;
        public override int Value
        {
            get => item.Value;
            set => item.Value = value;
        }

        public override void Display()
        {
            item.Display();
        }
    }

    public class EnchantedItem : ItemDecorator
    {
        public EnchantedItem(Item item) : base(item) 
        {
            item.Value += 50;
            item.Name = "Enhanced " + item.Name;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("It glows with a magical aura.");
        }
    }

    public class FireEnchantment : ItemDecorator
    {
        public FireEnchantment(Item item) : base(item)
        {
            item.Value += 100;
            item.Name = "Fire " + item.Name;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("It's engulfed in flames.");
        }
    }
}

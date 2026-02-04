using Dota3.Interfaces;

namespace Dota3.Classes.Items
{
    internal class HealingPotion : IItem
    {
        public string Name { get; private set; }

        public HealingPotion()
        {
            Name = "Healing Potion";
        }

        public void Use(IHero hero)
        {
            Console.WriteLine($"{hero.Name} drinks a healing potion and restores health!");
            hero.Health += 20;
        }
    }
}

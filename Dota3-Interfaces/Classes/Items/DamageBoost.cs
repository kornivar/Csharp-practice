using Dota3.Interfaces;

namespace Dota3.Classes.Items
{
    internal class DamageBoost : IItem
    {
        public string Name { get; private set; }

        public DamageBoost()
        {
            Name = "Damage Boost";
        }

        public void Use(IHero hero)
        {
            Console.WriteLine($"{hero.Name} increases attack damage!");
            hero.Damage += 10;
        }
    }
}

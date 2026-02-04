using Dota3.Interfaces;

namespace Dota3.Classes.Heroes
{
    internal class Axe : IHero
    {
        public string Name { get; private set; }
        public string Faction { get; private set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public IItem[] Items { get; set; }

        public Axe()
        {
            Name = "Axe";
            Faction = "Radiant";
            Health = 120;
            Damage = 30;
            Items = new IItem[3];
        }

        public void Attack(IHero target)
        {
            Console.WriteLine($"{Name} chops {target.Name}");
            target.Health -= Damage;
        }

        public void UseUltimate(IHero target)
        {
            Console.WriteLine($"{Name} uses Culling Blade on {target.Name}");
            target.Health -= 60;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} ({Faction}) — Health: {Health}");
        }
    }
}

using Dota3.Interfaces;
namespace Dota3.Classes.Heroes
{
    internal class CrystalMaiden : IHero
    {
        public string Name { get; private set; }
        public string Faction { get; private set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public IItem[] Items { get; set; }

        public CrystalMaiden()
        {
            Name = "Crystal Maiden";
            Faction = "Radiant";
            Health = 90;
            Damage = 20;
            Items = new IItem[3];
        }

        public void Attack(IHero target)
        {
            Console.WriteLine($"{Name} deals {Damage} magical damage to {target.Name}");
            target.Health -= Damage;
        }

        public void UseUltimate(IHero target)
        {
            Console.WriteLine($"{Name} uses Freezing Field");
            target.Health -= 40;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} ({Faction}) — Health: {Health}");
        }
    }
}

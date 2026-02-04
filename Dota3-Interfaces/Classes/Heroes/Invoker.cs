using Dota3.Interfaces;
namespace Dota3.Classes.Heroes
{
    internal class Invoker : IHero
    {
        public string Name { get; private set; }
        public string Faction { get; private set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public IItem[] Items { get; set; }

        public Invoker()
        {
            Name = "Invoker";
            Faction = "Dire";
            Health = 100;
            Damage = 25;
            Items = new IItem[3];
        }

        public void Attack(IHero target)
        {
            Console.WriteLine($"{Name} deals {Damage} damage to {target.Name}");
            target.Health -= Damage;
        }

        public void UseUltimate(IHero target)
        {
            Console.WriteLine($"{Name} uses Sun Strike on {target.Name}");
            target.Health -= 50;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} ({Faction}) — Health: {Health}");
        }
    }
}

using Dota3.Interfaces;
namespace Dota3.Classes.Items
{
    internal class BlinkDagger : IItem
    {
        public string Name { get; private set; }

        public BlinkDagger()
        {
            Name = "Blink Dagger";
        }

        public void Use(IHero hero)
        {
            Console.WriteLine($"{hero.Name} blinks to a new position!");
        }
    }
}

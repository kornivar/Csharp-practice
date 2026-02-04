using Dota3.Interfaces;

namespace Dota3.Classes.Skills
{
    internal class Heal : ISkill
    {
        public string Name { get; private set; }

        public Heal()
        {
            Name = "Heal";
        }

        public void Cast(IHero caster, IHero target)
        {
            Console.WriteLine($"{caster.Name} heals {target.Name}");
            target.Health += 25;
        }
    }
}

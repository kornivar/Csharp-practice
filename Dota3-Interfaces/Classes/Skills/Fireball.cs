using Dota3.Interfaces;

namespace Dota3.Classes.Skills
{
    internal class Fireball : ISkill
    {
        public string Name { get; private set; }

        public Fireball()
        {
            Name = "Fireball";
        }

        public void Cast(IHero caster, IHero target)
        {
            Console.WriteLine($"{caster.Name} casts {Name} on {target.Name}");
            target.Health -= 30;
        }
    }
}

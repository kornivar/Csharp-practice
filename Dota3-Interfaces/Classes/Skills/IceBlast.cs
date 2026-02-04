using Dota3.Interfaces;

namespace Dota3.Classes.Skills
{
    internal class IceBlast : ISkill
    {
        public string Name { get; private set; }

        public IceBlast()
        {
            Name = "Ice Blast";
        }

        public void Cast(IHero caster, IHero target)
        {
            Console.WriteLine($"{caster.Name} freezes {target.Name} with {Name}");
            target.Health -= 20;
        }
    }
}

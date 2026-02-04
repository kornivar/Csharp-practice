namespace Dota3.Interfaces
{
    public interface ISkill
    {
        string Name { get; }
        void Cast(IHero caster, IHero target);
    }
}

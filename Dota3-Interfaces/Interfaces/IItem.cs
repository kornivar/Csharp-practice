namespace Dota3.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        void Use(IHero hero);
    }
}

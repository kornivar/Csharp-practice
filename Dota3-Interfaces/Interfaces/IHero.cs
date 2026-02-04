namespace Dota3.Interfaces
{
    public interface IHero
    {
        public string Name { get; }
        public string Faction { get; }
        int Health { get; set; }
        int Damage { get; set; }
        IItem[] Items { get; set; }

        void Attack(IHero target);
        void UseUltimate(IHero target);
        void ShowInfo();
    }
}

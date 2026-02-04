using Dota3.Interfaces;
namespace Dota3.Classes
{
    internal class BattleArena 
    {
        public IHero[] Heroes { get; set; }

        public BattleArena(IHero[] heroes)
        {
            Heroes = heroes;
        }

        public void StartBattle()
        {
            Random rnd = new Random();
            int turn = 0;

            Console.WriteLine("=== Battle begins! ===\n");

            while (AliveCount(Heroes) > 1)
            {
                foreach (var hero in Heroes)
                {
                    if (hero.Health <= 0) continue;

                    IHero target;
                    do
                    {
                        target = Heroes[rnd.Next(Heroes.Length)];
                    } while (target == hero || target.Health <= 0);

                    if (rnd.Next(0, 5) == 0 && hero.Items[0] != null)
                        hero.Items[rnd.Next(hero.Items.Length)]?.Use(hero);
                    else if (turn % 3 == 0)
                        hero.UseUltimate(target);
                    else
                        hero.Attack(target);

                    if (target.Health <= 0)
                        Console.WriteLine($"{target.Name} has fallen!");

                    Console.WriteLine();
                }

                Console.WriteLine("--- Current hero status ---");
                foreach (var h in Heroes)
                    h.ShowInfo();
                Console.WriteLine("---------------------------\n");

                turn++;
            }

            Console.WriteLine("=== Battle finished! ===");
            foreach (var h in Heroes)
                if (h.Health > 0)
                    Console.WriteLine($"Winner: {h.Name} ({h.Faction})!");
        }

        private int AliveCount(IHero[] heroes)
        {
            int count = 0;
            foreach (var h in heroes)
                if (h.Health > 0) count++;
            return count;
        }
    }
}

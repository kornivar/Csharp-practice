using Dota3.Classes;
using Dota3.Classes.Heroes;
using Dota3.Classes.Items;
using Dota3.Interfaces;

IHero[] heroes = { new Invoker(), new Axe(), new CrystalMaiden() };

heroes[0].Items[0] = new BlinkDagger();
heroes[0].Items[1] = new DamageBoost();

heroes[1].Items[0] = new HealingPotion();
heroes[2].Items[0] = new DamageBoost();

BattleArena arena = new BattleArena(heroes);
arena.StartBattle();
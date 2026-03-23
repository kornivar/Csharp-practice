abstract class GameAI
{
    public int solidersCount;
    public int tanksCount;
    public int shellsCount;

    public void TakeTurn()
    {
        UseArtillery();
        UseTanks();
        UseSoliders();
        HelpWounded();
    }

    public abstract void UseArtillery();

    public abstract void UseTanks();

    public void UseSoliders()
    {
        Console.WriteLine("The infantry charges.");
    }

    public abstract void HelpWounded();
}


class Humans : GameAI
{
    public override void HelpWounded()
    {
        Console.WriteLine("Humans are helping the wounded.");
    }

    public override void UseArtillery()
    {
        Console.WriteLine("Humans are using artillery.");
    }

    public override void UseTanks()
    {
        Console.WriteLine("Tanks are pushing forward.");
    }
}

class Robots : GameAI
{
    public override void HelpWounded()
    {
        Console.WriteLine("Robots are repairing themselves and gathering the remaining spare parts.");
    }

    public override void UseArtillery()
    {
        Console.WriteLine("Robots are using orbital bombardment.");
    }

    public override void UseTanks()
    {
        Console.WriteLine("Robotic tanks are pushing forward.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        GameAI humans = new Humans();
        GameAI robots = new Robots();
        Console.WriteLine("Humans' turn:");
        humans.TakeTurn();
        Console.WriteLine("\nRobots' turn:");
        robots.TakeTurn();
    }
}
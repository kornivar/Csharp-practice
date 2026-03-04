public class ColaFacade
{
    private readonly ColaMachine _colaMachine;
    public ColaFacade()
    {
        _colaMachine = new ColaMachine();
    }
    public string OrderCola()
    {
        string result = "ColaMashine(facade) initializes subsystems:\n";
        result += _colaMachine.isWater();
        result += _colaMachine.isSyrup();

        result += "\nColaMashine(facade) orders subsystems to perform the action:\n";
        result += _colaMachine.FillWater();
        result += _colaMachine.AddSyrup();
        result += _colaMachine.Chill();
        return result;
    }
}

public class ColaMachine
{
    public string isWater()
    {
        return "Checking if water is available...\n";
    }

    public string isSyrup()
    {
        return "Checking if syrup is available...\n";
    }

    public string FillWater()
    {
        return "Filling water...\n";
    }

    public string AddSyrup()
    {
        return "Adding syrup...\n";
    }

    public string Chill()
    {
        return "Chilling the cola...\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ColaFacade colaFacade = new ColaFacade();
        string result = colaFacade.OrderCola();
        Console.WriteLine(result);
    }
}
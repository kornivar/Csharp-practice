public class ColaMashine
{
    private readonly WaterDispensing _waterDispensing;
    private readonly SyrupDispensing _syrupDispensing;
    private readonly Chilling _chilling;

    public ColaMashine()
    {
        _waterDispensing = new WaterDispensing();
        _syrupDispensing = new SyrupDispensing();
        _chilling = new Chilling();
    }
    public string OrderCola()
    {
        string result = "ColaMashine(facade) initializes subsystem:\n";
        result += _waterDispensing.isWater();
        result += _syrupDispensing.isSyrup();

        result += "\nColaMashine(facade) orders subsystem to perform the action:\n";
        result += _waterDispensing.FillWater();
        result += _syrupDispensing.AddSyrup();
        result += _chilling.Chill();
        return result;
    }
}

public class WaterDispensing
{
    public string isWater()
    {
        return "WaterDispensing: Checking water supply...\n";
    }
    public string FillWater()
    {
        return "WaterDispensing: Filling water...\n";
    }
}

public class SyrupDispensing
{
    public string isSyrup()
    {
        return "SyrupDispensing: Checking syrup supply...\n";
    }
    public string AddSyrup()
    {
        return "SyrupDispensing: Adding syrup...\n";
    }
}

public class Chilling
{
    public string Chill()
    {
        return "Chilling: Chilling the cola...\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ColaMashine colaFacade = new ColaMashine();
        string result = colaFacade.OrderCola();
        Console.WriteLine(result);
    }
}
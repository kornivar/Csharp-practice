public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ITable CreateTable();
}

class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }
    public ISofa CreateSofa()
    {
       return new ModernSofa();
    }
    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }
    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
    public ITable CreateTable()
    {
        return new VictorianTable();
    }
}

public interface IChair
{
    void SitOn();
}

public interface ISofa
{
    void LieOn();
}

public interface ITable
{
    void Use();
}

class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}

class ModernSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a modern sofa.");
    }
}

class ModernTable : ITable
{
    public void Use()
    {
        Console.WriteLine("Using a modern table.");
    }
}

class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}

class VictorianSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a Victorian sofa.");
    }
}

class VictorianTable : ITable
{
    public void Use()
    {
        Console.WriteLine("Using a Victorian table.");
    }
}

class Program
{
    static void Main()
    {
        IFurnitureFactory modernFactory = new ModernFurnitureFactory();
        IChair modernChair = modernFactory.CreateChair();
        ISofa modernSofa = modernFactory.CreateSofa();
        ITable modernTable = modernFactory.CreateTable();
        modernChair.SitOn();
        modernSofa.LieOn();
        modernTable.Use();

        Console.WriteLine();

        IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
        IChair victorianChair = victorianFactory.CreateChair();
        ISofa victorianSofa = victorianFactory.CreateSofa();
        ITable victorianTable = victorianFactory.CreateTable();
        victorianChair.SitOn();
        victorianSofa.LieOn();
        victorianTable.Use();
    }
}
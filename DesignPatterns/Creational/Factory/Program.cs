
public interface IDelivaryOrder
{
    string GetDeliverTime();
    string GetTransportType();
    string GetPackageType();
}

abstract class Creator
{
    public abstract IDelivaryOrder CreateDelivaryOrder();

    public string CheckDelivaryInformation()
    {
        var delivary_order = CreateDelivaryOrder();

        var result = "Transport type used: "+ delivary_order.GetTransportType()+"\nPackage type: "+ delivary_order.GetPackageType()
            +"\nEstimated delivery time: "+delivary_order.GetDeliverTime();

        return result;
    }
}

class AirTransport : Creator
{
    public override IDelivaryOrder CreateDelivaryOrder()
    {
        return new AirDelivaryOrder();
    }
}

class AirDelivaryOrder : IDelivaryOrder
{
    public string GetDeliverTime()
    {
        return "2-3 days";
    }
    public string GetPackageType()
    {
        return "Small and medium packages";
    }
    public string GetTransportType()
    {
        return "Air transport";
    }
}


class SeaTransport : Creator
{
    public override IDelivaryOrder CreateDelivaryOrder()
    {
        return new SeaDelivaryOrder();
    }
}

class SeaDelivaryOrder : IDelivaryOrder
{
    public string GetDeliverTime()
    {
        return "5-7 days";
    }
    public string GetPackageType()
    {
        return "Large packages";
    }
    public string GetTransportType()
    {
        return "Sea transport";
    }
}

class GroundTransport : Creator
{
    public override IDelivaryOrder CreateDelivaryOrder()
    {
        return new GroundDelivaryOrder();
    }
}

class GroundDelivaryOrder : IDelivaryOrder
{
    public string GetDeliverTime()
    {
        return "3-5 days";
    }
    public string GetPackageType()
    {
        return "Small and medium packages";
    }
    public string GetTransportType()
    {
        return "Ground transport";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Creator creator = new AirTransport();
        Console.WriteLine(creator.CheckDelivaryInformation() + "\n");
        creator = new SeaTransport();
        Console.WriteLine(creator.CheckDelivaryInformation() + "\n");
        creator = new GroundTransport();
        Console.WriteLine(creator.CheckDelivaryInformation() + "\n");
    }
}
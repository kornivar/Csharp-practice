// Interface used by the client code
public interface IPhoneCharger
{
    void ChargePhone();
}


// The Adaptee contains some useful behavior, but its interface is
// incompatible with the existing client code. The Adaptee needs some
// adaptation before the client code can use it.
public class WallSocket
{
    public int GetElectricity()
    {
        return 220;
    }
}


// The Adapter makes the Adaptee's interface compatible with the WallSocket's interface.
public class ChargerAdapter : IPhoneCharger
{
    private readonly WallSocket _socket;

    public ChargerAdapter(WallSocket socket)
    {
        _socket = socket;
    }

    public void ChargePhone()
    {
        int voltage = _socket.GetElectricity();
        Console.WriteLine($"Socket gives {voltage}V");

        int phoneVoltage = 5;
        Console.WriteLine($"Adapter converts {voltage}V to {phoneVoltage}V");
        Console.WriteLine("Phone is charging...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        WallSocket socket = new WallSocket();
        IPhoneCharger charger = new ChargerAdapter(socket);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.\n");

        charger.ChargePhone();
    }
}
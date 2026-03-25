public interface IHandler
{
    IHandler SetNext(IHandler handler);
    string Handle(string request);
}


abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual string Handle(string request)
    {
        if (_nextHandler != null)
            return _nextHandler.Handle(request);
        return null;
    }
}


class TeamLeadHandler : AbstractHandler
{
    public override string Handle(string request)
    {
        if (request.Contains("Deadline") || request.Contains("Task"))
            return $"TeamLead: I'll handle the request about '{request}'.\n";
        return base.Handle(request);
    }
}


class ManagerHandler : AbstractHandler
{
    public override string Handle(string request)
    {
        if (request.Contains("Budget") || request.Contains("Resource"))
            return $"Manager: I'll take care of the '{request}'.\n";
        return base.Handle(request);
    }
}


class DirectorHandler : AbstractHandler
{
    public override string Handle(string request)
    {
        if (request.Contains("Strategy") || request.Contains("Policy"))
            return $"Director: I'll address the '{request}'.\n";
        return base.Handle(request);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var teamLead = new TeamLeadHandler();
        var manager = new ManagerHandler();
        var director = new DirectorHandler();

        teamLead.SetNext(manager).SetNext(director);

        string[] requests = {
            "Deadline for project X",
            "Budget for project Y",
            "Company Strategy for next year",
            "Resource allocation for project Z"
        };

        foreach (var request in requests)
        {
            Console.WriteLine($"Client: Who can handle '{request}'?");
            var result = teamLead.Handle(request);
            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine($"Client: No one can handle '{request}'.\n");
        }
    }
}
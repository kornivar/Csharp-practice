public interface IComponent
{
    void Accept(IVisitor visitor);
}

public class ConcreteComponentA : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }

    public string ExclusiveMethodOfConcreteComponentA()
    {
        return "A";
    }
}


public class ConcreteComponentB : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentB(this);
    }

    public string SpecialMethodOfConcreteComponentB()
    {
        return "B";
    }
}


public interface IVisitor
{
    void VisitConcreteComponentA(ConcreteComponentA element);

    void VisitConcreteComponentB(ConcreteComponentB element);
}


class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
    }
}


class ConcreteVisitor2 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
    }
}


class Program
{
    static void Main(string[] args)
    {
        IComponent[] components = new IComponent[]
        {
            new ConcreteComponentA(),
            new ConcreteComponentB()
        };

        Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
        ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
        foreach (IComponent component in components)
        {
            component.Accept(visitor1);
        }

        Console.WriteLine();

        Console.WriteLine("It allows the same client code to work with different types of visitors:");
        ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
        foreach (IComponent component in components)
        {
            component.Accept(visitor2);
        }
    }
}



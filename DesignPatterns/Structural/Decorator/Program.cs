public abstract class Notifier
{
    public abstract void Notify(string message);
}

class ConcreteNotifier : Notifier
{
    public override void Notify(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}

public abstract class NotifierWrapper : Notifier
{
    protected readonly Notifier _notifier;
    public NotifierWrapper(Notifier notifier)
    {
        _notifier = notifier;
    }
    public override void Notify(string message)
    {
        _notifier.Notify(message);
    }
}

class EmailNotifierWrapper : NotifierWrapper
{
    public EmailNotifierWrapper(Notifier notifier) : base(notifier) { }
    private void SendEmail(string message)
    {
        Console.WriteLine($"Sending email with message: {message}");
    }
    public override void Notify(string message)
    {
        base.Notify(message);
        SendEmail(message);
    }
}

class Program
{
    static void Main()
    {
        Notifier notifier = new ConcreteNotifier();
        notifier.Notify("Hello, World!");

        Console.WriteLine("\n--Using Email Notifier Wrapper--\n");

        Notifier emailNotifier = new EmailNotifierWrapper(notifier);
        emailNotifier.Notify("Hello, World!");
    }
}
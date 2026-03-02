Singleton singleton = Singleton.GetInstance();
singleton.ShowMessage();

class Singleton
{
    private static Singleton? instance = null;

    private Singleton()
    { 
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}

public interface IThirdPartyYouTubeLib
{
    void ListVideos();
    void GetVideoInfo(int id);
    void UploadVideo(string title);
}


class RealYouTubeCLass  : IThirdPartyYouTubeLib
{
    public void ListVideos()
    {
        Console.WriteLine("RealSubject: ListVideos\n");
    }

    public void GetVideoInfo(int id)
    {
        Console.WriteLine("RealSubject: GetVideoInfo for video " + id + "\n");
    }

    public void UploadVideo(string title)
    {
        Console.WriteLine("RealSubject: UploadVideo with title " + title + "\n");
    }
}


class Proxy : IThirdPartyYouTubeLib
{
    private RealYouTubeCLass _realYouTubeCLass;

    public Proxy(RealYouTubeCLass realYouTubeCLass)
    {
        this._realYouTubeCLass = realYouTubeCLass;
    }

    public void ListVideos()
    {
        if (this.CheckAccess())
        {
            this._realYouTubeCLass.ListVideos();
            this.LogAccess();
        }
    }

    public void GetVideoInfo(int id)
    {
        if (this.CheckAccess())
        {
            this._realYouTubeCLass.GetVideoInfo(id);
            this.LogAccess();
        }
    }

    public void UploadVideo(string title)
    {
        if (this.CheckAccess())
        {
            this._realYouTubeCLass.UploadVideo(title);
            this.LogAccess();
        }
    }

    public bool CheckAccess()
    {
        Console.WriteLine("Proxy: Checking access prior to firing a real request.\n");

        return true;
    }

    public void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request.\n");
    }
}

public class Client
{
    public void ClientCode(IThirdPartyYouTubeLib subject)
    {
        subject.ListVideos();
        subject.GetVideoInfo(123);
        subject.UploadVideo("My cat video");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        Console.WriteLine("Client: Executing the client code with a real subject:\n");
        RealYouTubeCLass realSubject = new RealYouTubeCLass();
        client.ClientCode(realSubject);

        Console.WriteLine("--------------------------------------------------------\n");

        Console.WriteLine("Client: Executing the same client code with a proxy:\n");
        Proxy proxy = new Proxy(realSubject);
        client.ClientCode(proxy);
    }
}

using Youtube;

class Program
{
    public static void Main(string[] args)
    {
        YoutubeManager manager = new(new YoutubeCache(new YoutubeService()));

        manager.DownloadVideo("Titanic");
    }
}
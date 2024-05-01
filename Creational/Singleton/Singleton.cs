class Singleton
{
    private static Singleton? Instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        Instance ??= new Singleton();

        return Instance;
    }
}
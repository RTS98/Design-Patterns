using DataSource;

class Program
{
    public static void Main(string[] args)
    {
        IDataSource source = new FileDataSource("file.txt");
        source.WriteData("Hello World");

        source = new EncryptionDecorator(source);
        source.WriteData("Hello World");
    }
}
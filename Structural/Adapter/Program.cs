using Convertors;

class Program
{
    public static void Main(string[] args)
    {
        IConvertor convertor = new Convertor();

        string json =  @"{ 
            'id': 1,
            'Name': 'Robert'
        }";
        string result = convertor.JSONToXML(json);

        Console.WriteLine(result);
    }
}
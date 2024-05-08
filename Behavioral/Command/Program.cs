using Commands;
using Editors;

class Program
{
    public static void Main(string[] args)
    {
        Editor editor = new();

        SaveCommand saveCommand = new(editor);

        saveCommand.Execute();
    }
}
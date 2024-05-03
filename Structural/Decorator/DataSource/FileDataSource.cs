namespace DataSource
{
    class FileDataSource(string name) : IDataSource
    {
        private readonly string FileName = name;

        public string ReadData()
        {
            return "Reading data from file";
        }

        public void WriteData(string data)
        {
            Console.WriteLine($"Write {data} to file");
        }
    }
}
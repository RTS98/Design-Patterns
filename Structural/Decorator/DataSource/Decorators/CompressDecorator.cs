namespace DataSource
{
    class CompressDecorator(IDataSource source) : DataSourceDecorator(source)
    {
        public override string ReadData()
        {
            DecoratedSource.ReadData();
            Console.WriteLine("Decompress data");

            return "";
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("Compressing data");
            DecoratedSource.WriteData(data);
        }
    }
}
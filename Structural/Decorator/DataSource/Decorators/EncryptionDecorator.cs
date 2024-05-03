namespace DataSource
{
    class EncryptionDecorator(IDataSource source) : DataSourceDecorator(source)
    {
        public override string ReadData()
        {
            DecoratedSource.ReadData();
            Console.WriteLine("Decrypting data");

            return "";
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("Crypting data");
            DecoratedSource.WriteData(data);
        }
    }
}
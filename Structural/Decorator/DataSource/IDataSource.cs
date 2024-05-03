namespace DataSource
{
    interface IDataSource
    {
        void WriteData(string data);

        string ReadData();
    }
}
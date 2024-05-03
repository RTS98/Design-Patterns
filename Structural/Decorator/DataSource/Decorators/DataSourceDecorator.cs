namespace DataSource
{
    class DataSourceDecorator(IDataSource source) : IDataSource
    {
        protected IDataSource DecoratedSource = source;

        public virtual string ReadData() => DecoratedSource.ReadData();

        public virtual void WriteData(string data) => DecoratedSource.WriteData(data);
    }
}
namespace Patterns.AbstractFactory
{
    // The Client class.
    public class DataSource
    {
        private IData _data;

        public DataSource(DataType dataType)
        {
            IDataFactory factory;
            switch (dataType)
            {
                case DataType.File:
                    factory = new DataFromFile();
                    _data = factory.CreateData();
                    break;
                case DataType.DB:
                    factory = new DataFromDB();
                    _data = factory.CreateData();
                    break;
            }
        }

        public string GetDataFromSource()
        {
            return _data.GetData();
        }
    }
}

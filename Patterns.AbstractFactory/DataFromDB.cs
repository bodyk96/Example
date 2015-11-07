namespace Patterns.AbstractFactory
{
    // The Concrete Factory #1 class.
    public class DataFromDB : IDataFactory
    {
        public IData CreateData()
        {
            // IMPLEMENT YOUR LOGIC
            return new Data("DataBase source");
        }
    }
}

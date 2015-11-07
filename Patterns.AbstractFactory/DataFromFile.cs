namespace Patterns.AbstractFactory
{
    // The Concrete Factory #2 class.
    public class DataFromFile : IDataFactory
    {
        public IData CreateData()
        {
            // IMPLEMENT YOUR LOGIC
            return new Data("File source");
        }
    }
}

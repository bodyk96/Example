namespace Patterns.AbstractFactory
{
    // The Item class.
    public class Data : IData
    {
        private string _value;

        public Data(string value)
        {
            _value = value;
        }

        public string GetData()
        {
            return _value;
        }
    }
}

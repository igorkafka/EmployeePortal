
using Web.Factory.Abstract_Product;
using static Web.Factory.Abstract_Factory.Enumerations;

namespace Web.Factory.Concrete_Product
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }
    class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }
}
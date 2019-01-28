using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Factory.Abstract_Factory;
using Web.Factory.Abstract_Interface;
using Web.Factory.Abstract_Product;
using Web.Factory.Concrete_Product;

namespace Web.Factory.Concrete_Factory
{
    public class DELLFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class DELLLeptopFactory: DELLFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
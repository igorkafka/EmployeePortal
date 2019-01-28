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
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Factory.Abstract_Product;

namespace Web.Factory.Abstract_Interface
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}

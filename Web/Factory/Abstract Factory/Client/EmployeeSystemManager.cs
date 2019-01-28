using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Factory.Abstract_Factory;
using Web.Factory.Abstract_Interface;
using Web.Factory.Abstract_Product;

namespace Web.Factory.Client
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory IComputerFactory)
        {
            _IComputerFactory = IComputerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = _IComputerFactory.Brand();
            IProcessor processor = _IComputerFactory.Processor();
            ISystemType systemType = _IComputerFactory.SystemType();
            string returnValue = string.Format($"{brand.GetBrand()} - {processor.GetProcessor()} - {systemType.GetSystemType()}");
            return returnValue;
      
        }
    }
}
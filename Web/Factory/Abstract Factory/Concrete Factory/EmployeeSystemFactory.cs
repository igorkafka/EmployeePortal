using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Factory.Abstract_Factory;
using Web.Factory.Abstract_Interface;
using Web.Models;

namespace Web.Factory.Concrete_Factory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory returnValue = null;
            if (employee.EmployeeTypeID == 1)
            {
                if (employee.JobDescription.Contains("Manager"))
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MacFactory();
                }
            }
            else if (employee.EmployeeTypeID == 2)
            {
                if (employee.JobDescription.Contains("Manager"))
                {
                    returnValue = new DELLLeptopFactory();
                }
                else
                {
                    returnValue = new DELLFactory();
                }
            }
            return returnValue;
        }
    }
}
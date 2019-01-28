using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.Factory_Method
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee employee)
        {
            _emp = employee;
        }
        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = this.Create();
            _emp.Bonus = employeeManager.GetBonus();
            _emp.HourlyPay = employeeManager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
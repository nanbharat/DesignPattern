using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;


        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeManger manger = this.Create();
            _emp.Bounes = manger.GetBonus();
            _emp.HourlyPay = manger.GetPay();
            return _emp;
        }

        public abstract IEmployeeManger Create();


    }
}
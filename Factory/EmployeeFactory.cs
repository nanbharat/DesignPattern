using Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory
{
    public class EmployeeFactory
    {
        public static BaseEmployeeFactory GetFactory(Employee emp)
        {

            BaseEmployeeFactory empfactory = null;

            if( emp.EmployeeTypeId == 1)
            {
                return empfactory = new ParmanentEmployeeFactory(emp);
            }

            return empfactory = new ContractEmployeeFactory(emp);

        }





    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models
{
    public class EmployeeMangerFactory
    {
        public static IEmployeeManger GetEmployeeFactoryObject(int id)
        {
            IEmployeeManger returnVal = null;
            
            if( id == 1)
            {
                returnVal = new PermanentEmployeeManger();
            }
            else if( id == 2)
            {
                returnVal = new ContractEmployeeManger();
            }

            return returnVal;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.AbstractFactory
{
    public  class EmployeeSystemFactory
    {

        public static IComputerFactory create(Employee e)
        {
            IComputerFactory returnvalue = null;

            if (e.EmployeeTypeId == 1)
            {
                if (e.Jobdescription.ToLower() == "manger")
                {
                    return returnvalue = new MacLaptopfactory();
                }
                else
                {
                    return returnvalue = new MacFactory();
                }
            }
            else if( e.EmployeeTypeId == 2)
            {
                if( e.Jobdescription.ToLower() == "manger")
                {
                    return returnvalue = new DellLaptopFactory();
                }
                else
                {
                    return returnvalue = new DellFactory();
                }
            }
            return null;
        }

   
    }
}
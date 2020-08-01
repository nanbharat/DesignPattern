using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.AbstractFactory
{
    public class EmployeeSystemManger
    {

        IComputerFactory _IcomputerFactory;

        public EmployeeSystemManger(IComputerFactory icomputerFactory)
        {
            _IcomputerFactory = icomputerFactory;
        }


         public string GetSystemDetails()
        {
            IBrand Brand = _IcomputerFactory.Brand();
            IProcessers processers = _IcomputerFactory.Processer();
            ISystemType system = _IcomputerFactory.SystemType();


            string returnvlaue = string.Format("{0} {1} {2}", 
                Brand.GetBrand()
                , processers.GetProcessor()
                , system.GetSystemType());


            return returnvlaue;

        }


    }
}
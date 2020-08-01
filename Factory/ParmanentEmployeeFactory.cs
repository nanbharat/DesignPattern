using Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory
{
    public class ParmanentEmployeeFactory : BaseEmployeeFactory
    {
        public ParmanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManger Create()
        {
            PermanentEmployeeManger manger = new PermanentEmployeeManger();
            _emp.HouseAllowence = manger.GetHouseAllowence();
            return manger;
        }
    }
}
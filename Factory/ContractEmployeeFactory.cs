using Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManger Create()
        {
            ContractEmployeeManger manger = new ContractEmployeeManger();
            _emp.MedicalAllowence = manger.GetMedicalAllowence();
            return manger;

        }
    }
}
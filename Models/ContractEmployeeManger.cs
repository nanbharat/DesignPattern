using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models
{
    public class ContractEmployeeManger : IEmployeeManger 
    {
        public decimal GetBonus()
        {
            return 12;
        }

        public decimal GetPay()
        {
            return 5;
        }

        public decimal GetMedicalAllowence()
        {
            return 100;
        }
    }
}
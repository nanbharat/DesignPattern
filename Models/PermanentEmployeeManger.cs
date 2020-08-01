using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models
{
    public class PermanentEmployeeManger : IEmployeeManger
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetPay()
        {
            return 10;
        }

        public decimal GetHouseAllowence()
        {
            return 150;
        }
    }
}
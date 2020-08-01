using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Models
{
    public interface IEmployeeManger
    {
        decimal GetPay();
        decimal GetBonus();
    }
}

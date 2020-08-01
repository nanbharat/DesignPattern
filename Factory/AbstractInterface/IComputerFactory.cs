using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory.AbstractFactory
{
   public interface IComputerFactory
    {
        IProcessers Processer();
        IBrand Brand();
        ISystemType SystemType();
    }
}

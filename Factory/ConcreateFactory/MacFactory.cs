using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.AbstractFactory
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {

            return new Mac();
        }

        public IProcessers Processer()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class MacLaptopfactory: MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
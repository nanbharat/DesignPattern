using Design_Pattern.Factory.Builder.ConcreateClass;
using Design_Pattern.Factory.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.Builder.Product
{
    public class LaptopBuilder
    {

        ComputerSystem laptop = new ComputerSystem();

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public void AddSize(string size)
        {
            laptop.HDDRAM = size;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
            throw new NotImplementedException();
        }
    }
}
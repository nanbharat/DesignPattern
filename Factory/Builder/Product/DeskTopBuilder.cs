using Design_Pattern.Factory.Builder.ConcreateClass;
using Design_Pattern.Factory.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.Builder.Product
{
    public class DeskTopBuilder 
    {


        ComputerSystem desktop = new ComputerSystem();

        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }

        public void AddSize(string size)
        {
            desktop.HDDRAM = size;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }


    }
}
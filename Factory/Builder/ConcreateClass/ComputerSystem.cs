using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Factory.Builder.ConcreateClass
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDDRAM { get; set; }
        public string Keyboard { get; set; }
        public string Mouse { get; set; }
        public string touchscreen { get; set; }

        public ComputerSystem()
        {
        }




    }
}
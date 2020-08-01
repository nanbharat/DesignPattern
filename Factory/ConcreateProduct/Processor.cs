using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Design_Pattern.Factory.Enumeration;

namespace Design_Pattern.Factory.AbstractFactory
{
    public class Processor : IProcessers
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();

        }
    }
}
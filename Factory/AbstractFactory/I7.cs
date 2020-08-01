using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Design_Pattern.Factory.Enumeration;

namespace Design_Pattern.Factory.AbstractFactory
{
    public class I7: IProcessers
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }

    public class I5 : IProcessers
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }

    public class I3 : IProcessers
    {
        public string GetProcessor()
        {
            return Processors.I3.ToString();
        }
    }


}
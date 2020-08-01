using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using static Design_Pattern.Factory.Enumeration;

namespace Design_Pattern.Factory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Laptop.ToString();
        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.DeskTop.ToString();
        }
    }
}
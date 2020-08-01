using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Builder.Product
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDD { get; set; }


        public ComputerSystem()
        {
        }

        public ComputerSystem( string ram, string hdd )
        {
            RAM = ram;
            HDD = hdd;
        }









    }
}
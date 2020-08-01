using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.fonts
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDiscription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal HourPay { get; set; }
        public decimal Bounes { get; set; }
        public string EmployeeTypeId { get; set; }
        public decimal? HouseAllowence { get; set; }
        public decimal? MedicalAllowence { get; set; }
        public string ComputerDetails { get; set; }


    }
}
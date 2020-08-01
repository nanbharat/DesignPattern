using Design_Pattern.Factory;
using Design_Pattern.Factory.AbstractFactory;
using Design_Pattern.fonts;
using Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_Pattern.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> data = null;
            using (ExamDbEntities dbcontext = new ExamDbEntities())
            {
                data = dbcontext.Employees.ToList();
            }

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new fonts.EmployeeModel();

            return View(model);

        }

        [HttpPost]
        public ActionResult CreateEmployee(
            [Bind(Include =
            "Id,Name,JobDiscription,Number,Department,EmployeeTypeId")]
        EmployeeModel model)
        {

            Employee ele = new Employee()
            {
                Name = model.Name,
                Jobdescription = model.JobDiscription,
                Number = model.Department,
                HourlyPay = model.HourPay,
                Bounes = model.Bounes,
                EmployeeTypeId = Convert.ToInt32(model.EmployeeTypeId)
            };

            if ( Convert.ToInt32(model.EmployeeTypeId) == 1)
            {
                model.HourPay = EmployeeFactory.GetFactory(ele).Create().GetPay() ;
                model.Bounes = EmployeeFactory.GetFactory(ele).Create().GetBonus();
                model.HouseAllowence = EmployeeFactory.GetFactory(ele).ApplySalary().HouseAllowence;

                IComputerFactory factory = EmployeeSystemFactory.create(ele);
                EmployeeSystemManger manger = new EmployeeSystemManger(factory);
                model.ComputerDetails =  manger.GetSystemDetails();
                ele.ComputerDetails = model.ComputerDetails;

            }
            else if( Convert.ToInt32(model.EmployeeTypeId) == 2) 
                {

                model.HourPay = EmployeeFactory.GetFactory(ele).Create().GetPay();
                model.Bounes = EmployeeFactory.GetFactory(ele).Create().GetBonus();
                model.MedicalAllowence = EmployeeFactory.GetFactory(ele).ApplySalary().MedicalAllowence;

                IComputerFactory factory = EmployeeSystemFactory.create(ele);
                EmployeeSystemManger manger = new EmployeeSystemManger(factory);
                model.ComputerDetails = manger.GetSystemDetails();
                ele.ComputerDetails = model.ComputerDetails;


            }
   


            using (ExamDbEntities dbcontext = new ExamDbEntities())
            {
                dbcontext.Employees.Add(ele);
                dbcontext.SaveChanges();
            }

                return Redirect("Index");
        }
    }
}
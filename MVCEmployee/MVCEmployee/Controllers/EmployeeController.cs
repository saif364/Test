using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Manager;

namespace MVCEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager EmployeeManager=new EmployeeManager();
        Employee _employee=new Employee();
        // GET: Employee
        public ActionResult Add()
        {
            _employee.Id = 101;
            _employee.Name = "Saif";
            EmployeeManager.Add(_employee);
            return View();
        }

        public ActionResult Delete()
        {

            _employee.Id = 3;
            EmployeeManager.Delete(_employee);
            return View();
        }

        public ActionResult Update()
        {
            _employee.Id = 5;

            //method1
            _employee.Name = "rahim";
            EmployeeManager.Update(_employee);

           




            return View();
        }

        public ActionResult GetById()
        {
            _employee.Id = 4;

            Employee employee = EmployeeManager.GetById(_employee);
            return View();
        }

        public ActionResult GetAll()
        {
            _employee.Id = 4;

            List<Employee> employees = EmployeeManager.GetAll(_employee);
            return View();
        }

    }
}
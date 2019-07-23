using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDbContext.DatabaseContext;
using Models.Model;

namespace Repository.Repository
{
  public  class EmployeeRepository
    {
       EmployeeDBContext db=new EmployeeDBContext();

        public bool Add( Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return true;
        }

        public bool Delete(Employee employee)
        {
           Employee aemployee = db.Employees.FirstOrDefault(e => e.Id == employee.Id);
            db.Employees.Remove(aemployee);
            db.SaveChanges();
            return true;
        }

        public bool Update(Employee employee)
        {
            Employee aemployee = db.Employees.FirstOrDefault(e => e.Id == employee.Id);
            aemployee.Name = employee.Name;
            db.SaveChanges();
            return true;
        }

        public List<Employee> GetAll(Employee employee)
        {
            return db.Employees.ToList();
        }

        public Employee GetById(Employee employee)
        {
            Employee aemployee = db.Employees.FirstOrDefault(e => e.Id == employee.Id);
            return aemployee;

        }
    }
}

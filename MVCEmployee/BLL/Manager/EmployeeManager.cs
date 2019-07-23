using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Repository.Repository;

namespace BLL.Manager
{
   public class EmployeeManager
    {
        EmployeeRepository EmployeeRepository=new EmployeeRepository();

        public bool Add(Employee employee )
        {
            return EmployeeRepository.Add(employee);
        }

        public bool Delete(Employee employee)
        {
            return EmployeeRepository.Delete(employee);
        }

        public bool Update(Employee employee)
        {
            return EmployeeRepository.Update(employee) ;
        }

        public Employee GetById(Employee employee)
        {
            return EmployeeRepository.GetById(employee);
        }

        public List<Employee> GetAll(Employee employee)
        {
            return EmployeeRepository.GetAll(employee);
        }
    }
}

using Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDbContext.DatabaseContext
{
  public  class EmployeeDBContext :DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
    }
}

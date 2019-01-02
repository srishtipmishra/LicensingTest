using LicensingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LicensingTest.Controllers
{
    public class EmployeeController : ApiController
    {
        private List<Employee> employeeList = new List<Employee>();

        public EmployeeController()
        {
            employeeList.AddRange(new List<Employee> {
                new Employee { ID = 100, Name = "Dipu", Department = "App Dev", Salary = 12000 },
                new Employee { ID = 101, Name = "Smitha", Department = "Admin ", Salary = 10000 },
            });
        }
        // GET: api/Deploy
        public IEnumerable<Employee> Get()
        {
            return employeeList;
        }

        // GET: api/Deploy/5
        public Employee Get(int id)
        {
            return employeeList.Find(x => x.ID == id);
        }

        // POST: api/Deploy
        public void Post([FromBody]Employee employee)
        {
            employeeList.Add(employee);
        }

        // DELETE: api/Deploy/5
        public void Delete(int id)
        {
            var employee = employeeList.Find(x => x.ID == id);
            if (employee != null) employeeList.Remove(employee);
        }

    }
}

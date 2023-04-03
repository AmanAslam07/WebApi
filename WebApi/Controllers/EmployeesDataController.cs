using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class EmployeesDataController : ApiController
    {
        static List<string> Employees =new List<string> { "Aman", "Ram", "singh","kunal","amit" };
        // GET Api/EmployeesData
        public IEnumerable<string> GetEmployees()
        {
            return Employees;
        }
        //GET Api/EmployeesData/{id}
        public string GetEmployeesByIndex(int id)
        {
            return Employees[id];
        }
        //POST Api/EmployeesData
        public void Post([FromBody]string value)
        {
            Employees.Add(value);
        }
        public void Put(int id, [FromBody]string value)
        {
            Employees[id] = value;
        }
        public void Delete(int id)
        {
            Employees.RemoveAt(id);
        }

 
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Controllers
{
    public class EmploymentController : ApiController
    {
       
        public string GetEmployees()
        {
            var people = Munq.MVC3.MunqDependencyResolver.Container.Resolve<IGetEmployee>().Execute();
            return Json.Encode(people);
        }

 
        public void AddEmployee(int personId)
        {
            var employee = new Employee()
            {
                EmployeeDate = DateTime.Now,
                EmployeeNum = Guid.NewGuid().ToString().Substring(0, 15),
                PersonId = personId,
                Terminated = null
            };

            Munq.MVC3.MunqDependencyResolver.Container.Resolve<IAddEmployee>().Execute(employee);
 
        }


        public void DismissEmployee(int employeeId)
        {
            Munq.MVC3.MunqDependencyResolver.Container.Resolve<IDismissEmployee>().Execute(employeeId);
        }

    }
}

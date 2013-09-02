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
    public class PersonController : ApiController
    {
        [HttpGet]
        public string GetPeople()
        {
            return Json.Encode(new Classes.GetPerson(new Test.Data.Crud.CrudDbContext()).Execute());
        }

        [HttpPost]
        public void Create(string firstname, string lastName, string dateOfBirth)
        {
            var person = new Person()
            {
                BirthDate = Convert.ToDateTime(dateOfBirth),
                FirstName = firstname,
                LastName = lastName
            };

            new Classes.AddPerson(new Test.Data.Crud.CrudDbContext()).Execute(person);
        }

        [HttpDelete]
        public void Delete(int personId)
        {
           
        }


        public void DeletePerson(int id)
        {
            Munq.MVC3.MunqDependencyResolver.Container.Resolve<IDeletePerson>().Execute(id);
        }
    }
}

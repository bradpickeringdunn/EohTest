using EOHTest.Data.Crud.Models;
using System;
using System.Web.Helpers;
using System.Web.Http;

namespace EOHTest.Service.Crud.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public string GetPeople()
        {
            return Json.Encode(new Classes.GetPerson(new EOHTest.Data.Crud.CrudDbContext()).Execute());
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

            new Classes.AddPerson(new EOHTest.Data.Crud.CrudDbContext()).Execute(person);
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

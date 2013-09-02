using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace Test.Data.Crud.Repositories
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        public PersonRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public IEnumerable<Models.Person> GetPeople()
        {
            return (from p in this.Context.Person
                    select p).ToList();
        }

        public Person GetPerson(int personId)
        {
            return GetPeople()
                .Where(p => p.PersonId == personId)
                .FirstOrDefault();
        }

        public void AddPerson(Person person)
        {
            Context.Person.Add(person);
            Context.SaveChanges();
        }

        public void DeleterPerson(int personId)
        {
            try
            {
                var person = (from p in this.Context.Person
                              where p.PersonId == personId
                              select p).First();

                this.Context.Person.Remove(person);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException.InnerException.Message.Contains("REFERENCE constraint"))
                {
                    throw new Exception("This employee cannot be deleted as they are currently listed in the employee data table");
                }
            }
        }
    }
}

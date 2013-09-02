using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Crud.Models;

namespace Test.Data.Crud.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Models.Person> GetPeople();

        Person GetPerson(int personId);

        void AddPerson(Person person);

        void DeleterPerson(int person);

    }
}

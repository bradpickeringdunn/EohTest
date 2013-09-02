using EOHTest.Data.Crud.Models;
using System.Collections.Generic;

namespace EOHTest.Data.Crud.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Models.Person> GetPeople();

        Person GetPerson(int personId);

        void AddPerson(Person person);

        void DeleterPerson(int person);

    }
}

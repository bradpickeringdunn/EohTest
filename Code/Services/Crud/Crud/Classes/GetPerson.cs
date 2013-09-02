using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Models;
using System.Collections.Generic;

namespace EOHTest.Service.Crud.Classes
{
    public class GetPerson : IGetPerson
    {
        private IUnitOfWork _context;

        public GetPerson(IUnitOfWork context)
        {
            this._context = context;
        }

        public IEnumerable<Person> Execute()
        {
            return new EOHTest.Data.Crud.Repositories.PersonRepository(_context).GetPeople();
        }

        public void Dispose()
        {
        }
    }
}
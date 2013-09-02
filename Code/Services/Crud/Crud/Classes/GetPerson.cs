using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
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
            return new Test.Data.Crud.Repositories.PersonRepository(_context).GetPeople();
        }

        public void Dispose()
        {
        }
    }
}
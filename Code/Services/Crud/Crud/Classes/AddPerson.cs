using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
{
    public class AddPerson : IAddPerson
    {
        private IUnitOfWork _context;

        public AddPerson(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(Person person)
        {
            new Test.Data.Crud.Repositories.PersonRepository(_context).AddPerson(person);
        }

        public void Dispose()
        {
        }
    }
}
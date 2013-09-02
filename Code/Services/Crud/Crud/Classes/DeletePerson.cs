using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
{
    public class DeletePerson : IDeletePerson
    {
        IUnitOfWork _context;

        public DeletePerson(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(int personId)
        {
            new Test.Data.Crud.Repositories.PersonRepository(_context).DeleterPerson(personId);
        }

        public void Dispose()
        {
        }
    }
}
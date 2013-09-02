using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
{
    public class UpdateEmployee : IUpdateEmployee
    {
        IUnitOfWork _context;

        public UpdateEmployee(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(int PersonId)
        {
            new Test.Data.Crud.Repositories.EmployeeRepository(_context).UpdateEmployee(PersonId);
        }

        public void Dispose()
        {
        }

    }
}
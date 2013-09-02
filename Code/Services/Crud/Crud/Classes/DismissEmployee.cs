using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Repositories;

namespace EohTest.Service.Crud.Classes
{
    public class DismissEmployee : IDismissEmployee
    {
        private IUnitOfWork _context;

        public DismissEmployee(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(int employeeId)
        {
            new EmployeeRepository(_context).Dismiss(employeeId);
        }

        public void Dispose()
        {
        }

    }
}
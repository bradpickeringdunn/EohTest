using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
{
    public class AddEmployee : IAddEmployee
    {
        private IUnitOfWork _context;

        public AddEmployee(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(Employee employee)
        {
            new Test.Data.Crud.Repositories.EmployeeRepository(_context).AddEmployee(employee);
        }

        public void Dispose()
        {
        }
    }
}
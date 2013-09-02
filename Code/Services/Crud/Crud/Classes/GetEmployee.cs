using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud.Classes
{
    public class GetEmployee : IGetEmployee
    {
        IUnitOfWork _cotext;

        public GetEmployee(IUnitOfWork context)
        {
            this._cotext = context;
        }

        public IEnumerable<Employee> Execute()
        {
            return new Test.Data.Crud.Repositories.EmployeeRepository(_cotext).RetrieveEmployees();
        }

        public void Dispose()
        {
        }
    }
}
using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Models;
using System.Collections.Generic;

namespace EOHTest.Service.Crud.Classes
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
            return new EOHTest.Data.Crud.Repositories.EmployeeRepository(_cotext).RetrieveEmployees();
        }

        public void Dispose()
        {
        }
    }
}
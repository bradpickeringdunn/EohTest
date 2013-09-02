using EOHTest.Data.Crud.Models;
using System.Collections.Generic;

namespace EOHTest.Data.Crud.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> RetrieveEmployees();
    }
}

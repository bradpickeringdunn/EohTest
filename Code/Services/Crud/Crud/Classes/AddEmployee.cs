
using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Models;
namespace EOHTest.Service.Crud.Classes
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
            new EOHTest.Data.Crud.Repositories.EmployeeRepository(_context).AddEmployee(employee);
        }

        public void Dispose()
        {
        }
    }
}
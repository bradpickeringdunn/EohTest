
using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Repositories;
namespace EOHTest.Service.Crud.Classes
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
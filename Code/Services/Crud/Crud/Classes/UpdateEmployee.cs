using EOHTest.Data.Crud.Interfaces;

namespace EOHTest.Service.Crud.Classes
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
            new EOHTest.Data.Crud.Repositories.EmployeeRepository(_context).UpdateEmployee(PersonId);
        }

        public void Dispose()
        {
        }

    }
}
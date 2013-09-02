using EOHTest.Data.Crud.Interfaces;

namespace EOHTest.Service.Crud.Classes
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
            new EOHTest.Data.Crud.Repositories.PersonRepository(_context).DeleterPerson(personId);
        }

        public void Dispose()
        {
        }
    }
}
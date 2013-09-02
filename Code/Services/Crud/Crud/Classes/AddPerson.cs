
using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Models;
namespace EOHTest.Service.Crud.Classes
{
    public class AddPerson : IAddPerson
    {
        private IUnitOfWork _context;

        public AddPerson(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Execute(Person person)
        {
            new EOHTest.Data.Crud.Repositories.PersonRepository(_context).AddPerson(person);
        }

        public void Dispose()
        {
        }
    }
}
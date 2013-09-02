using EOHTest.Data.Crud.Models;
using System;

namespace EOHTest.Service.Crud
{
    public interface IAddPerson : IDisposable
    {
        void Execute(Person person);
    }
}

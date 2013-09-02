using EOHTest.Data.Crud.Models;
using System;
using System.Collections.Generic;

namespace EOHTest.Service.Crud
{
    public interface IGetPerson : IDisposable
    {
        IEnumerable<Person> Execute();
    }
}

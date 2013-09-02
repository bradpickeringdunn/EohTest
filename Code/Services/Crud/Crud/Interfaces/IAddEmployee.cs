using EOHTest.Data.Crud.Models;
using System;

namespace EOHTest.Service.Crud
{
    public interface IAddEmployee : IDisposable
    {
        void Execute(Employee employee);
    }
}

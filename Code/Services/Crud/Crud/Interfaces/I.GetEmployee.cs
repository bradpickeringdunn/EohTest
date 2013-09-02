using EOHTest.Data.Crud.Models;
using System;
using System.Collections.Generic;

namespace EOHTest.Service.Crud
{
    public interface IGetEmployee : IDisposable
    {
        IEnumerable<Employee> Execute();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EohTest.Service.Crud
{
    public interface IUpdateEmployee : IDisposable
    {
        void Execute(int PersonId);
    }
}

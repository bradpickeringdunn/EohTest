using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOHTest.Service.Crud
{
    public interface IDeletePerson : IDisposable
    {
        void Execute(int personId);
    }
}

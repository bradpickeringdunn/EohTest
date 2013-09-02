using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Crud.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int PersonId { get; set; }

        public string EmployeeNum { get; set; }

        public DateTime EmployeeDate { get; set; }

        public DateTime? Terminated { get; set; }

        public virtual Person Person { get; set; }

    }
}

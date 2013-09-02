using System;

namespace EOHTest.Data.Crud.Models
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

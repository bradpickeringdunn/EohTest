using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EohTest.Ui.Employment.Dto
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public Dto.Person Person { get; set; }
        public string EmployeeNum { get; set; }
        public DateTime EmployeeDate { get; set; }
        public DateTime? Terminated { get; set; }
    }
}
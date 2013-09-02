using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace EOHTest.Ui.Web.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            _employees = new List<Dto.Employee>();
        }

        private IEnumerable<Dto.Employee> _employees;

        public IEnumerable<Dto.Employee> Employees
        {
            get
            {
                return _employees;
            }
        }

        public void GetEmployees()
        {
            var employees = new EOHTest.Service.Crud.Controllers.EmploymentController().GetEmployees();
            _employees = Json.Decode<List<Dto.Employee>>(employees)
                .FindAll(e => e.Terminated == null);
        }

        internal void DismissEmployee(int employeeId)
        {
            new EOHTest.Service.Crud.Controllers.EmploymentController().DismissEmployee(employeeId);
        }
    }
}
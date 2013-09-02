using EOHTest.Data.Crud.Interfaces;
using EOHTest.Data.Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EOHTest.Data.Crud.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public IEnumerable<Employee> RetrieveEmployees()
        {
            IEnumerable<Employee> employees = new List<Employee>();


                employees = (from e in this.Context.Employee
                             where e.Terminated == null
                             select e).ToList();
            
            
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                var newEmployee = new Models.Employee()
                {
                    EmployeeDate = DateTime.Now,
                    EmployeeNum = employee.EmployeeNum,
                    PersonId = employee.PersonId
                };

                Context.Employee.Add(employee);

                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException.InnerException.Message.Contains("duplicate key"))
                {
                    throw new Exception("This candidate has already been employed.  Please chose another.");
                }
            }
            
        }

        public void Dismiss(int employeeId)
        {
            var employee = (from e in this.Context.Employee
                            where e.EmployeeId == employeeId
                            select e)
                            .First();

            this.Context.Employee.Attach(employee);
            employee.Terminated = DateTime.Now;
            this.Context.Entry(employee).State = System.Data.Entity.EntityState.Modified;

            this.Context.SaveChanges();
        }

        public void UpdateEmployee(int PersonId)
        {
            throw new NotImplementedException();
        }
    }
}

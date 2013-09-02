using System.Data.Entity.ModelConfiguration;

namespace EOHTest.Data.Crud.Mappings
{
    public class Employee : EntityTypeConfiguration<Models.Employee>
    {
        public Employee()
        {
            this.HasKey(t => t.EmployeeId);

            this.ToTable("Employee");

            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            this.Property(t => t.EmployeeDate).HasColumnName("EmployeeDate");

            this.Property(t => t.EmployeeNum).HasColumnName("EmployeeNum");

            this.Property(t => t.PersonId).HasColumnName("PersonId");

            this.Property(t => t.Terminated).HasColumnName("Terminated");

            this.HasRequired<Models.Person>(e => e.Person);
        }

    }
}

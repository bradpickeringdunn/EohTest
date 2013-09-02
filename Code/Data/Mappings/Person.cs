using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Crud.Mappings
{
    public class Person : EntityTypeConfiguration<Models.Person>
    {
        public Person()
        {
            this.ToTable("Person");
            this.HasKey(t => t.PersonId);

            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Crud.Interfaces;
using Test.Data.Crud.Mappings;

namespace Test.Data.Crud
{
    public class CrudDbContext : DbContext, IUnitOfWork
    {
        public CrudDbContext()
            : base("Name=CrudConnectionString")
        {
            Database.SetInitializer<CrudDbContext>(null);
        }

        public DbSet<Models.Person> Person { get; set; }
        public DbSet<Models.Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

    //        modelBuilder.Entity<Models.Person>()
    //.HasKey(t => t.PersonId);

    //        modelBuilder.Entity<Models.Employee>()
    //            .HasRequired(t => t.Person)
    //            .WithRequiredPrincipal();

        }

        void IUnitOfWork.SaveChanges()
        {
            base.SaveChanges();
        }

        
    }
    
}

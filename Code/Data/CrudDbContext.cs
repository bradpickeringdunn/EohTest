using EOHTest.Data.Crud.Interfaces;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EOHTest.Data.Crud
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
 
        }

        void IUnitOfWork.SaveChanges()
        {
            base.SaveChanges();
        }

        
    }
    
}

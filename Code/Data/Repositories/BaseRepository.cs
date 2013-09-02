using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Crud.Interfaces;

namespace Test.Data.Crud.Repositories
{
    public class BaseRepository
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        protected CrudDbContext Context
        {
            get { return (CrudDbContext)this.UnitOfWork; }
        }

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            this.UnitOfWork = unitOfWork;
        }

        protected virtual DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return this.Context.Set<TEntity>();
        }

    }
}

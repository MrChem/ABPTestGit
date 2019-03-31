using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WENTE.EntityFramework.Repositories
{
    public abstract class WENTERepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WENTEDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WENTERepositoryBase(IDbContextProvider<WENTEDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WENTERepositoryBase<TEntity> : WENTERepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WENTERepositoryBase(IDbContextProvider<WENTEDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace CodigoMaestro.EntityFramework.Repositories
{
    public abstract class CodigoMaestroRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CodigoMaestroDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class CodigoMaestroRepositoryBase<TEntity> : CodigoMaestroRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repositories
{
    public interface ISectionRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}

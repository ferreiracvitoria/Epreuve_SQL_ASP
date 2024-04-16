﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface ICategorieRepository<TEntity> 
    {
        IEnumerable<TEntity> Get();
    }
}

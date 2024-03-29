﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        public IEnumerable<TEntity>  GetMediaForProduit(int id_Produit);
    }
}

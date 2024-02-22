﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface IProduitRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        /*public IEnumerable<TEntity> GetByCategorie(int id);
        public IEnumerable<TEntity> GetByCritereEcologique(int id);*/

    }
}

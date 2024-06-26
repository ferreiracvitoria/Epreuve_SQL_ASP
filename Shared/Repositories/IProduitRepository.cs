﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface IProduitRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        IEnumerable<TEntity> GetByCategorie(string categorie);
        IEnumerable<TEntity> GetByCritere(string critereEcologique);
        IEnumerable<TEntity> GetByNom(string nomProduit);


    }
}

using DAL = DAL_Epreuve.Entities;
using BLL_Epreuve.Entities;
using Shared.Repositories;
using BLL_Epreuve.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL_Epreuve.Services
{
    public class CategorieService : ICategorieRepository<Categorie>
    {
        private readonly ICategorieRepository<DAL.Categorie> _repository;
        public CategorieService(ICategorieRepository<DAL.Categorie> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Categorie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

    }
}

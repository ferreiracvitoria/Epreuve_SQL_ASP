using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shared.Repositories;
using BLL_Epreuve.Mappers;

namespace BLL_Epreuve.Services
{
    internal class CritereEcologiqueService : ICritereEcologiqueRepository<CritereEcologique>
    {
        private readonly ICritereEcologiqueRepository<DAL.CritereEcologique> _CritereEcologiqueRepository;
        private readonly IProduitRepository<DAL.Produit> _ProduitRepository;

        public CritereEcologiqueService(ICritereEcologiqueRepository<DAL.CritereEcologique> CritereEcologiqueRepository, IProduitRepository<DAL.Produit> ProduitRepository)
        {
            _CritereEcologiqueRepository = CritereEcologiqueRepository;
            _ProduitRepository = ProduitRepository;
        }
        public IEnumerable<CritereEcologique> Get()
        {
            return _CritereEcologiqueRepository.Get().Select(d => d.ToBLL());
        }

    }
}


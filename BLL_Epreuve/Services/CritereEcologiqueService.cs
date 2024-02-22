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
        /*public CritereEcologique Get(int id)
        {
            CritereEcologique entity = _CritereEcologiqueRepository.Get(id).ToBLL();
            entity.AddGroupProduits(_ProduitRepository.GetByCritereEcologique(id).Select(d => d.ToBLL()));
            return entity;
        }*/
        public int Insert(CritereEcologique data)
        {
            return _CritereEcologiqueRepository.Insert(data.ToDAL());
        }
        public void Update(CritereEcologique data)
        {
            _CritereEcologiqueRepository.Update(data.ToDAL());
        }
        public void Delete(int id)
        {
            _CritereEcologiqueRepository.Delete(id);
        }
    }
}
}

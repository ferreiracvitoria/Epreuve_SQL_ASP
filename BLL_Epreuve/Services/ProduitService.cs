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
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _repository;

        public ProduitService(IProduitRepository<DAL.Produit> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Produit> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }
        public Produit Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            return _repository.GetByCategorie(categorie).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetByCritere(string critereEcologique)
        {
            return _repository.GetByCritere(critereEcologique).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetByNom(string nomProduit)
        {
            return _repository.GetByNom(nomProduit).Select(d => d.ToBLL());
        }
        public int Insert(Produit data)
        {
            return _repository.Insert(data.ToDAL());
        }
        public void Update(Produit data)
        {
            _repository.Update(data.ToDAL());
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

    }
}


using ASPEpreuve.Models;
using BLL_Epreuve.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Cryptography.X509Certificates;

namespace ASPEpreuve.Handlers
{
    public static class Mapper
    {
        #region Produit
        public static ProduitAffichageListModel ToListProduit(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitAffichageListModel()
            {
                Id_Produit = entity.Id_Produit,
                Id_CritereEcologique = entity.Id_CritereEcologique,
                Id_Categorie = entity.Id_Categorie,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Stock = entity.Stock,
            };
        }

        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Id_CritereEcologique = entity.Id_CritereEcologique,
                Id_Categorie = entity.Id_Categorie,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Stock = entity.Stock,
            };

        }

        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                0,
                0,
                0,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Stock
                );
        }
        #endregion
    }
}

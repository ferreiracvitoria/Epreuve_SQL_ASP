using System;
using System.Collections.Generic;
using System.Text;
using DAL = DAL_Epreuve.Entities;
using BLL_Epreuve.Entities;

namespace BLL_Epreuve.Mappers
{
    public static class Mapper
    {
        #region Produit
        public static Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.CritereEcologique,
                entity.Categorie,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Stock);
        }

        public static DAL.Produit ToDAL(this Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
            {
                Id_Produit = entity.Id_Produit,
                CritereEcologique = entity.CritereEcologique,
                Categorie = entity.Categorie,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Stock = entity.Stock,
            };
        }
        #endregion

        #region Critere Ecologique
        public static CritereEcologique ToBLL(this DAL.CritereEcologique entity)
        {
            if (entity is null) return null;
            return new CritereEcologique(
                entity.Nom
            );
        }

        

        #endregion

        #region Categorie
        public static Categorie ToBLL(this DAL.Categorie entity)
        {
            if (entity is null) return null;
            return new Categorie(
                entity.Nom);
        }


        #endregion

        #region Media
        public static Media ToBLL(this DAL.Media entity)
        {
            if (entity is null) return null;
            return new Media(
                entity.Id_Media,
                entity.Id_Produit,
                entity.UrlImage);
        }

        public static DAL.Media ToDAL(this Media entity)
        {
            if (entity is null) return null;
            return new DAL.Media()
            {
                Id_Media = entity.Id_Media,
                Id_Produit = entity.Id_Produit,
                UrlImage = entity.UrlImage
            };
        }

        #endregion

        #region Section
        public static Section ToBLL(this DAL.Section entity)
        {
            if (entity is null) return null;
            return new Section(
                entity.Id_Section,
                entity.Id_Produit,
                entity.Id_Commande,
                entity.Quantite
            );
        }
        #endregion
    }
}

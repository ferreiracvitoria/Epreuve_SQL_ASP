using System;
using System.Collections.Generic;
using System.Text;
using DAL = DAL_Epreuve.Entities;
using BLL = BLL_Epreuve.Entities;

namespace BLL_Epreuve.Mappers
{
    public static class Mapper
    {
        #region Produit
        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.Id_CritereEcologique,
                entity.Id_Categorie,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Stock);
        }

        public static DAL.Produit ToDAL(this BLL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
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
        #endregion

        #region Critere Ecologique
        public static BLL.CritereEcologique ToBLL(this DAL.CritereEcologique entity)
        {
            if (entity is null) return null;
            return new BLL.CritereEcologique(
                entity.Id_CritereEcologique,
                entity.Nom);
        }

        public static DAL.CritereEcologique ToDAL(this BLL.CritereEcologique entity)
        {
            if (entity is null) return null;
            return new DAL.CritereEcologique()
            {
                Id_CritereEcologique = entity.Id_CritereEcologique,
                Nom = entity.Nom,
            };
        }

        #endregion

        #region Categorie
        public static BLL.Categorie ToBLL(this DAL.Categorie entity)
        {
            if (entity is null) return null;
            return new BLL.Categorie(
                entity.Id_Categorie,
                entity.Nom);
        }

        public static DAL.Categorie ToDAL(this BLL.Categorie entity)
        {
            if (entity is null) return null;
            return new DAL.Categorie()
            {
                Id_Categorie = entity.Id_Categorie,
                Nom = entity.Nom,
            };
        }

        #endregion
    }
}

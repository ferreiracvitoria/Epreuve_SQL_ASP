using DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_Epreuve.Mappers
{
    internal static class Mapper
    {
        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                Id_CritereEcologique = (int)record["Id_CritereEcologique"],
                Id_Categorie = (int)record["Id_Categorie"],
                Nom = (string)record["Nom"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                Stock = (int)record["Stock"]
            };
        }

        public static Section ToSection(this IDataRecord record)
        {
            if (record is null) return null;
            return new Section()
            {
                Id_Section = (int)record["Id_Section"],
                Id_Commande = (int)record["Id_Commande"],
                Id_Produit = (int)record["Id_Produit"],
                Quantite = (int)record["Quantite"]
                
            };
        }

        public static Media ToMedia(this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Id_Media = (int)record["Id_Media"],
                Id_Produit = (int)record["Id_Produit"],
                UrlImage = (string)record["UrlImage"]

            };
        }

        public static CritereEcologique ToCritereEcologique(this IDataRecord record)
        {
            if (record is null) return null;
            return new CritereEcologique()
            {
                Id_CritereEcologique = (int)record["Id_CritereEcologique"],
                Nom = (string)record["Nom"],
            };
        }

        public static Commande ToCommande(this IDataRecord record)
        {
            if (record is null) return null;
            return new Commande()
            {
                Id_Commande = (int)record["Id_Commande"],
                DateCommande = (DateTime)record["DateCommande"]
            };
        }

        public static Categorie ToCategorie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categorie()
            {
                Id_Categorie = (int)record["Id_Commande"],
                Nom = (string)record["Nom"]
            };
        }

    }
}

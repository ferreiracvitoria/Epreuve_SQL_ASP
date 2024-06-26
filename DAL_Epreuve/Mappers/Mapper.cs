﻿using DAL_Epreuve.Entities;
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
                CritereEcologique = (string)record["CritereEcologique"],
                Categorie = (string)record["Categorie"],
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
            return new CritereEcologique
            {
                Nom = (string)record[nameof(CritereEcologique.Nom)],
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
            return new Categorie
            {
                Nom = (string)record[nameof(Categorie.Nom)]
            };
        }

    }
}

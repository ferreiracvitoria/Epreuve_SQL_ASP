using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public int Id_CritereEcologique { get; set; }
        public int Id_Categorie { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }

        public Produit(int id_produit, int id_critereEcologique, int id_categorie, string nom, string description, decimal prix, int stock) 
        {
            Id_Produit = id_produit;
            Id_CritereEcologique = id_critereEcologique;
            Id_Categorie = id_categorie;
            Nom = nom;
            Description = description;
            Prix = prix;
            Stock = stock;
        }

    }


}

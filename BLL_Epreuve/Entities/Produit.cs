using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string CritereEcologique { get; set; }
        public string Categorie { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }

        public Produit(int id_produit, string critereEcologique, string categorie, string nom, string description, decimal prix, int stock) 
        {
            Id_Produit = id_produit;
            CritereEcologique = critereEcologique;
            Categorie = categorie;
            Nom = nom;
            Description = description;
            Prix = prix;
            Stock = stock;
        }

    }


}

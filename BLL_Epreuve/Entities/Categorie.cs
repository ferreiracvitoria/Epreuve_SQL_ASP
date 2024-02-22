using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Categorie
    {

        public int Id_Categorie { get; set; }
        public string Nom { get; set; }

        public Categorie(int id_Categorie, string nom)
        {
            Id_Categorie = id_Categorie;
            Nom = nom;
        }
    }
}

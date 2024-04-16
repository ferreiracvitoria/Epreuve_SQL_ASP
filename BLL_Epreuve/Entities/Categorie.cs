using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Categorie
    {
        public string Nom { get; set; }

        public Categorie(string nom)
        {
            Nom = nom;
        }
    }
}

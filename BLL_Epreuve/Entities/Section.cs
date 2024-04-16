using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Section
    {
        public int Id_Section { get; set; }
        public int Id_Produit { get; set; }
        public int Id_Commande { get; set; }
        public int Quantite { get; set; }

        public Section(int id_produit, int id_section, int id_commande, int quantite) 
        {
            Id_Section = id_section;
            Id_Produit = id_produit;
            Id_Commande = id_commande;
            Quantite = quantite;
        }

    }
}
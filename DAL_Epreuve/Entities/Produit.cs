using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public int Id_CritereEcologique { get; set; }
        public int Id_Categorie { get; set; }
        public string Nom {  get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string CritereEcologique { get; set; }
        public string Categorie { get; set; }
        public string Nom {  get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }
    }
}

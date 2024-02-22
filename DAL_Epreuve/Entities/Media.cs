using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public int Id_Produit { get; set; }
        public string UrlImage { get; set; }
    }
}

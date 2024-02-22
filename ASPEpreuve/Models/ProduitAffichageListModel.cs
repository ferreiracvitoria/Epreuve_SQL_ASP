using BLL_Epreuve.Entities;
using System.ComponentModel;

namespace ASPEpreuve.Models
{
    public class ProduitAffichageListModel
    {
        public List<Produit> Produits { get; set; }
        public int Id_Produit { get; set; }
        public int Id_CritereEcologique { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }

        public string Description { get; set; }
        
        [DisplayName("Categorie")]
        public int Id_Categorie { get; set; }
        
        [DisplayName("Prix")]
        public decimal Prix { get; set; }
        public int Stock { get; set; }
    }
}

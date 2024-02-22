using System.ComponentModel;

namespace ASPEpreuve.Models
{
    public class ProduitEditViewModel
    {
        public int Id_Produit { get; set; }
        public int Id_CritereEcologique { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }

        [DisplayName("Description")]

        public string Description { get; set; }


        [DisplayName("Prix")]
        public decimal Prix { get; set; }

        [DisplayName("Stock")]
        public int Stock { get; set; }

        [DisplayName("Categorie")]
        public int Id_Categorie { get; set; }
    }
}
